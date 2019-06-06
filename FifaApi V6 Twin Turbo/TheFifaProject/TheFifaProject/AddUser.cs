using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFifaProject
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void addGamblerButton_Click(object sender, EventArgs e)
        {
            Gamblers gambler = new Gamblers();
            gambler.Currency = 100;
            gambler.Name = gamblerNameTextBox.Text;

            Program.gamblers.Add(gambler);
            MessageBox.Show("Gokker toegevoegd!");

            Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
        }
    }
}
