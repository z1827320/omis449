using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stadiumseating
{
    public partial class StadiumSeating : Form
    {
        public StadiumSeating()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double classa; //to hold class A number
                double classb; //to hold class B number
                double classc; //to hold class C number
                double classaT; //to hold class A total
                double classbT; //to hold class B total
                double classcT; //to hold class C total
                double total; //to hold the total revenue

                //get the three class number of seats
                classa = double.Parse(tbC1.Text);
                classb = double.Parse(tbC2.Text);
                classc = double.Parse(tbC3.Text);

                //calculate the total revenue for each class
                classaT = classa * 15.00;
                classbT = classb * 12.00;
                classcT = classc * 9.00;

                //calculate the total revenue
                total = (classaT + classbT + classcT);

                //display total revenues
                lblClassA.Text = classaT.ToString("c");
                lblClassB.Text = classbT.ToString("c");
                lblClassC.Text = classcT.ToString("c");
                lblTotal.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                //display the default error message
                MessageBox.Show(ex.Message);
            }
        }

    


        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click_1(object sender, EventArgs e)
        {
            //clear the input and output controls
            lblClassA.Text = "";
            lblClassB.Text = "";
            lblClassC.Text = "";
            lblTotal.Text = "";
            tbC1.Text = "";
            tbC2.Text = "";
            tbC3.Text = "";
        }
    }
}
