using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
        string FName;
        string LName;
        double Num;
        double EndNum;
        bool Cal = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLname.Clear();
            txtNum.Clear();
            lblResults.Text = "Results: ";
            FName = "";
            LName = "";
            Num = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtFName.Text))
            {
                //set name and lets the form output by seting to true
                FName = txtFName.Text;
                Cal = true;
            }
            else
            {
                MessageBox.Show("Enter Your First Name.");
            }

            if (!String.IsNullOrWhiteSpace(txtLname.Text))
            {
                //set name and lets the form output by seting to true
                LName = txtLname.Text;
                Cal = true;
            }
            else
            {
                MessageBox.Show("Enter Your Last Name.");
            }

            if(!double.TryParse(txtNum.Text, out Num))
            {
                MessageBox.Show("Enter a Number");
            }

            if(rbnFeet.Checked)
            {
                //Does Math
                EndNum = Math.Round(Num * 304.8, 3);
            }
            else if (rbnYards.Checked)
            {
                //Does Math
                EndNum = Math.Round(Num * .09144, 3);
            }
            else if (rbnFeet.Checked)
            {
                //Does Math
                EndNum = Math.Round(Num * 1.60934, 3);              
            }

            //if everything is right. show results.
            if (Cal == true)
            {
                lblResults.Text += " Name: " + FName + " " + LName + ". Converted Number(Rounded): " + EndNum;
                MessageBox.Show("Please Clear to do another convertion.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
