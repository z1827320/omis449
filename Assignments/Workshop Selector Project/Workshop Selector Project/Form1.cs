using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Selector_Project
{
    public partial class Form1 : Form
    {
        //Variables to handle logic within switch statements and math for output boxes
        decimal regFee = 0;
        decimal days = 0;
        //logFee is per day
        decimal logFee = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Calculate Button code
        private void calcCost_Click(object sender, EventArgs e)
        {
            //Index option based on option chosen by user in listbox, with error msg for no selection
            if (lstWS.SelectedIndex != -1)
            {
                switch (lstWS.SelectedIndex)
                {
                    case 0:
                        regFee = 1000;
                        days = 3;
                        break;

                    case 1:
                        regFee = 800;
                        days = 3;
                        break;

                    case 2:
                        regFee = 1500;
                        days = 3;
                        break;

                    case 3:
                        regFee = 1300;
                        days = 5;
                        break;

                    case 4:
                        regFee = 500;
                        days = 1;
                        break;
                }
            }
            else
            {
                MessageBox.Show("No Workshop selected ya dummy!");
            }

            //Index option based on option chosen by user in listbox, with error msg for no selection
            if (lstLoc.SelectedIndex != -1)
            {
                switch (lstLoc.SelectedIndex)
                {
                    case 0:
                        logFee = 150;
                        break;

                    case 1:
                        logFee = 225;
                        break;

                    case 2:
                        logFee = 175;
                        break;

                    case 3:
                        logFee = 300;
                        break;

                    case 4:
                        logFee = 175;
                        break;

                    case 5:
                        logFee = 150;
                        break;
                }
            }

            //Default error box
            else
            {
                MessageBox.Show("No Location selected ya dummy!");
            }

            //Outputs the Registration Fee and the Lodging(perday) fee
            regText.Text = regFee.ToString("c");
            lodText.Text = (logFee * days).ToString("c");

            //Calculates and displays the Total Cost
            var total = (logFee * days) + regFee;
            totText.Text = total.ToString("c");
        }

        //Exit the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clears selection and output boxes
        private void clearButton_Click(object sender, EventArgs e)
        {
            lstWS.SelectedIndex = -1;
            lstLoc.SelectedIndex = -1;

            regText.Text = String.Empty;
            lodText.Text = String.Empty;
            totText.Text = String.Empty;
        }
    }
}
