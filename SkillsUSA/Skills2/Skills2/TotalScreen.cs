using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills2
{
    public partial class TotalScreen : Form
    {
        public TotalScreen()
        {
            InitializeComponent();
        }

        private void TotalScreen_Load(object sender, EventArgs e)
        {
            //gets the data from the class
            lblName.Text += Data.FirstName + " " + Data.LastName;
            lblAddress.Text += Data.Address;
            lblPhone.Text += Data.PhoneNum.ToString();
            lblTotal.Text += "$" + Math.Round(Data.Total, 2);

            for(int x = 0; x < Data.FoodIteams.Count; x++)
            {
                lblItemsOrdered.Text += "\n" + Data.FoodIteams[x];
            }


        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data.Form1.Show();

            Data.FirstName = "";
            Data.LastName = "";
            Data.LocNum = 0;
            Data.Address = "";
            Data.Delivery = false;
            Data.PhoneNum = 0;
            Data.Total = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
