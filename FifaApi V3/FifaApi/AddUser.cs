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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        List<User> _data = new List<User>();


        private void AddUser_Load(object sender, EventArgs e)
        {
            readJson();
        }

        public void readJson()
        {
            using (StreamReader r = new StreamReader(@"C:\Json_save\Savedata.json"))
            {
                var jsonString = r.ReadToEnd();
                var model = JsonConvert.DeserializeObject<List<User>>(jsonString);
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                readJson();
                string fileName = Path.Combine(@"C:\Json_save\Savedata.json");
                string allJson = File.ReadAllText(fileName);
                var initialJson = allJson;

                var array = JArray.Parse(initialJson);

                var itemToAdd = new JObject();
                itemToAdd["currency"] = 100;
                itemToAdd["name"] = nameTextBox.Text;
                array.Add(itemToAdd);

                var jsonToOutput = JsonConvert.SerializeObject(array, Formatting.Indented);

                string json = JsonConvert.SerializeObject(jsonToOutput.ToArray());

                //write string to file
                File.WriteAllText(@"C:\Json_save\Savedata.json", jsonToOutput);
                MessageBox.Show("Succesfully created account!");
                Close();
            }

            catch
            {
                MessageBox.Show("Whoops, looks like something went wrong :(");
            }
        }
    }
}
