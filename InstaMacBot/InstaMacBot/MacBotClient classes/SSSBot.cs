using InstaMacBot.MacBotClient_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaMacBot.classi_MacBotClient
{
    abstract class SSSBot : StartStopBot
    {
        //OVERVIEW: this abstract class define a status bot -> a StartStopBot with status is_running

        protected bool status;
        protected BotConsole tx_console;

        public bool is_running { get { return status; } }


        private async Task<bool> wait(int seconds)
        {
            int i = 0;
            while (i < seconds)
            {
                await Task.Delay(1000);
                i++;
            }
            return true;
        }

        public SSSBot(BotConsole console = null)
        {
            status = false;
            if (console != null)
                tx_console = console;
        }


        public abstract void start();
        public abstract void stop(bool save_infos);
        
    }
}
