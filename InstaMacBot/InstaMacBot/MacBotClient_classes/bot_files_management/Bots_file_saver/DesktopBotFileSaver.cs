using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InstaMacBot.classes
{
    /// <summary>
    /// <para>this class rappresents an entity that can override, append or create a file with some text saved in</para>
    /// <para>objects of this class are immutable</para>
    /// </summary>
    public class DesktopBotFileSaver : BotFileSaver
    {
        /// <summary>
        /// the path of the file that this will operate
        /// </summary>
        private string path_nameFile_extension;

        /// <summary>
        /// override flag:
        /// <para>if true the file at path_nameFile_extension will be overrided with some text</para>
        /// <para>else file at path_nameFile_extension will be appended some text</para>
        /// <para>(when write metods are call)</para>
        /// </summary>
        private bool override_file_flag;

        /// <param name="_path_nameFile_extension">the path of the file that this will operate</param>
        /// <param name="_override_file_flag">
        /// <para>if true the file at path_nameFile_extension will be overrided with some text</para>
        /// <para>else file at path_nameFile_extension will be appended some text</para>
        /// <para>(when write_list_on_file or write_on_file metods are call)</para>
        /// </param>
        public DesktopBotFileSaver(string _path_nameFile_extension, bool _override_file_flag)
        {
            path_nameFile_extension = _path_nameFile_extension;
            override_file_flag = _override_file_flag;
        }

        /// <summary>
        /// check if this override the file at path_nameFile_extension (if write metods are call)
        /// </summary>
        public bool can_override()
        {
            return override_file_flag;
        }

        /// <summary>
        /// write the list_text inside the file at path_nameFile_extension, it writes one item for each line 
        /// <para>if file don't exist it will be created</para>
        /// <para>if override_file_flag is true the file will be overrided</para>
        /// <para>else the text will be appended</para>
        /// </summary>
        /// <param name="list_text">list that will write inside the file at path_nameFile_extension</param>
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
                using (StreamWriter scrivi = File.AppendText(path_nameFile_extension))
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

        /// <summary>
        /// write the row_text inside the file at path_nameFile_extension
        /// 
        /// if file don't exist it will be created
        /// 
        /// if override_file_flag is true the file will be overrided
        /// 
        /// else the text will be appended
        /// </summary>
        /// <param name="row_text">line of text that will be write inside the file at path_nameFile_extension</param>
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
