﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CD_Account_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The GetCDDate method accepts a CDAccount object
        //as an argument. It assigns the data entered by
        //the user to the object's properties
        private void GetCDDate(CDAccount account)
        {
            //Temporary variables to hold interest rate
            //and balance
            decimal interestRate;
            decimal balance;

            //get the account number
            account.AccountNumber = accountNumberTextBox.Text;

            //get the maturity date
            account.MaturityDate = maturityDateTextBox.Text;

            //get the interest rate
            if (decimal.TryParse(interestRateTextBox.Text, out interestRate))
            {
                account.InteresRate = interestRate;

                //get the balance
                if (decimal.TryParse(balanceTextBox.Text, out balance))
                {
                    account.Balance = balance;
                }
                else
                {
                    //Display an error message
                    MessageBox.Show("Invalid balance");
                }
            }
            else
            {
                //Display an error message
                MessageBox.Show("Invalid interest rate");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            //Create a CDAcount object
            CDAccount myAccount = new CDAccount();

            //Get the CD account data
            GetCDDate(myAccount);

            //Display the CD account data.
            accountNumberLabel.Text = myAccount.AccountNumber;
            interestRateLabel.Text = myAccount.InteresRate.ToString("n2");
            balanceLabel.Text = myAccount.Balance.ToString("c");
            maturityDateLabel.Text = myAccount.MaturityDate;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
