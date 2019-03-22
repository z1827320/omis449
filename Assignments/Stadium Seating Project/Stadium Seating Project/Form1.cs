using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating_Project
{
    public partial class stadiumSeating : Form
    {
        public stadiumSeating()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        //Closes Application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcRevButton_Click(object sender, EventArgs e)
        {
            //If Statement checks to make sure an appropriate value is inserted for each field
            if (classAInput.Text != "" && classBInput.Text != "" && classCInput.Text != "")
            {
                try
                {
                    //Initializes 4 variables of type double to hold values for mathematical calculations
                    double classA;
                    double classB;
                    double classC;
                    double total;

                    //Converts user input from form and stores values in created variables
                    classA = double.Parse(classAInput.Text);
                    classB = double.Parse(classBInput.Text);
                    classC = double.Parse(classCInput.Text);

                    //Multiplies each class ticket with the respective value (per ticket)
                    classA = classA * 15.0;
                    classB = classB * 12.0;
                    classC = classC * 9.0;

                    //Converts and displays total amounts per class ticket and sends the "currency" formatting to ToString
                    rgCAOutput.Text = classA.ToString("c");
                    rgCBOutput.Text = classB.ToString("c");
                    rgCCOutput.Text = classC.ToString("c");

                    //Sums totals and converts and displays to user
                    total = classA + classB + classC;
                    totalOutput.Text = total.ToString("c");
                }

                catch
                {
                    MessageBox.Show("Invalid data was entered.");
                }
            }
            //Default error message
            else
                MessageBox.Show("Please assign a value to each field.");
        }

        //Clears the fields
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears the Tickets Sold Fields
            classAInput.Text = String.Empty;
            classBInput.Text = String.Empty;
            classCInput.Text = String.Empty;

            //Clears the Revenue Generates Fields
            rgCAOutput.Text = String.Empty;
            rgCBOutput.Text = String.Empty;
            rgCCOutput.Text = String.Empty;
            totalOutput.Text = String.Empty;
        }  
                
    }
}
