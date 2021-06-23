namespace InstaMacBot.classes
{
    /// <summary>
    /// this interface rappresents a console where is possible write in
    /// </summary>
    public interface BotConsole
    {
        /// <summary>
        /// write a string on the console
        /// </summary>
        /// <param name="output" >a string that will be write on the console</param>
        void write_on_console(string output);
    }
}
