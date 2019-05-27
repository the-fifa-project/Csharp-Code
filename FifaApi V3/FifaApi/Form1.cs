using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            ReloadMatches();
            readJson();
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            ReloadMatches();
        }

        public void ReloadMatches()
        {
            listBox.Items.Clear();
            // Bron: https://stackoverflow.com/a/4758334
            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson;

            dataJson = downloader.DownloadString("http://localhost/the_fifa_project/Php-code/api/index.php?apikey=$2VAo@5JGt8%");


            List<Data> data = JsonConvert.DeserializeObject<List<Data>>(dataJson);

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

        public void readJson()
        {
            using (StreamReader userReader = new StreamReader(@"C:\Json_save\Savedata.json"))
            {
                var json = userReader.ReadToEnd();
                var users = JsonConvert.DeserializeObject<List<User>>(json);

                gambleUserComboBox.Items.Clear();
                foreach (var user in users)
                {
                    gambleUserComboBox.Items.Add(user.Name);
                }
            }

            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson;

            dataJson = downloader.DownloadString("http://localhost/the_fifa_project/Php-code/api/index.php?apikey=$2VAo@5JGt8%");


            List<matches> matches = JsonConvert.DeserializeObject<List<matches>>(dataJson);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            form.ShowDialog();
        }

        private void gambleUserComboBox_Click(object sender, EventArgs e)
        {
            readJson();
        }

        private void gambleUserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (StreamReader userReader = new StreamReader(@"C:\Json_save\Savedata.json"))
            {
                var json = userReader.ReadToEnd();
                var users = JsonConvert.DeserializeObject<List<User>>(json);

                if (users.Contains(gambleUserComboBox.SelectedItem))
                {
                    MessageBox.Show(gambleUserComboBox.SelectedItem.ToString());
                }
            }
        }
    }
}

