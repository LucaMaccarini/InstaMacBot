using InstaMacBot.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMacBot.MacBotClient_classes
{
    class CommentsBarrageBot : SSSBot
    {
        private int comments;
        private int comments_limit;
        private string target_post;
        private string text_comment;

        /// <summary>
        /// the user that bot is using the account to do all actions
        /// </summary>
        private UserApi UtenteApi;
        /// <summary>
        /// delay in seconds between each account in processing_accounts_list
        /// </summary>
        private int delay;
        /// <summary>
        /// a procedure (void function) called when finish or stopped (used to control element inside the form)
        /// </summary>
        private Action actions_bot_finshed;
        /// <summary>
        /// path where bot will save all files about this userApi: ./Accounts/username
        /// </summary>
        private string path_bot_save_info;

        public CommentsBarrageBot(UserApi Utente, string path_bot_save_info, BotConsole tx_console = null, string text_comment="", int comments_limit=5, string target_post="", int delay = 1, Action actions = null) : base(tx_console)
        {
            if (Utente == null) throw new ArgumentNullException("utente must be != null");
            if (delay < 0) throw new ArgumentOutOfRangeException("delay must be >=0");

            comments = 0;
            UtenteApi = Utente;
            actions_bot_finshed = actions;
            this.path_bot_save_info = path_bot_save_info;
            this.target_post = target_post;
            this.comments_limit = comments_limit;
            this.text_comment = text_comment;
        }

        public void set_comments_limit(int n)
        {
            if (comments_limit >= 0)
                comments_limit = n;
        }

        public void set_target_post(string target_post)
        {
            if (target_post != null)
                this.target_post = target_post;
        }

        public void set_text_comment(string comment_content)
        {
            if (comment_content != null)
                this.text_comment = comment_content;
        }

        public void set_delay(int delay)
        {
            if (delay >= 0)
                this.delay = delay;
        }

        public override void start()
        {
            status = true;
            bot_procedure();
        }

        public override void stop(bool save_infos)
        {
            status = false;
            console.write_on_console("bot ended");
            actions_bot_finshed();
        }

        private async void bot_procedure()
        {
            if (target_post == "")
            {
                console.write_on_console("set the target post in options tab");
                stop(true);
                return;
            }

            if (text_comment == "")
            {
                console.write_on_console("set the comment text in options tab");
                stop(true);
                return;
            }

            comments = 0;
            int fails = 0;
            string post_id = await UtenteApi.get_media_id_from_url(target_post);

            if (post_id == null)
            {
                console.write_on_console("media not found");
                stop(true);
                return;
            }

            while ((comments < comments_limit || comments_limit==0) && status)
            {
                bool result = await UtenteApi.comment_post(post_id, text_comment);
                if (result)
                {
                    if (fails != 0)
                        fails = 0;

                    comments++;
                    console.write_on_console("comment has been written [tot comment: " + comments + "]");

                }
                else
                {
                    fails++;
                    console.write_on_console("comment not done [tot fails: " + fails + "]");
                    if (fails == 3)
                    {
                        console.write_on_console("secure stop (instagram feedback required or post removed)");
                        stop(true);
                        return;
                    }
                }
                await wait(delay);
            }

            if(status)
                stop(true);
        }

        /// <summary>
        /// sleeps the cpu for some seconds
        /// </summary>
        /// <param name="seconds">number of seconds of sleep</param>
        /// <returns>true when delay finishes</returns>
        private async Task<bool> wait(int seconds)
        {
            int i = 0;
            while (i < seconds * 2 && status)
            {
                await Task.Delay(500);
                i++;
            }
            return true;
        }
    }
}
