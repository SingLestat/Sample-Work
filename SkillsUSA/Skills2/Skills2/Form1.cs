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
    public partial class Form1 : Form
    {
        private bool Nextform = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes Form
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears all data;
            txt1stName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            lbxLoc.ClearSelected();
            Nextform = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txt1stName.Text))
            {
                //if has data saves value to class 
                Data.FirstName = txt1stName.Text;
                Nextform = true;
            }
            else
            {
                MessageBox.Show("Enter a First Name.");
                Nextform = false;
            }

            if (!String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                //if has data saves value to class
                Data.LastName = txtLastName.Text;
                Nextform = true;
            }
            else
            {
                MessageBox.Show("Enter a Last Name.");
                Nextform = false;
            }

            if (!String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                //if has data saves value to class
                Data.Address = txtAddress.Text;
                Nextform = true;
            }
            else
            {
                MessageBox.Show("Enter a Address.");
                Nextform = false;
            }

            //if the number is a int show that message. else set it to data class.
            if(!int.TryParse(txtPhone.Text, out Data.PhoneNum))
            {
                MessageBox.Show("Enter a Phone Number");
                Nextform = false;
            }

            //sees is the box is selected then saves to class.
            if(rbnDelivery.Checked)
            {
                Data.Delivery = true;
                Nextform = true;
            }
            else
            {
                Data.Delivery = false;
                Nextform = true;
            }

            //changes a num to change where the loc is. 
            if(lbxLoc.Text == "KFC North")
            {
                Data.LocNum = 1;
                Nextform = true;
            }
            else if (lbxLoc.Text == "KFC South")
            {
                Data.LocNum = 2;
                Nextform = true;
            }
            else if (lbxLoc.Text == "KFC East")
            {
                Data.LocNum = 3;
                Nextform = true;
            }
            else
            {
                MessageBox.Show("Select a Location.");
                Nextform = false;
            }

            if(Nextform == true)
            {
                Data.screen2.Show();
                this.Hide();
            }
        }
    }
}
