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


        private void AddUser_Load(object sender, EventArgs e)
        {
            readJson();
        }

        public void readJson()
        {
            //haalt de json op en stopt het in de user class
            using (StreamReader r = new StreamReader(@"C:\Json_save\Savedata.json"))
            {
                var jsonString = r.ReadToEnd();
                var users = JsonConvert.DeserializeObject<List<User>>(jsonString);
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        { 
            try
            {
                if (nameTextBox.Text != "")
                {
                    //bereid de json voor om op te slaan als het veld niet leeg is
                    readJson();
                    //haalt het json bestand op
                    string fileName = Path.Combine(@"C:\Json_save\Savedata.json");
                    //leest al de json
                    string allJson = File.ReadAllText(fileName);
                    //slaat de json op in een variabele
                    var initialJson = allJson;

                    //parsed de json
                    var array = JArray.Parse(initialJson);

                    //maakt een nieuw object met daarin alles wat in de json moet
                    var itemToAdd = new JObject();
                    itemToAdd["currency"] = 100;
                    itemToAdd["name"] = nameTextBox.Text;
                    //stopt het object in de array met al bestaande json bestanden
                    array.Add(itemToAdd);

                    //serialized de array
                    var jsonToOutput = JsonConvert.SerializeObject(array, Formatting.Indented);
                    string json = JsonConvert.SerializeObject(jsonToOutput.ToArray());

                    //zet de json string in savedata.json
                    File.WriteAllText(@"C:\Json_save\Savedata.json", jsonToOutput);
                    MessageBox.Show("Succesfully created account!");
                    Close();
                }
                else
                {
                    MessageBox.Show("No username detected");
                }
            }

            catch
            {
                MessageBox.Show("Whoops, looks like something went wrong :(");
            }
        }
    }
}
