using System.IO;

namespace InstaMacBot.classes
{
    /// <summary>
    /// <para>the object of this class rapresents a file created from once of the StartStopBot</para>
    /// <para>objects of this class are immutable</para>
    /// </summary>
    public class bot_file_entry_list
    {
        /// <summary>
        /// name.extension of the file
        /// </summary>
        private string name;

        /// <summary>
        /// path of the directory of the user where are saved all bots files of the user logged in the bot (userapi)
        /// </summary>
        private string account_directory;


        /// <param name="name">name.extension of the file</param>
        /// <param name="account_directory">path of the directory of the user logged in the bot (userapi) where are saved all bots files of the user</param>
        public bot_file_entry_list(string name, string account_directory)
        {
            this.name = name;
            this.account_directory = account_directory;
        }

        /// <summary>
        /// get the name of the file
        /// </summary>
        /// <returns>a string that contains the name of the file</returns>
        public string get_name()
        {
            return name;
        }

        /// <summary>
        /// get the name of the file
        /// </summary>
        /// <returns>a string that contains the name of the file</returns>
        public string get_path()
        {
            return account_directory + "/" + name;
        }

        /// <summary>
        /// <para>override the ToString because this is tipically used inside a list of bot_file_entry_list (inside bot_file_list class) and the list is attached as datasource of a listbox</para>
        /// <para>so inside the listbox will display the name of the files without extension</para>
        /// </summary>
        /// <returns>a string that contains only the name of the file without extension</returns>
        public override string ToString()
        {
            return name.Split('.')[0];
        }

        /// <summary>
        /// delete the file at get_path() (the file refered to this)
        /// </summary>
        public void remove()
        {
            if (File.Exists(get_path()))
                File.Delete(get_path());
        }

    }
}
