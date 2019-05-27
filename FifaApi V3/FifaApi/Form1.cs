using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FifaApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            reloadTeams();
            reloadMatches();
            readJson();
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            reloadTeams();
            reloadMatches();
        }

        public void reloadTeams()
        {
            listBox.Items.Clear();
            int input = (int)inputNumber.Value;
            // Bron: https://stackoverflow.com/a/4758334
            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson;

            dataJson = downloader.DownloadString("http://localhost/the_fifa_project/Php-code/api/index.php?apikey=$2VAo@5JGt8%");


            Data[] data = JsonConvert.DeserializeObject<Data[]>(dataJson);

            nameLabel.Text = "Team name: " + data[0].name;
            idLabel.Text = "" + data[0].id;
            label6.Text = "" + data[0].goals;
            label7.Text = "" + data[0].wins;
            label8.Text = "" + data[0].loses;

            allMatchesListBox.Items.Clear();
            foreach (var team in data)
            {
                allMatchesListBox.Items.Add(team.name);
            }
        }

        public void reloadMatches()
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string matchDataJson = downloader.DownloadString("http://localhost/the_fifa_project/Php-code/api/index.php?apikey=Rz7^8p2%4VYk");

            matches[] matches = JsonConvert.DeserializeObject<matches[]>(matchDataJson);

                allMatchesListBox.Items.Clear();
                foreach (var match in matches)
                {
                    allMatchesListBox.Items.Add(match.team1 + " vs " + match.team2);
                }
            
        }

        public void readJson()
        {
                //leest de users uit een json en zet ze in een combobox
                using (StreamReader userReader = new StreamReader(@"C:\Json_save\Savedata.json"))
                {
                    var json = userReader.ReadToEnd();
                    var users = JsonConvert.DeserializeObject<List<User>>(json);

                //zet al de users in een combobox
                    gambleUserComboBox.Items.Clear();
                    foreach (var user in users)
                    {
                        gambleUserComboBox.Items.Add(user.Name);
                    }
                }
           }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            //opent een nieuwe form
            AddUser form = new AddUser();
            form.ShowDialog();
        }

        private void gambleUserComboBox_Click(object sender, EventArgs e)
        {
            readJson();
        }

        public void reloadCurrencyLabel()
        {
            //haalt de json op en stopt het in de user class
            using (StreamReader userReader = new StreamReader(@"C:\Json_save\Savedata.json"))
            {
                var json = userReader.ReadToEnd();
                var users = JsonConvert.DeserializeObject<List<User>>(json);

                foreach (var user in users)
                {
                    //check hoeveel currency de user heeft
                    for (int i = 0; i < users.Count; i++)
                    {
                        if (users[i].Name == gambleUserComboBox.SelectedItem.ToString())
                        {
                            //zet de currency van de geselecteerde user in de currency label
                            currencyLabel.Text = users[i].Currency.ToString();
                            return;
                        }
                    }
                }
            }
        }

        private void gambleUserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadCurrencyLabel();
        }


        public void bet()
        {
            //haalt de json op en stopt het in de user class
            using (StreamReader userReader = new StreamReader(@"C:\Json_save\Savedata.json"))
            {
                var json = userReader.ReadToEnd();
                var users = JsonConvert.DeserializeObject<List<User>>(json);

                foreach (var user in users)
                {
                    try
                    {
                        //check hoeveel currency de user heeft
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].Name == gambleUserComboBox.SelectedItem.ToString())
                            {
                                //als de user niet genoeg geld heeft, meld dat dan
                                if (users[i].Currency < (int)gamblingAmmountNumUpDown.Value)
                                {
                                    MessageBox.Show("You dont have enough money");
                                    return;
                                }
                                //als de user wel genoeg geld heeft haal het geld van zijn balance af
                                else
                                {
                                    string bettor = users[i].Name;

                                    users[i].Currency -= (int)gamblingAmmountNumUpDown.Value;
                                    int uCurrency = users[i].Currency;
                                    currencyLabel.Text = uCurrency.ToString();
                                    MessageBox.Show(bettor + " just betted " + gamblingAmmountNumUpDown.Value + " on team " + betOnTeam.Value);
                                    return;
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Please select a user");
                        return;
                    }
                }
            }
        }

        private void gambleButton_Click_1(object sender, EventArgs e)
        {
            bet();
        }

        private void reloadMatchesButton_Click(object sender, EventArgs e)
        {
            reloadTeams();
            reloadMatches();
        }

        private void listBox_Click(object sender, EventArgs e)
        {
            //haalt de json op en stopt het in de user class
            using (StreamReader userReader = new StreamReader(@"C:\Json_save\Savedata.json"))
            {
                var json = userReader.ReadToEnd();
                var users = JsonConvert.DeserializeObject<List<User>>(json);

                foreach (var user in users)
                {

                    //check hoeveel currency de user heeft
                    for (int i = 0; i < users.Count; i++)
                    {
                        if (users[i].Name == gambleUserComboBox.SelectedItem.ToString())
                        {
                            //voegt 100 toe aan de balance van de user(het cheatcode systeem)
                                string bettor = users[i].Name;

                                users[i].Currency += 100;
                                int uCurrency = users[i].Currency;
                                currencyLabel.Text = uCurrency.ToString();
                                MessageBox.Show(bettor + " just got 100!");
                                return;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.fifa.getTeams();
            Debug.WriteLine(Program.fifa.team.Count);
        }
    }
}

