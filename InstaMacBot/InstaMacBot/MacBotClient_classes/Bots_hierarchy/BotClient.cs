using System.Collections.Generic;

namespace InstaMacBot.classes
{
    /// <summary>
    /// the objects of this class are bots manager they contains a map with [name,SSSbot]
    ///  are used just to have an organizzation of all bots grouped in a client and with an unique name for bot
    /// </summary>
    public class BotClient
    {

        /// <summary>
        /// a map that contains name1:sssbot1, name2:sssbot2,...
        /// </summary>
        public Dictionary<string, SSSBot> bots;

        
        public BotClient()
        {
            bots = new Dictionary<string, SSSBot>();
        }


    }
}
