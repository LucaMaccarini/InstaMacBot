using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMacBot.InstaMacBot
{
    interface BotFileSaver
    {
        void write_on_file(string row_text);
        void write_list_on_file(List<string> list_text);
    }
}
