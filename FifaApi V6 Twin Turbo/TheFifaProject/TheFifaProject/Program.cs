using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFifaProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static List<Gamblers> gamblers = new List<Gamblers>();
        public static List<Bets> bets = new List<Bets>();
        public static List<MatchData> matchDatas = new List<MatchData>();
       
    }
}
