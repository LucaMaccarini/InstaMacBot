using System;
using System.Windows.Forms;

namespace InstaMacBot.classes
{
    /// <summary>
    /// <para>this class rappresents a console for desktop client that wraps a textbox</para>
    /// <para>objects of this class are mutable</para>
    /// </summary>
    public class DesktopTextBoxConsole : BotConsole
    {
        /// <summary>
        /// the textbox console where write logs
        /// </summary>
        TextBox out_console;


        /// <param name="out_c">form textbox used to write all logs of this</param>
        public DesktopTextBoxConsole(TextBox out_c)
        {
            out_console = out_c;
        }


        /// <summary>
        /// write a string on the console
        /// </summary>
        /// <param name="output" >a string that will be write on the console</param>
        public void write_on_console(string output)
        {

            string s = out_console.Text;
            out_console.Text = output;
            out_console.Text += Environment.NewLine;
            out_console.Text += s;


        }
    }
}
