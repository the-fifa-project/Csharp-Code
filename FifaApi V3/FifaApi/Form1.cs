using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FifaApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {

            
            listBox.Items.Clear();
            int input = (int)inputNumber.Value;
            // Bron: https://stackoverflow.com/a/4758334
            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson;
       
            dataJson = downloader.DownloadString("http://localhost/fifa-project/Php-code/api/index.php?apikey=$2VAo@5JGt8%");
            MessageBox.Show("http://localhost/Php-code/api/" + input.ToString());
            Debug.WriteLine(dataJson);
            Data[] data = JsonConvert.DeserializeObject<Data[]>(dataJson);
            
            //nameLabel.Text = "Team name: " + data[0].name;
            //idLabel.Text = "" + data[0].id;

            listBox.Items.Add("Name: " + data[0].name);
            listBox.Items.Add("ID: " + data[0].id);
            listBox.Items.Add("Goals: " + data[0].players);
            listBox.Items.Add("Wins: " + data[0].wins);
            listBox.Items.Add("Losses: " + data[0].loses);

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.fifa.getTeams();
            Debug.WriteLine(Program.fifa.team.Count);
        }
    }
}
