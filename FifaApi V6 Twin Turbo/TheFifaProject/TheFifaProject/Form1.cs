using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace TheFifaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            teamOneScoreUpDown.Enabled = false;
            teamTwoScoreUpDown.Enabled = false;
            LoadBetType();
            ReloadMatches();
            try
            {
                using (StreamReader userReader = new StreamReader(@"..\Savedata.json"))
                {
                    var json = userReader.ReadToEnd();
                    Program.gamblers = JsonConvert.DeserializeObject<List<Gamblers>>(json);
                }
            }
            catch
            {
                File.Create(@"..\Savedata.json");
            }
            try
            {
                using (StreamReader matchReader = new StreamReader(@"..\Matchdata.json"))
                {
                    var json = matchReader.ReadToEnd();
                    Program.bets = JsonConvert.DeserializeObject<List<Bets>>(json);
                }
            }
            catch
            {
                File.Create(@"..\Matchdata.json");
            }

        }

        private void addGamblerButton_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            form.ShowDialog();
        }

        public void LoadBetType()
        {
            string[] betType = new string[2];
            betType[0] = "Double or nothing";
            betType[1] = "Triple or nothing";

                payoutComboBox.Items.Add(betType[0]);
                payoutComboBox.Items.Add(betType[1]);
        }

        public void ReloadTeams()
        {
            overviewListBox.Items.Clear();
            // Bron: https://stackoverflow.com/a/4758334
            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson;

            dataJson = downloader.DownloadString("http://localhost/the_fifa_project/Php-code/api/index.php?apikey=$2VAo@5JGt8%");


            TeamData[] teamDatas = JsonConvert.DeserializeObject<TeamData[]>(dataJson);

            foreach (var Team in teamDatas)
            {
                overviewListBox.Items.Add(Team.name);
            }
        }

        public void ReloadMatches()
        {
                overviewListBox.Items.Clear();
                System.Net.WebClient downloader = new System.Net.WebClient();
                string dataJson;

                dataJson = downloader.DownloadString("http://localhost/the_fifa_project/Php-code/api/index.php?apikey=Rz7^8p2%4VYk");

            MatchData[] matchDatas = JsonConvert.DeserializeObject<MatchData[]>(dataJson,
            new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

                foreach (var Match in matchDatas)
                {
                    MatchData newMatchData = new MatchData();
                    newMatchData.id = Match.id;
                    newMatchData.team1_name = Match.team1_name;
                    newMatchData.team2_name = Match.team2_name;
                    newMatchData.team1_score = Match.team1_score;
                    newMatchData.team2_score = Match.team2_score;
                    newMatchData.team1_id = Match.team1_id;
                    newMatchData.team2_id = Match.team2_id;
                    newMatchData.time = Match.time;
                    newMatchData.field = Match.field;

                    Program.matchDatas.Add(newMatchData);
                    overviewListBox.Items.Add(Match.team1_name + " VS " + Match.team2_name + " field: " + Match.field + " time: " + Match.time);
            }
        }


        private void selectGamblerComboBox_Click(object sender, EventArgs e)
        {
            try
            {
                selectGamblerComboBox.Items.Clear();
                foreach (var gambler in Program.gamblers)
                {
                    selectGamblerComboBox.Items.Add(gambler.Name);
                }
            }
            catch
            {
                return;
            }
        }

        private void showGamesButton_Click(object sender, EventArgs e)
        {
            ReloadMatches();
        }

        private void showTeamsButton_Click(object sender, EventArgs e)
        {
            ReloadTeams();
        }

        private void reloadCurrency()
        {
            foreach (var gambler in Program.gamblers)
            {
                for (int i = 0; i < Program.gamblers.Count; i++)
                {
                    if (selectGamblerComboBox.Text == Program.gamblers[i].Name)
                    {
                        gamblerCurrencyLabel.Text = Program.gamblers[i].Currency.ToString();
                        return;
                    }
                }
            }
        }
        private void reloadBetHistory()
        {
            betHistoryListBox.Items.Clear();
            foreach (var bet in Program.bets)
            {
                    if (selectGamblerComboBox.Text == bet.gamblerName)
                    {
                        betHistoryListBox.Items.Add("€ " + bet.betAmount + " op " + bet.winningTeamName);
                    }

            }
        }

        private void selectGamblerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gamblerNameLabel.Text = selectGamblerComboBox.Text;
            reloadCurrency();
            reloadBetHistory();
        }

        private void overviewListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gamblerTeamComboBox.Items.Clear();
                int selectedMatch = overviewListBox.SelectedIndex;
                System.Net.WebClient downloader = new System.Net.WebClient();
                string dataJson;

                dataJson = downloader.DownloadString("http://localhost/the_fifa_project/Php-code/api/index.php?apikey=Rz7^8p2%4VYk");

                MatchData[] matchDatas = JsonConvert.DeserializeObject<MatchData[]>(dataJson,
                                new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });

                foreach (var Match in matchDatas)
                {
                    if (selectedMatch == Match.id - 1)
                    {
                        gamblerTeamComboBox.Items.Add(Match.team1_name);
                        gamblerTeamComboBox.Items.Add(Match.team2_name);
                        return;
                    }
                }
            }
            catch
            {
                throw;
            }
        }



        private void gamblerConfirmWagerButton_Click(object sender, EventArgs e)
        {
            int wager = Convert.ToInt32(Math.Round(gamblerWagerUpDown.Value, 0));
            int teamOneScore = Convert.ToInt32(Math.Round(teamOneScoreUpDown.Value, 0));
            int teamTwoScore = Convert.ToInt32(Math.Round(teamTwoScoreUpDown.Value, 0));
            foreach (var gambler in Program.gamblers)
            {
                if (gambler.Name == selectGamblerComboBox.Text)
                {
                    gambler.Currency -= wager;
                    MessageBox.Show(gambler.Name + " heeft " + wager + " op team " + gamblerTeamComboBox.Text + " gewed!");

                    Bets newBet = new Bets();
                    newBet.matchID = Program.matchDatas[0].id;
                    newBet.type = payoutComboBox.SelectedItem.ToString();
                    newBet.gamblerID = gambler.ID;
                    newBet.betAmount = wager;
                    newBet.winningteam = gamblerTeamComboBox.SelectedIndex;
                    newBet.winningTeamName = gamblerTeamComboBox.Text;
                    newBet.gamblerName = selectGamblerComboBox.Text;
                    if (payoutComboBox.Text == "Triple or nothing")
                    {
                        newBet.scoreTeamOne = teamOneScore;
                        newBet.scoreTeamTwo = teamTwoScore;
                    }

                    Program.bets.Add(newBet);
                }
            }
            reloadCurrency();
            reloadBetHistory();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!File.Exists(@"..\MatchData.json"))
            {
                File.Create(@"..\Matchdata.json");
            }
            var matchJsonToOutput = JsonConvert.SerializeObject(Program.bets, Formatting.Indented);

            string matchJson = JsonConvert.SerializeObject(matchJsonToOutput.ToArray());
            File.WriteAllText(@"..\Matchdata.json", matchJsonToOutput);
            if (!File.Exists(@"..\Savedata.json"))
            {
                File.Create(@"..\Savedata.json");
            }
            var userJsonToOutput = JsonConvert.SerializeObject(Program.gamblers, Formatting.Indented);

            string userJson = JsonConvert.SerializeObject(userJsonToOutput.ToArray());
            //write string to file
            File.WriteAllText(@"..\Savedata.json", userJsonToOutput);
        }

        private void payoutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (payoutComboBox.SelectedIndex == 1)
            {
                teamOneScoreUpDown.Enabled = true;
                teamTwoScoreUpDown.Enabled = true;
            }
            else
            {
                teamOneScoreUpDown.Enabled = false;
                teamTwoScoreUpDown.Enabled = false;
            }
        }

        private void payoutButton_Click(object sender, EventArgs e)
        {
            foreach (var match in Program.matchDatas)
            {
                for (int i = 0; i < Program.bets.Count; i++)
                {
                    if (Program.bets[i].gamblerName == selectGamblerComboBox.Text)
                    {
                        if (Program.bets[i].type == "Double or nothing")
                        {
                            if (Program.matchDatas[i].team1_score > Program.matchDatas[i].team2_score && Program.bets[i].winningTeamName == Program.matchDatas[i].team1_name)
                            {
                                Program.gamblers[i].Currency += Program.bets[i].betAmount * 2;
                                MessageBox.Show("Team " + Program.bets[i].winningTeamName + " heeft gewonnen!");
                                Program.bets.RemoveAt(i);
                                reloadBetHistory();
                            }
                            else if (Program.matchDatas[i].team1_score < Program.matchDatas[i].team2_score && Program.bets[i].winningTeamName == Program.matchDatas[i].team1_name)
                            {
                                Program.gamblers[i].Currency += Program.bets[i].betAmount * 2;
                                MessageBox.Show("Team " + Program.bets[i].winningTeamName + " heeft gewonnen!");
                                Program.bets.RemoveAt(i);
                                reloadBetHistory();
                            }
                        }
                        else if (Program.bets[i].type == "Triple or nothing")
                        {
                            if (Program.bets[i].scoreTeamOne == Program.matchDatas[i].team1_score && Program.bets[i].scoreTeamTwo == Program.matchDatas[i].team2_score || Program.gamblers[i].Name == selectGamblerComboBox.Text)
                            {
                                Program.gamblers[i].Currency += Program.bets[i].betAmount * 3;
                                MessageBox.Show("Team " + Program.bets[i].winningTeamName + " heeft gewonnen!");
                                Program.bets.RemoveAt(i);
                                reloadBetHistory();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Jammer, " + Program.bets[i].winningTeamName + " heeft verloren...");
                            Program.bets.RemoveAt(i);
                        }
                    }

                }
            }
            reloadCurrency();
        }
    }
}
