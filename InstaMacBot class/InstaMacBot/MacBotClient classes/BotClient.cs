using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaMacBot.classi_MacBotClient
{
    class BotClient
    {
        //OVERVIEW: the objects of this class are bot client with some <name,SSSbot> connected
        //          just to have an organizzation of all bots grouped in a client and with an unic name for bot
        public Dictionary<string, SSSBot> bots;
        
        public BotClient()
        {
            bots = new Dictionary<string, SSSBot>();
        }

        
    }
}
