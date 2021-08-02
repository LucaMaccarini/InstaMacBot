using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace InstaMacBot.classes
{
    /// <summary>
    /// <para>the object of this class rapresents a list of bot_file_entry_list 
    /// used to store all bot files of the user that is using the bot client and display the list inside a lisatbox</para>
    /// <para>objects of this class are mutable</para>
    /// </summary>
    public class bot_file_list
    {

        /// <summary>
        /// the bot_file_entry_list list used to store all bot files of the user
        /// </summary>
        private BindingList<bot_file_entry_list> files_list;
        /// <summary>
        /// path of directory thet contains all files of the user tipically ./Accounts/instagram_username
        /// </summary>
        private string path;


        /// <summary>
        /// extension of files to be added to the list (files_list) in the specified directory (path)
        /// </summary>
        private string type_of_file;


        /// <summary>
        /// <para>if path_account directory doesent exist will be created</para>
        /// <para>else populate the files_list with all files inside path</para>
        /// </summary>
        /// <param name="path_account"><para>path of directory thet contains all files of the user logged in the bot (userapi) tipically</para>
        /// <para>./Accounts/instagram_username</para></param>
        public bot_file_list(string path_account, string type_of_file)
        {
            files_list = new BindingList<bot_file_entry_list>();
            this.type_of_file = type_of_file;
            path = path_account;

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            else
            {
                refresh_files_list();
            }
        }

        /// <summary>
        /// set a list box with this obgect list (files_list)
        /// </summary>
        /// <param name="x">the listbox that will set this object list files_list</param>
        public void set_listbox(ListBox x)
        {
            x.DataSource = files_list;
        }
       
        /// <returns>the path of user directory where are stored all bots files of the user</returns>
        public string get_path()
        {
            return path;
        }

        /// <summary>
        /// check all files inside path and refresh files_list adding new files and removing missing onces
        /// </summary>
        public void refresh_files_list()
        {
            if (files_list.Count > 0)
                files_list.Clear();

            DirectoryInfo d = new DirectoryInfo(path);

            FileInfo[] Files = d.GetFiles("*." + type_of_file);
            foreach (FileInfo file in Files)
            {
                this.files_list.Add(new bot_file_entry_list(file.ToString(), path));
            }
        }
    }
}
