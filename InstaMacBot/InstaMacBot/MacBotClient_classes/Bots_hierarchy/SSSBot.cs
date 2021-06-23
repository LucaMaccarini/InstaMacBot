using System.Threading.Tasks;

namespace InstaMacBot.classes
{
    /// <summary>
    /// this abstract class define a status bot -> a StartStopBot with status field, so is possible check if is running
    /// </summary>
    public abstract class SSSBot : StartStopBot
    {
        /// <summary>
        /// status of the bot:
        /// <para>if true the bot is running</para>
        /// <para>if false the bot is not running</para>
        /// </summary>
        protected bool status;
        /// <summary>
        /// the console where the bot will log its process
        /// </summary>
        protected BotConsole console;

        /// <summary>
        /// check if bot is running
        /// </summary>
        /// <returns>
        /// <para>if true the bot is running</para>
        /// <para>if false the bot is not running</para>
        /// </returns>
        public bool is_running { get { return status; } }


        /// <param name="console">the console where the bot will log its process</param>
        public SSSBot(BotConsole console = null)
        {
            status = false;
            if (console != null)
                this.console = console;
        }

        /// <summary>
        /// start the bot
        /// </summary>
        public abstract void start();

        /// <summary>
        /// stop the bot
        /// </summary>
        /// <param name="save_infos">
        /// <para>if true when bot stops it saves it's infos on files</para>
        /// <para>else nothing: just stop</para>
        /// </param>
        public abstract void stop(bool save_infos);

    }
}
