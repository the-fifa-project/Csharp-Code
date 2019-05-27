using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifaApi
{
    class Team
    {
        public string id { get; set; }
        public string name { get; set; }
        public string owner { get; set; }
        public string goals { get; set; }
        public string wins { get; set; }
        public string loses { get; set; }
        public string createdat { get; set; }
        public string editat { get; set; }
    }

    //    public string Name { get; set; }
    //    public int Cash { get; set; }
    //    public RadioButton MyRadioButton { get; set; }
    //    public Label MyLabel { get; set; }
    //    public int Amount { get; set; }
    //    private Bet MyBet = new Bet();

    //    //Update labels to show the amount of money each Guy has
    //    public void UpdateLabels()
    //    {
    //        MyBet.Bettor = this;
    //        MyLabel.Text = MyBet.GetDescription();
    //        MyRadioButton.Text = Name + " heeft " + Cash + " euro";
    //    }

    //    public bool PlaceBet(int Amount, int Dog)
    //    {
    //        // Place a new bet and store it in my bet field      
    //        // Return true if the guy had enough money to bet
    //        if (Cash >= Amount)
    //        {
    //            MyBet.Amount = Amount;
    //            Cash -= Amount;
    //            MyBet.Dog = Dog;
    //            return true;
    //        }
    //        else
    //        {
    //            MessageBox.Show(Name + " Heeft geen geld meer! ");
    //            return false;
    //        }
    //    }

    //    public void Collect(int Winner)
    //    {
    //        MyBet.PayOut(Winner); // Ask my bet to pay out
    //    }
    //}
}
