using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMacBot.InstaMacBot
{
    class bot_file_list
    {
        public BindingList<bot_file_entry_list> files_list;
        string path;

        public bot_file_list(string path_account)
        {
            files_list = new BindingList<bot_file_entry_list>();
            path = path_account;

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            else
            {
                refresh_files_list();
            }
        }

        public string get_path()
        {
            return path;
        }

        public void refresh_files_list()
        {
            if (files_list.Count > 0)
                files_list.Clear();

            DirectoryInfo d = new DirectoryInfo(path);

            FileInfo[] Files = d.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                this.files_list.Add(new bot_file_entry_list(file.ToString(), path));
            }
        }
    }
}
