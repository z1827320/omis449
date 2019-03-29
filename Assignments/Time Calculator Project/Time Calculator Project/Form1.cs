using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Calculator_Project
{
    public partial class timeCalc : Form
    {
        public timeCalc()
        {
            InitializeComponent();
        }

        private void timeCalc_Load(object sender, EventArgs e)
        {

        }

        //Handles the Calculate button
        private void calcButton_Click(object sender, EventArgs e)
        {
            //Variables to handle seconds and minutes
            int sec = 0;
            int min = 0;

            //Converts the input text from the form to an integer
            sec = int.Parse(secInputText.Text);

            //divides the number by 60 to get number of minutes
            min = sec / 60;

            //Send the minutes from seconds
            minOutputText.Text = min.ToString();
        }

        //Closes the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
