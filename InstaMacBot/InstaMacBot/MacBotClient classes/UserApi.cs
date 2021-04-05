using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Logger;

namespace InstaMacBot
{
    class UserApi
    {
        //OVERVIEW: this class represents the instagram user and contains the api to do all action on instagram
        //          the objects of tis class are mutable

        private UserSessionData user;
        private IInstaApi api;
        private bool logged;
        
       //costructor
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

            logged = false;


        }

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

        public bool is_logged { get { return logged; } }

        
        public async Task<string> loginAsync()
        {
            if (api.IsUserAuthenticated)
            {
                logged = true;
                return "already logged";
            }
            

            await api.SendRequestsBeforeLoginAsync();

            var loginRequest = await api.LoginAsync();

            if (loginRequest.Succeeded)
            {
                logged = true;
                return "";
            }
            else
            {
                if(loginRequest.Value == InstaLoginResult.ChallengeRequired)
                {
                    var challenge = await api.GetChallengeRequireVerifyMethodAsync();
                    if (challenge.Succeeded)
                    {
                        do
                        {
                            MessageBox.Show("open instagram and click 'am i' on challenge request (if doesen't have challenge request on your instagram click ok and close bot)");
                            await wait(5);
                        } while (challenge.Value.SubmitPhoneRequired);

                        logged = true;
                        return "";
                    }
                    else
                        return challenge.Info.Message;
                }

                return loginRequest.Info.Message;

            }
            
        }

        public async Task<string> logoutAsync()
        {
            IResult<bool> logoutRequest = await api.LogoutAsync();

            if (logoutRequest.Succeeded)
            {
                return "logout";
            }
            else
            {
                return "logout error (close and reopen the entire bot): " + logoutRequest.Info.Message;
            }
        }


        //wrap here all api actions you need in the bots

        public async Task<bool> put_like(string media_id)
        {
            if (!is_logged)
                return false;

            
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


        public async Task<bool> follow(string username)
        {
            if (!is_logged)
                return false;

            IResult<InstaUserInfo> utente = await api.UserProcessor.GetUserInfoByUsernameAsync(username);


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

        public async Task<IResult<InstaMediaList>> lasts_media_id(string username)
        {
            return await api.UserProcessor.GetUserMediaAsync(username, PaginationParameters.MaxPagesToLoad(1));
        }

        public async Task<IResult<InstaUser>> get_user(string username)
        {
            return await api.UserProcessor.GetUserAsync(username);
        }

        public async Task<IResult<InstaUserInfo>> get_user_info(string username)
        {
            return await api.UserProcessor.GetUserInfoByUsernameAsync(username);
        }

        public async Task<IResult<InstaUserShortList>> get_user_followers(string username)
        {
            return await api.UserProcessor.GetUserFollowersAsync(username, PaginationParameters.Empty);
        }

        public async Task<HashSet<string>> get_user_from_hastag(string hastag)
        {
            HashSet<string> output = new HashSet<string>();
            IResult<InstaSectionMedia> request = await api.HashtagProcessor.GetRecentHashtagMediaListAsync(hastag, PaginationParameters.Empty);
            if (request.Value != null)
            {
                List<InstaMedia> list_media = request.Value.Medias;
                for(int i=0; i<list_media.Count; i++)
                {
                    if(!(output.Contains(list_media[i].User.UserName)))
                        output.Add(list_media[i].User.UserName);
                }
            }
            return output;
        }

        public async Task<HashSet<string>> get_user_from_location(string location)
        {
            HashSet<string> output = new HashSet<string>();

            IResult<InstaPlaceShort> x = await api.LocationProcessor.GetLocationInfoAsync(location);
            if (x == null)
            {
                return null;
            }
            IResult<InstaSectionMedia> request = await api.LocationProcessor.GetRecentLocationFeedsAsync(x.Value.Pk, PaginationParameters.Empty);
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

        public async Task<HashSet<string>> get_following()
        {
            HashSet<string> following = new HashSet<string>();

            IResult<InstaUserShortList> x = await api.UserProcessor.GetCurrentUserFollowersAsync(PaginationParameters.Empty);

            for (int i = 0; i < x.Value.Count; i++)
            {
                following.Add(x.Value[i].UserName);
            }

            return following;
        }

    }
}
