using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Computer_Science_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getHoursButton_Click(object sender, EventArgs e)
        {
            //Variable to hold input
            string name, id, track;

            //get the students name and id
            name = nameTextBox.Text;
            id = idTextBox.Text;

            //get the students academic track
            if (infoSystemsRadioButton.Checked)
            {
                track = "Information Systems";
            }
            else
            {
                track = "Software Engineering";
            }

            //create a CompSciStudent object
            CompSciStudent csStudent =
                new CompSciStudent(name, id, track);

            //display the students required hours
            requiredHoursLabel.Text =
                csStudent.RequiredHours.ToString("n1");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
