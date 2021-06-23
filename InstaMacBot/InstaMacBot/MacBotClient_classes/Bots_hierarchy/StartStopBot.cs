namespace InstaMacBot.classes
{
    /// <summary>
    /// this interface define a start stop bot -> a bot that is possible start or stop itself
    /// </summary>
    public interface StartStopBot
    {
        /// <summary>
        /// start the bot
        /// </summary>
        void start();

        /// <summary>
        /// stop the bot
        /// </summary>
        /// <param name="save_infos">
        /// <para>if true when bot stops it saves it's infos on files</para>
        /// <para>else nothing: just stop</para>
        /// </param>
        void stop(bool save_infos);
    }
}
