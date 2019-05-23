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

namespace FifaApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson;
            dataJson = downloader.DownloadString("http://localhost/php-code/api/");
            Data[] data = JsonConvert.DeserializeObject<Data[]>(dataJson);
            for (int i = 0; i < data.Length; i++)
            {
                dataJson = downloader.DownloadString("http://localhost/php-code/api/?id=" + i);
                teamNamesList.Items.Add(data[i].name);
            }
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            int input = (int)inputNumber.Value;
            // Bron: https://stackoverflow.com/a/4758334
            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson;

            dataJson = downloader.DownloadString("http://localhost/php-code/api/?id=" + input.ToString());

            
            Data[] data = JsonConvert.DeserializeObject<Data[]>(dataJson);
            
            nameLabel.Text = "Team name: " + data[0].name;
            idLabel.Text = "" + data[0].id;
            goalsLabel.Text = "" + data[0].goals;
            winsLabel.Text = "" + data[0].wins;
            lossesLabel.Text = "" + data[0].loses;
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
    }
}
