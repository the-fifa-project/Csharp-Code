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
            //zet de numericUpDowns uit, dit is standaard als je inlaad. Als je vervolgens een triple or nothing doet gaan ze aan staan
            teamOneScoreUpDown.Enabled = false;
            teamTwoScoreUpDown.Enabled = false;
            //laad de combobox "BetType" in, in deze comboBox kan je selecteren of je een double or nothing of een triple or nothing wilt
            LoadBetType();
            //laad al de matches, dit laat hij standaard zien wanneer de applicatie geladen word.
            ReloadMatches();

            try
            {
                //haalt al de bestanden uit de Json files en zet ze in lists die in de program.cs staan
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
                //als er nog geen bestanden zijn maakt hij ze aan
                File.Create(@"..\Matchdata.json");
                File.Create(@"..\Savedata.json");
            }

        }

        private void addGamblerButton_Click(object sender, EventArgs e)
        {
            //opent de form waar je een gokker kan toeveoegen.
            AddUser form = new AddUser();
            form.ShowDialog();
        }

        public void LoadBetType()
        {
            //zie load event
            string[] betType = new string[2];
            betType[0] = "Double or nothing";
            betType[1] = "Triple or nothing";

            payoutComboBox.Items.Add(betType[0]);
            payoutComboBox.Items.Add(betType[1]);
        }

        public void ReloadTeams()
        {
            //herlaad al de teams die je in de API binnen krijgt
            overviewListBox.Items.Clear();
            // Bron: https://stackoverflow.com/a/4758334
            //haalt de API op
            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson;

            dataJson = downloader.DownloadString("http://glennmeering.nl/school/fifa/api/index.php?apikey=$2VAo@5JGt8%");

            //deserialized de Json naar een C# object
            TeamData[] teamDatas = JsonConvert.DeserializeObject<TeamData[]>(dataJson);

            foreach (var Team in teamDatas)
            {
                //add de team namen in de overviewListBox.
                overviewListBox.Items.Add(Team.name);
            }
        }

        public void ReloadMatches()
        {
            //herlaad al de matches die we met de API binnen krijgen
            overviewListBox.Items.Clear();
            //haalt de API op
            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson;

            dataJson = downloader.DownloadString("http://glennmeering.nl/school/fifa/api/index.php?apikey=Rz7^8p2%4VYk");

            //deserialized de Json naar een C# object
            MatchData[] matchDatas = JsonConvert.DeserializeObject<MatchData[]>(dataJson,
            new JsonSerializerSettings
            {
                //als je een null binnen krijgt ignored hij de error
                //(dit gebruiken we omdat de scores automatisch Null zijn als het team nog niet gespeelt heeft)
                NullValueHandling = NullValueHandling.Ignore
            });

            foreach (var Match in matchDatas)
            {
                //zet alle data in een class
                MatchData newMatchData = new MatchData();
                //al deze data halen we binnen met de API en zetten we in een class
                newMatchData.id = Match.id;
                newMatchData.team1_name = Match.team1_name;
                newMatchData.team2_name = Match.team2_name;
                newMatchData.team1_score = Match.team1_score;
                newMatchData.team2_score = Match.team2_score;
                newMatchData.team1_id = Match.team1_id;
                newMatchData.team2_id = Match.team2_id;
                newMatchData.time = Match.time;
                newMatchData.field = Match.field;

                //zet de class in een list
                Program.matchDatas.Add(newMatchData);
                //zet de match in de overviewListBox
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
                    //add elke gokker toe aan de combobox
                    selectGamblerComboBox.Items.Add(gambler.Name);
                }
            }
            catch
            {
                //als er nog geen gokkers zijn doet hij niks(er zou anders een error zijn)
                return;
            }
        }

        private void showGamesButton_Click(object sender, EventArgs e)
        {
            //herlaad de matches(zie methode)
            ReloadMatches();
        }

        private void showTeamsButton_Click(object sender, EventArgs e)
        {
            //herlaad de teams(zie methode)
            ReloadTeams();
        }

        private void reloadCurrency()
        {
            //gaat elke gokker langst
            foreach (var gambler in Program.gamblers)
            {
                //checkt of de naam van de gokker hetzelfde is in de naam van de array
                    if (selectGamblerComboBox.Text == gambler.Name)
                    {
                        //zet de currency van de goede gokker in een label
                        gamblerCurrencyLabel.Text = gambler.Currency.ToString();
                        return;
                    }
            }
        }
        private void reloadBetHistory()
        {
            betHistoryListBox.Items.Clear();
            //gaat elke weddenschap langst die er gemaakt is
            foreach (var bet in Program.bets)
            {
                //checkt of de naam van de gokker hetzelfde is als de naam van de gambler in de bet
                if (selectGamblerComboBox.Text == bet.gamblerName)
                {
                    //voegt de bet toe aan een listBox
                    betHistoryListBox.Items.Add("€ " + bet.betAmount + " op " + bet.winningTeamName);
                }

            }
        }

        private void selectGamblerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //zet de naam van de gokker in een label
            gamblerNameLabel.Text = selectGamblerComboBox.Text;
            //herlaad je geld(zie methode)
            reloadCurrency();
            //herlaad je weddenschap geschiedenis(zie methode)
            reloadBetHistory();
        }

        private void overviewListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gamblerTeamComboBox.Items.Clear();
                int selectedMatch = overviewListBox.SelectedIndex;
                //haalt de API op
                System.Net.WebClient downloader = new System.Net.WebClient();
                string dataJson;

                dataJson = downloader.DownloadString("http://glennmeering.nl/school/fifa/api/index.php?apikey=Rz7^8p2%4VYk");

                //deserialized de Json naar een C# object
                MatchData[] matchDatas = JsonConvert.DeserializeObject<MatchData[]>(dataJson,
                                new JsonSerializerSettings
                                {
                                    //als je een null binnen krijgt ignored hij de error
                                    //(dit gebruiken we omdat de scores automatisch Null zijn als het team nog niet gespeelt heeft)
                                    NullValueHandling = NullValueHandling.Ignore
                                });

                foreach (var Match in matchDatas)
                {
                    //checkt of de geselecteerde match hetzelfde is als het id van de matches -1(omdat selectedMatch op van 0 telt
                    //en Match.id van 1 telt)
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
            //zorgt dat wager het bedrag is wat ingezet word(een numericUpDown is standaard een double dus we converten het naar een int)
            int wager = Convert.ToInt32(Math.Round(gamblerWagerUpDown.Value, 0));
            //zet de scores in een int
            int teamOneScore = Convert.ToInt32(Math.Round(teamOneScoreUpDown.Value, 0));
            int teamTwoScore = Convert.ToInt32(Math.Round(teamTwoScoreUpDown.Value, 0));

            //gaat elke gokker langst
            foreach (var gambler in Program.gamblers)
            {
                //checkt of de naam hetzelfde is als de geselecteerde gokker
                if (gambler.Name == selectGamblerComboBox.Text)
                {
                    //haalt de inzet van het geld van de gokker eraf
                    gambler.Currency -= wager;
                    //laat zien hoeveel de gokker gewedt heeft en op welk team
                    MessageBox.Show(gambler.Name + " heeft " + wager + " op team " + gamblerTeamComboBox.Text + " gewed!");

                    //maakt een nieuwe bet aan
                    Bets newBet = new Bets();
                    //of het een double or nothing of een triple or nothing is
                    newBet.type = payoutComboBox.SelectedItem.ToString();
                    //de hoeveelheid dat de gokker gewedt heeft
                    newBet.betAmount = wager;
                    //het id van de gokker word in de bet gezet
                    newBet.gamblerID = gambler.ID;
                    //het id van de match word de geselecteerde match id
                    newBet.matchID = Program.matchDatas[overviewListBox.SelectedIndex].id;
                    //het id van het team waarop je gewedt hebt
                    newBet.winningteam = gamblerTeamComboBox.SelectedIndex;
                    //de naam van het team waarop je gewed hebt
                    newBet.winningTeamName = gamblerTeamComboBox.Text;
                    //de naam van de gokker
                    newBet.gamblerName = selectGamblerComboBox.Text;
                    //als het een triple or nothing is voegt hij dit toe ander negeerd hij dit
                    if (payoutComboBox.Text == "Triple or nothing")
                    {
                        //slaat de scores van de teams op
                        newBet.scoreTeamOne = teamOneScore;
                        newBet.scoreTeamTwo = teamTwoScore;
                    }

                    //zet de nieuwe weddeschap in de list
                    Program.bets.Add(newBet);
                }
            }
            //herlaad het geld(zie methode)
            reloadCurrency();
            //herlaad weddenschap geschiedenis(zie methode)
            reloadBetHistory();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //checkt of de file bestaat, zo niet dan maakt hij een file aan
            if (!File.Exists(@"..\MatchData.json"))
            {
                File.Create(@"..\Matchdata.json");
            }
            //serialized het C# object naar een Json
            var matchJsonToOutput = JsonConvert.SerializeObject(Program.bets, Formatting.Indented);

            string matchJson = JsonConvert.SerializeObject(matchJsonToOutput.ToArray());
            //schrijft de json naar het json bestand
            File.WriteAllText(@"..\Matchdata.json", matchJsonToOutput);

            //checkt of de file bestaad, zo niet maakt hij een file aan
            if (!File.Exists(@"..\Savedata.json"))
            {
                File.Create(@"..\Savedata.json");
            }

            //serialized het C# object naar een Json
            var userJsonToOutput = JsonConvert.SerializeObject(Program.gamblers, Formatting.Indented);

            string userJson = JsonConvert.SerializeObject(userJsonToOutput.ToArray());
            //schrijft de json naar het json bestand
            File.WriteAllText(@"..\Savedata.json", userJsonToOutput);
        }

        private void payoutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checkt of je een triple or nothing hebt of niet
            if (payoutComboBox.SelectedIndex == 1)
            {
                //zorgt dat de numericUpDown aan staat
                teamOneScoreUpDown.Enabled = true;
                teamTwoScoreUpDown.Enabled = true;
            }
            else
            {
                teamOneScoreUpDown.Enabled = false;
                teamTwoScoreUpDown.Enabled = false;
            }
        }

        public void payout()
        {
            int match = 0;
            int GamblerNumber = 0;
            //gaat elke bet langst
            foreach (var bet in Program.bets)
            {
                if (GamblerNumber <= Program.gamblers.Count)
                {
                    if (bet.gamblerID == Program.gamblers[GamblerNumber].ID)
                    {
                        //checkt of het een double or nothing of een triple or nothing is
                        if (bet.type == "Double or nothing")
                        {
                            for (int i = 0; i < Program.matchDatas.Count; i++)
                            {
                                //checkt of team 1 gewonnen heeft
                                if (Program.matchDatas[i].team1_score > Program.matchDatas[i].team2_score
                                    && bet.matchID == Program.matchDatas[i].id
                                    && Program.matchDatas[i].team1_name == bet.winningTeamName)
                                {
                                    foreach (var gambler in Program.gamblers)
                                    {
                                        //betaalt de goede gambler
                                        if (gambler.Name == selectGamblerComboBox.Text)
                                        {
                                            gambler.Currency += bet.betAmount * 2;
                                        }
                                    }
                                    MessageBox.Show("Team een heeft gewonnen, en je bet is goed");
                                }
                                //checkt of team 2 gewonnen heeft
                                if (Program.matchDatas[i].team1_score < Program.matchDatas[i].team2_score
                                    && bet.matchID == Program.matchDatas[i].id
                                    && Program.matchDatas[i].team2_name == bet.winningTeamName)
                                {
                                    foreach (var gambler in Program.gamblers)
                                    {
                                        if (gambler.Name == selectGamblerComboBox.Text)
                                        {
                                            gambler.Currency += bet.betAmount * 2;
                                        }
                                    }
                                    MessageBox.Show("Team twee heeft gewonnen, en je bet is goed");
                                }
                                //als je fout gewed hebt
                                else if (Program.matchDatas[i].team1_score < Program.matchDatas[i].team2_score
                                        && bet.matchID == Program.matchDatas[i].id
                                        && Program.matchDatas[i].team2_name != bet.winningTeamName
                                        ||
                                        (Program.matchDatas[i].team1_score > Program.matchDatas[i].team2_score
                                        && bet.matchID == Program.matchDatas[i].id
                                        && Program.matchDatas[i].team1_name != bet.winningTeamName))
                                {
                                    MessageBox.Show("Je bet is fout");
                                }
                                else if(Program.matchDatas[i].team1_score == Program.matchDatas[i].team2_score && bet.matchID == Program.matchDatas[i].id)
                                {
                                    MessageBox.Show("het is gelijkspel geworden");
                                }
                            }
                        }
                    }
                }
                //als het een triple or nothing is
                if (bet.type == "Triple or nothing")
                {
                    for (int i = 0; i < Program.matchDatas.Count; i++)
                    {
                        //als je de score goed gewed hebt
                        if (bet.scoreTeamOne == Program.matchDatas[i].team1_score 
                            && bet.scoreTeamTwo == Program.matchDatas[i].team2_score 
                            && bet.matchID == Program.matchDatas[i].id)
                        {
                            foreach (var gambler in Program.gamblers)
                            {
                                if (gambler.Name == selectGamblerComboBox.Text)
                                {
                                    gambler.Currency += bet.betAmount * 3;
                                }
                            }
                            MessageBox.Show("Je triple or nothing is goed");
                        }
                        //als je de score fout hebt gewed
                        else if (bet.scoreTeamOne != Program.matchDatas[i].team1_score
                            && bet.scoreTeamTwo != Program.matchDatas[i].team2_score
                            && bet.matchID == Program.matchDatas[i].id)
                        {
                            MessageBox.Show("Je triple or nothing is fout");
                        }
                    }
                }
            }
            for (int i = 0; i < Program.bets.Count; i++)
            {
                Program.bets.RemoveAt(i);
            }
            reloadBetHistory();
            reloadCurrency();
            GamblerNumber++;
            match++;
        }
               

                

        private void payoutButton_Click(object sender, EventArgs e)
        {
            payout();
        }
    }
}


