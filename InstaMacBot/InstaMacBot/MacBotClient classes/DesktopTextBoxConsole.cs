using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMacBot.MacBotClient_classes
{
    class DesktopTextBoxConsole : BotConsole
    {
        //OVERVIEW: this class rappresents a console for desktop client that wrap a textbox

        TextBox out_console;

        public DesktopTextBoxConsole(TextBox out_c)
        {
            out_console = out_c;
        }

        public void write_on_console(string output)
        {
           
            string s = out_console.Text;
            out_console.Text = output;
            out_console.Text += Environment.NewLine;
            out_console.Text += s;

          
        }
    }
}
