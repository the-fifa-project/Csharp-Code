using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFifaProject
{
    class Bets
    {
        public int betAmount { get; set; }
        public int matchID { get; set; }
        public int winningteam { get; set; }
        public int scoreTeamOne { get; set; }
        public int scoreTeamTwo { get; set; }
        public string type { get; set; }
        public int gamblerID { get; set; }
        public string winningTeamName { get; set; }
        public string gamblerName { get; set; }

        //source: https://stackoverflow.com/questions/9262221/c-sharp-class-auto-increment-id

        private static List<bool> UsedCounter = new List<bool>();
        private static object Lock = new object();

        public int ID { get; private set; }

        public Bets()
        {

            lock (Lock)
            {
                int nextIndex = GetAvailableIndex();
                if (nextIndex == -1)
                {
                    nextIndex = UsedCounter.Count;
                    UsedCounter.Add(true);
                }

                ID = nextIndex;
            }
        }

        public void Dispose()
        {
            lock (Lock)
            {
                UsedCounter[ID] = false;
            }
        }


        private int GetAvailableIndex()
        {
            for (int i = 1; i < UsedCounter.Count; i++)
            {
                if (UsedCounter[i] == false)
                {
                    return i;
                }
            }

            // Nothing available.
            return -1;
        }
    }
}
