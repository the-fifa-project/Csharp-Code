using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFifaProject
{
    class MatchData
    {
        public int id { get; set; }
        public int team1_id { get; set; }
        public int team2_id { get; set; }
        public string team1_name { get; set; }
        public string team2_name { get; set; }
        public int team1_score { get; set; }
        public int team2_score { get; set; }
        public string time { get; set; }
        public int field { get; set; }
    }
}
