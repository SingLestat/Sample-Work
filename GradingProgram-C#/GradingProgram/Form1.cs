using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class Form1 : Form
    {
        List<double> ProgrammingGrades = new List<double>();
        List<double> ArtGrades = new List<double>();
        List<double> ScienceGrades = new List<double>();
        List<double> MathGrades = new List<double>();
        List<double> HistoryGrades = new List<double>();
        List<double> AvgGrades = new List<double>() ;

        double Grade;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Select a class to enter grades.");
        }

        private void btnEnterGrade_Click(object sender, EventArgs e)
        {
            if (lbxClass.SelectedItem.ToString() == "Programming")
            {
                if (!double.TryParse(boxGrade.Text, out Grade))
                {
                    MessageBox.Show("Invaild Grade");
                    boxGrade.Clear();
                }
                else if (Grade < 0 || Grade > 100)
                {
                    MessageBox.Show("Invaild Grade");
                    boxGrade.Clear();
                }
                else
                {
                    ProgrammingGrades.Add(Grade);
                }
            }
            else if (lbxClass.SelectedItem.ToString() == "Art")
            {
                if (!double.TryParse(boxGrade.Text, out Grade))
                {
                    MessageBox.Show("Invaild Grade");
                    boxGrade.Clear();
                }
                else if (Grade < 0 || Grade > 100)
                {
                    MessageBox.Show("Invaild Grade");
                    boxGrade.Clear();
                }
                else
                {
                    ArtGrades.Add(Grade);
                }

            }
            else if (lbxClass.SelectedItem.ToString() == "Science")
            {
                if (!double.TryParse(boxGrade.Text, out Grade))
                {
                    MessageBox.Show("Invaild Grade");
                    boxGrade.Clear();
                }
                else if (Grade < 0 || Grade > 100)
                {
                    MessageBox.Show("Invaild Grade");
                    boxGrade.Clear();
                }
                else
                {
                    ScienceGrades.Add(Grade);
                }
            }
            else if (lbxClass.SelectedItem.ToString() == "Math")
            {
                if (!double.TryParse(boxGrade.Text, out Grade))
                {
                    MessageBox.Show("Invaild Grade");
                    boxGrade.Clear();
                }
                else if (Grade < 0 || Grade > 100)
                {
                    MessageBox.Show("Invaild Grade");
                    boxGrade.Clear();
                }
                else
                {
                    MathGrades.Add(Grade);
                }
            }
            else if (lbxClass.SelectedItem.ToString() == "History")
            {
                if (!double.TryParse(boxGrade.Text, out Grade))
                {
                    MessageBox.Show("Invaild Grade");
                    boxGrade.Clear();
                }
                else if (Grade < 0 || Grade > 100)
                {
                    MessageBox.Show("Invaild Grade");
                    boxGrade.Clear();
                }
                else
                {
                    HistoryGrades.Add(Grade);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            boxGrade.Clear();
            lbxClass.ClearSelected();
            btnEnterGrade.Visible = false;
            btnCal.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            AvgGrades.Clear(); // start with a cleared list.

            txtClassName.Text = "Class: ";
            txtCurrentAverage.Text = "Current Average: ";
            txtHighScore.Text = "High Score: ";
            txtLowScore.Text = "Low Score: ";
            txtScoresEntered.Text = "Scores Entered: ";

            if (lbxClass.SelectedItem.ToString() == "Programming")
            {
                txtClassName.Text += lbxClass.SelectedItem.ToString();

                for (int c = 0; c < ProgrammingGrades.Count; c++)
                {
                    txtScoresEntered.Text += ProgrammingGrades[c] + ", ";

                    AvgGrades.Add(Math.Round(ProgrammingGrades[c],0));
                }
                if (ProgrammingGrades.Count != 0)
                {
                    txtCurrentAverage.Text += AvgGrades.Average();
                    txtHighScore.Text += ProgrammingGrades.Max();
                    txtLowScore.Text += ProgrammingGrades.Min();
                }
            }
            else if (lbxClass.SelectedItem.ToString() == "Art")
            {

                txtClassName.Text += lbxClass.SelectedItem.ToString();

                for (int c = 0; c < ArtGrades.Count(); c++)
                {
                    txtScoresEntered.Text += ArtGrades[c] + ", ";

                    AvgGrades.Add(Math.Round(ArtGrades[c],0));
                }
                if (ArtGrades.Count != 0)
                {
                    txtCurrentAverage.Text += AvgGrades.Average();
                    txtHighScore.Text += ArtGrades.Max();
                    txtLowScore.Text += ArtGrades.Min();
                }

            }
            else if (lbxClass.SelectedItem.ToString() == "Science")
            {

                txtClassName.Text += lbxClass.SelectedItem.ToString();

                for (int c = 0; c < ScienceGrades.Count(); c++)
                {
                    txtScoresEntered.Text += ScienceGrades[c] + ", ";

                    AvgGrades.Add(Math.Round(ScienceGrades[c],0));
                }
                if (ScienceGrades.Count != 0)
                {
                    txtCurrentAverage.Text += AvgGrades.Average();
                    txtHighScore.Text += ScienceGrades.Max();
                    txtLowScore.Text += ScienceGrades.Min();
                }

            }
            else if (lbxClass.SelectedItem.ToString() == "Math")
            {

                txtClassName.Text += lbxClass.SelectedItem.ToString();

                for (int c = 0; c < MathGrades.Count(); c++)
                {
                    txtScoresEntered.Text += MathGrades[c] + ", ";

                    AvgGrades.Add(Math.Round(MathGrades[c],0));
                }
                if (MathGrades.Count != 0)
                {
                    txtCurrentAverage.Text += AvgGrades.Average();
                    txtHighScore.Text += MathGrades.Max();
                    txtLowScore.Text += MathGrades.Min();
                }

            }
            else if (lbxClass.SelectedItem.ToString() == "History")
            {

                txtClassName.Text += lbxClass.SelectedItem.ToString();

                for (int c = 0; c < HistoryGrades.Count(); c++)
                {
                    txtScoresEntered.Text += HistoryGrades[c] + ", ";

                    AvgGrades.Add(Math.Round(HistoryGrades[c],0));
                }
                if (HistoryGrades.Count != 0)
                {
                    txtCurrentAverage.Text += AvgGrades.Average();
                    txtHighScore.Text += HistoryGrades.Max();
                    txtLowScore.Text += HistoryGrades.Min();
                }

            }
        }

        private void lbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEnterGrade.Visible = true;
            btnCal.Visible = true;
        }
    }
}
