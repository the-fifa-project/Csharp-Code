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
            readJson();
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            int input = (int)inputNumber.Value;
            // Bron: https://stackoverflow.com/a/4758334
            System.Net.WebClient downloader = new System.Net.WebClient();
            string dataJson;

            dataJson = downloader.DownloadString("http://localhost/the_fifa_project/Php-code/api?id=" + input.ToString());


            Data[] data = JsonConvert.DeserializeObject<Data[]>(dataJson);

            nameLabel.Text = "Team name: " + data[0].name;
            idLabel.Text = "" + data[0].id;
            label6.Text = "" + data[0].goals;
            label7.Text = "" + data[0].wins;
            label8.Text = "" + data[0].loses;
        }

        public void readJson()
        {
            using (StreamReader r = new StreamReader(@"C:\Json_save\Savedata.json"))
            {
                var json = r.ReadToEnd();
                var model = JsonConvert.DeserializeObject<List<User>>(json);

                foreach (var item in model)
                {
                    MessageBox.Show(item.Name);
                }
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            form.ShowDialog();
        }
    }
}
