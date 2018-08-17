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
    public partial class Screen2 : Form
    {

        public Screen2()
        {
            InitializeComponent();
            
        }

        private void Screen2_Load(object sender, EventArgs e)
        {
            //based on the LocNum that was picked on form1, this inserts the name of loc.
            if (Data.LocNum == 1)
            {
                lblLocName.Text = "KFC North: 111 Sad Drive Gain GA, 31222.";
                lblPhone.Text += Data.LocNum;
            }
            else if (Data.LocNum == 2)
            {
                lblLocName.Text = "KFC South: 231 Happy Drive Gain GA, 31222.";
                lblPhone.Text += Data.LocNum;
            }
            else if (Data.LocNum == 3)
            {
                lblLocName.Text = "KFC East: 231 Super Drive Gain GA, 31222.";
                lblPhone.Text += Data.LocNum;
            }
        }

        //private void label14_Click(object sender, EventArgs e)
        //{

        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the form.
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //this adds up the total based on what is entered.
            Data.Total += (double)nudItem1.Value * 2;
            Data.Total += (double)nudItem2.Value * 3;
            Data.Total += (double)nudItem3.Value * 4.50;
            Data.Total += (double)nudItem4.Value * 2;
            Data.Total += (double)nudItem5.Value * 3;
            Data.Total += (double)nudItem6.Value * 5;
            Data.Total += (double)nudItem7.Value * 6.75;
            Data.Total += (double)nudSide1.Value * 1;
            Data.Total += (double)nudSide2.Value * 2;
            Data.Total += (double)nudSide3.Value * 3;
            Data.Total += (double)nudSide4.Value * 1;
            Data.Total += (double)nudSmallCoke.Value * 1;
            Data.Total += (double)nudMedCoke.Value * 2;
            Data.Total += (double)nudLargeCoke.Value * 3;
            Data.Total += (double)nudSmallDew.Value * 1;
            Data.Total += (double)nudMedDew.Value * 2;
            Data.Total += (double)nudLargeDew.Value * 3;
            Data.Total += (double)nudSmallDr.Value * 1;
            Data.Total += (double)nudMedDr.Value * 2;
            Data.Total += (double)nudLargeDr.Value * 3;
            Data.Total += (double)nudSmallTea.Value * 1;
            Data.Total += (double)nudMedTea.Value * 2;
            Data.Total += (double)nudLargeTea.Value * 3;
            Data.Total += (double)nudSmallWater.Value * 1;
            Data.Total += (double)nudMedWater.Value * 2;
            Data.Total += (double)nudLagreWater1.Value * 3;

            //if the iteam was added it adds it to a list.
            if(nudItem1.Value > 0)
            {
                Data.FoodIteams.Add(lblItem1.Text);
            }
            if (nudItem2.Value > 0)
            {
                Data.FoodIteams.Add(lblItem2.Text);
            }
            if (nudItem3.Value > 0)
            {
                Data.FoodIteams.Add(lblItem3.Text);
            }
            if (nudItem4.Value > 0)
            {
                Data.FoodIteams.Add(lblItem4.Text);
            }
            if (nudItem5.Value > 0)
            {
                Data.FoodIteams.Add(lblItem5.Text);
            }
            if (nudItem6.Value > 0)
            {
                Data.FoodIteams.Add(lblItem6.Text);
            }
            if (nudItem7.Value > 0)
            {
                Data.FoodIteams.Add(lblItem7.Text);
            }
            if (nudSide1.Value > 0)
            {
                Data.FoodIteams.Add(lblSide1.Text);
            }
            if (nudSide2.Value > 0)
            {
                Data.FoodIteams.Add(lblSide2.Text);
            }
            if (nudSide3.Value > 0)
            {
                Data.FoodIteams.Add(lblSide3.Text);
            }
            if (nudSide4.Value > 0)
            {
                Data.FoodIteams.Add(lblSide4.Text);
            }
            if (nudSmallCoke.Value > 0)
            {
                Data.FoodIteams.Add("Small Coke");
            }
            if (nudSmallDew.Value > 0)
            {
                Data.FoodIteams.Add("Small Dew");
            }
            if (nudSmallDr.Value > 0)
            {
                Data.FoodIteams.Add("Small Dr.Pepper");
            }
            if (nudSmallTea.Value > 0)
            {
                Data.FoodIteams.Add("Small Tea");
            }
            if (nudSmallWater.Value > 0)
            {
                Data.FoodIteams.Add("Small Water");
            }
            if (nudMedCoke.Value > 0)
            {
                Data.FoodIteams.Add("Med Coke");
            }
            if (nudMedDew.Value > 0)
            {
                Data.FoodIteams.Add("Med Dew");
            }
            if (nudMedDr.Value > 0)
            {
                Data.FoodIteams.Add("Med Dr.Pepper");
            }
            if (nudMedTea.Value > 0)
            {
                Data.FoodIteams.Add("Med Tea");
            }
            if (nudMedWater.Value > 0)
            {
                Data.FoodIteams.Add("Med Water");
            }
            if (nudLargeCoke.Value > 0)
            {
                Data.FoodIteams.Add("Large Coke");
            }
            if (nudLargeDew.Value > 0)
            {
                Data.FoodIteams.Add("Large Dew");
            }
            if (nudLargeDr.Value > 0)
            {
                Data.FoodIteams.Add("Large Dr.Pepper");
            }
            if (nudLargeTea.Value > 0)
            {
                Data.FoodIteams.Add("Large Tea");
            }
            if (nudLagreWater1.Value > 0)
            {
                Data.FoodIteams.Add("Large Water");
            }



            //sees if this is a delivery and if so adds the 7 fee
            if (Data.Delivery == true)
            {
                Data.Total += 7;
            }

            Data.TotalScreen.Show();
            this.Hide();
        }
    }
}
