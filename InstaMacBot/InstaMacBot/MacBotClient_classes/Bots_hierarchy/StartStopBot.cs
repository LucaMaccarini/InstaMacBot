using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMacBot.InstaMacBot
{
    interface StartStopBot
    {
        //OVERVIEW: this interface define a start stop bot -> a bot that is possible start or stop
        void start();
        void stop(bool save_infos);
    }
}
