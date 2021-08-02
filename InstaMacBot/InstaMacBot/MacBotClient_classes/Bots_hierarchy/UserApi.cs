using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Logger;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaMacBot.classes
{
    /// <summary>
    /// <para>this class represents the instagram user and contains the api taken from InstagramApiSharp (github project: https://github.com/ramtinak/InstagramApiSharp)</para>
    /// <para>to do all action on instagram</para>
    /// <para>the objects of this class are mutable</para>
    /// <para>check InstagramApiSharp wiki https://github.com/ramtinak/InstagramApiSharp/wiki to see all IResult used inside the functions</para>
    /// </summary>
    public class UserApi
    {
        /// <summary>
        /// user infos like username and password
        /// </summary>
        private UserSessionData user;

        /// <summary>
        /// instApiSharp object (private api to instagram)
        /// </summary>
        private IInstaApi api;


        /// <param name="username">username of the account that will login to instagram ant the bot will perform actions</param>
        /// <param name="password">password of the account to login</param>
        public UserApi(string username, string password)
        {

            user = new UserSessionData();
            user.UserName = username;
            user.Password = password;

            api = InstaApiBuilder.CreateBuilder()
           .SetUser(user)
           .UseLogger(new DebugLogger(LogLevel.Exceptions))
           //.SetRequestDelay(RequestDelay.FromSeconds(5, 8))
           .Build();

        }

        private UserApi(string session_json)
        {
            api = InstaApiBuilder.CreateBuilder()
                .SetUser(UserSessionData.Empty)
                //.SetRequestDelay(RequestDelay.FromSeconds(2, 2))
                .Build();
             api.LoadStateDataFromString(session_json);
        }


        /// <summary>
        /// production method, used to create a UserApi object from a session json file
        /// </summary>
        /// <param name="session_json">the json file that contains all session parameters</param>
        /// <returns>an UserApi that restored a session (logged inside the targhet user using his last session)</returns>
        public static async Task<UserApi> Get_userApi_from_session(string session_json)
        {
            UserApi myuser = new UserApi(session_json);
            myuser.user = myuser.api.GetLoggedUser();
            var result2 = await myuser.get_user(myuser.get_username());

            if (result2.Succeeded)
                return myuser;
            else
                return null;
        }





        /// <summary>
        /// get the username of this: is the account associated to this (this object)
        /// </summary>
        /// <returns></returns>
        public string get_username()
        {
            return user.UserName;
        }

        /// <summary>
        /// sleeps the cpu for some seconds
        /// </summary>
        /// <param name="seconds">number of seconds of sleep</param>
        /// <returns>true when delay finishes</returns>
        private async Task<bool> wait(int secondi)
        {
            int i = 0;
            while (i < secondi)
            {
                await Task.Delay(1000);
                i++;
            }
            return true;
        }

        
        /// <summary>
        /// check if the user is autenticated (if logghed with session it is false)
        /// </summary>
        public bool is_autentitcated { get { return api.IsUserAuthenticated; } }
        

        /// <summary>
        /// login inside the account associated to this
        /// </summary>
        /// <returns>
        /// <para>"" (empty string) if can login inside the account</para>
        /// <para>an error message if can't login in to the account</para>
        /// </returns>
        public async Task<string> loginAsync()
        {
            if (api.IsUserAuthenticated)
            {
                return "already logged";
            }


            await api.SendRequestsBeforeLoginAsync();
            await wait(2); //instagram charp api documentations waits 5 seconds i reduced that value


            var loginRequest = await api.LoginAsync();

            if (loginRequest.Succeeded)
            {
                return "";
            }
            else
            {

                if (loginRequest.Value == InstaLoginResult.ChallengeRequired)
                {
                    var challenge = await api.GetChallengeRequireVerifyMethodAsync();

                    if (challenge.Succeeded)
                    {
                        return "instagram blocked bot access caused by an unusual phone (this bot) is connecting to your account, open instagram and allow this new phone after relogin with bot.\n(it may be necessary to do this procedure several time, if the problem persists after a few tries wait some hours or one day)";
                    }

                    return challenge.Info.Message;

                }

                return loginRequest.Info.Message;

            }

        }

        /*
        public async Task<string> logoutAsync()
        {
            IResult<bool> logoutRequest = await api.LogoutAsync();

            if (logoutRequest.Succeeded)
            {
                return "logged out";
            }
            else
            {
                return "logout error (close and reopen the entire bot): " + logoutRequest.Info.Message;
            }
        }
        */


        //wrap here all api actions you need in the bots

        /// <summary>
        /// leave a like on a media (with the account that this is logged) 
        /// </summary>
        /// <param name="media_id">the id if the media that this will leave like</param>
        /// <returns>
        /// <para>true if the like was successfully placed</para>
        /// <para>false if the like wasn't successfully placed</para>
        /// </returns>
        public async Task<bool> put_like(string media_id)
        {
            //if (!is_logged)
            //    return false;


            IResult<bool> like_request = await api.MediaProcessor.LikeMediaAsync(media_id);

            if (like_request.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// follow an account (with the account that this is logged) 
        /// </summary>
        /// <param name="username">the username of the account that will be followed</param>
        /// <returns>
        /// <para>true if the follow was successfully</para>
        /// <para>false if the follow wasn't successfully</para>
        /// </returns>
        public async Task<bool> follow(string username)
        {
            //if (!is_logged)
            //    return false;

            IResult<InstaUserInfo> utente = await api.UserProcessor.GetUserInfoByUsernameAsync(username);
            if (!utente.Succeeded)
                return false;


            IResult<InstaFriendshipFullStatus> follow_request = await api.UserProcessor.FollowUserAsync(utente.Value.Pk);

            if (follow_request.Succeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// unfollow an account (with the account that this is logged) 
        /// </summary>
        /// <param name="user_id">the id of the account that will be unfollowed</param>
        /// <returns>
        /// <para>true if the unfollow was successfully</para>
        /// <para>false if the unfollow wasn't successfully</para>
        /// </returns>
        public async Task<bool> unfollow(long user_id)
        {
            IResult<InstaFriendshipFullStatus> unfollow_request = await api.UserProcessor.UnFollowUserAsync(user_id);

            if (unfollow_request.Succeeded)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// scrape a list of lasts media of an account
        /// </summary>
        /// <param name="username">username of the account where scrape lasts media</param>
        /// <returns>a list of lasts media of an account</returns>
        public async Task<IResult<InstaMediaList>> lasts_media_id(string username)
        {
            return await api.UserProcessor.GetUserMediaAsync(username, PaginationParameters.MaxPagesToLoad(1));
        }

        /// <summary>
        /// get an instagram user
        /// </summary>
        /// <param name="username">the username of the instagram user</param>
        /// <returns>an instagram user</returns>
        public async Task<IResult<InstaUser>> get_user(string username)
        {
            return await api.UserProcessor.GetUserAsync(username);
        }

        /// <summary>
        /// get the infos of an instagram user
        /// </summary>
        /// <param name="username">the username of the instagram user</param>
        /// <returns>the infos of an instagram user</returns>
        public async Task<IResult<InstaUserInfo>> get_user_info(string username)
        {
            return await api.UserProcessor.GetUserInfoByUsernameAsync(username);
        }

        //230 pags are about 20k accounts
        PaginationParameters limit = PaginationParameters.MaxPagesToLoad(230);


        /// <summary>
        /// get a list of account that are followers of a target account
        /// </summary>
        /// <param name="username">the target account</param>
        /// <returns></returns>
        public async Task<IResult<InstaUserShortList>> get_user_followers(string username)
        {
            return await api.UserProcessor.GetUserFollowersAsync(username, limit);
        }


        /// <summary>
        /// get a set of account username that have posted a photo recently with a target hastag
        /// </summary>
        /// <param name="hastag">the target hastag</param>
        /// <returns>a set of account username that have posted a photo recently with the target hastag</returns>
        public async Task<HashSet<string>> get_user_from_hastag(string hastag)
        {
            HashSet<string> output = new HashSet<string>();
            IResult<InstaSectionMedia> request = await api.HashtagProcessor.GetRecentHashtagMediaListAsync(hastag, limit);
            if (request.Value != null)
            {
                List<InstaMedia> list_media = request.Value.Medias;
                for (int i = 0; i < list_media.Count; i++)
                {
                    if (!(output.Contains(list_media[i].User.UserName)))
                        output.Add(list_media[i].User.UserName);
                }
            }
            return output;
        }

        /// <summary>
        /// get a set of account username that have posted a photo recently with a target location id
        /// </summary>
        /// <param name="location_id">the target location id</param>
        /// <returns>a set of account username that have posted a photo recently with the target location id</returns>
        public async Task<HashSet<string>> get_user_from_location(string location_id)
        {
            HashSet<string> output = new HashSet<string>();

            IResult<InstaPlaceShort> x = await api.LocationProcessor.GetLocationInfoAsync(location_id);
            if (x.Value == null)
            {
                return null;
            }

            IResult<InstaSectionMedia> request = await api.LocationProcessor.GetRecentLocationFeedsAsync(x.Value.Pk, limit);
            if (request.Value != null)
            {
                List<InstaMedia> list_media = request.Value.Medias;
                for (int i = 0; i < list_media.Count; i++)
                {
                    if (!(output.Contains(list_media[i].User.UserName)))
                        output.Add(list_media[i].User.UserName);
                }
            }
            return output;
        }

        /// <summary>
        /// get a set of accounts username that this account (the account associated to this) is following
        /// </summary>
        /// <returns>get a set of accounts username that this account is following</returns>
        public async Task<HashSet<string>> get_following()
        {
            HashSet<string> following = new HashSet<string>();

            IResult<InstaUserShortList> x = await api.UserProcessor.GetUserFollowingAsync(user.UserName, PaginationParameters.Empty);

            for (int i = 0; i < x.Value.Count; i++)
            {
                following.Add(x.Value[i].UserName);
            }

            return following;
        }

        /// <summary>
        /// this account will send a dm to an account
        /// </summary>
        /// <param name="message">the dm message</param>
        /// <param name="username_to_send">the destinatary account username</param>
        /// <returns>
        /// <para>true if the dm was sent</para>
        /// <para>false if the dm wasn't sent</para>
        /// </returns>
        public async Task<bool> send_dm_text(string message, string username_to_send)
        {
            var user = await get_user(username_to_send);
            var userId = user.Value.Pk.ToString();

            var directText = await api.MessagingProcessor.SendDirectTextAsync(userId, null, message);

            if (directText.Succeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// get a string that contains the content of the session json file
        /// </summary>
        /// <returns>a string that contains the content of the session json file</returns>
        public string get_session()
        {
            return api.GetStateDataAsString();
        }

        /*
        public async Task<bool> send_dm_link(string link, string username_to_send, string message = "a")
        {

            var user = await get_user(username_to_send);
            var userId = user.Value.Pk.ToString();

            var inbox = await api.MessagingProcessor.GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(1));

            var desireUsername = username_to_send;
            var desireThread = inbox.Value.Inbox.Threads.Find(u => u.Users.FirstOrDefault().UserName.ToLower() == desireUsername);
            var requestedThreadId = desireThread.ThreadId;
            string[] treadsid_array = { requestedThreadId };

            var directLink = await api.MessagingProcessor.SendDirectLinkAsync(message, link, treadsid_array);


            if (directLink.Succeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
    }
}
