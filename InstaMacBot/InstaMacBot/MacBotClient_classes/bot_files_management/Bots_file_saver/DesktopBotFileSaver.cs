using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMacBot.InstaMacBot
{
    class DesktopBotFileSaver : BotFileSaver
    {
        private string path_nameFile_extension;
        private bool override_file_flag;

        public DesktopBotFileSaver(string _path_nameFile_extension, bool _override_file_flag)
        {
            path_nameFile_extension = _path_nameFile_extension;
            override_file_flag = _override_file_flag;
        }

        public bool can_override()
        {
            return override_file_flag;
        }

        public void write_list_on_file(List<string> list_text)
        {
            

            if (override_file_flag)
            {
                using (StreamWriter scrivi = new StreamWriter(path_nameFile_extension))
                {
                    if (list_text.Count > 0)
                    {
                        for (int i = 0; i < list_text.Count(); i++)
                        {
                            scrivi.WriteLine(list_text[i]);
                        }
                    }
                    else
                    {
                        scrivi.Write("");
                    }
                }
            }
            else
            {
                using (StreamWriter scrivi =  File.AppendText(path_nameFile_extension))
                {
                    if (list_text.Count > 0)
                    {
                        for (int i = 0; i < list_text.Count(); i++)
                        {
                            scrivi.WriteLine(list_text[i]);
                        }
                    }
                    else
                    {
                        scrivi.Write("");
                    }
                }
            }
        }

        public void write_on_file(string row_text)
        {
            if (override_file_flag)
            {
                using (StreamWriter scrivi = new StreamWriter(path_nameFile_extension))
                {
                    scrivi.WriteLine(row_text);
                }
            }
            else
            {
                using (StreamWriter scrivi = File.AppendText(path_nameFile_extension))
                {
                    scrivi.WriteLine(row_text);
                }

            }
        }


    }
}
