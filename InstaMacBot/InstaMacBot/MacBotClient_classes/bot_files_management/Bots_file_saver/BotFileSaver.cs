using System.Collections.Generic;

namespace InstaMacBot.classes
{
    /// <summary>
    /// this interface rapresents an entity able to save a list of strings or only a string row in a file
    /// </summary>
    public interface BotFileSaver
    {
        /// <summary>
        /// save a row of text in a file
        /// </summary>
        /// <param name="row_text">string that will saved in the file</param>
        void write_on_file(string row_text);
        /// <summary>
        /// save a list of strings in a file
        /// </summary>
        /// <param name="list_text">list of strings that will saved in the file (one item fo each line)</param>
        void write_list_on_file(List<string> list_text);
    }
}
