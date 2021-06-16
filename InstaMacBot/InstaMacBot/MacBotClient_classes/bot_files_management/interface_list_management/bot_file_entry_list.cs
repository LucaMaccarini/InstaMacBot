using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMacBot.InstaMacBot
{
    class bot_file_entry_list
    {
        private string name;
        private string fullpath;

        public bot_file_entry_list(string name, string fullpath)
        {
            this.name = name;
            this.fullpath = fullpath;
        }

        public string get_name()
        {
            return name;
        }

        public string get_path()
        {
            return fullpath + "/" + name;
        }
        public override string ToString()
        {
            return name.Split('.')[0];
        }

        public void remove()
        {
            if(File.Exists(get_path()))
                File.Delete(get_path());
        }

    }
}
