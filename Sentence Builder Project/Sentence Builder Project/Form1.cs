using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Builder_Project
{
    public partial class sentenceBuilder : Form
    {
        //sentence builder will construct a sentence depending on users choice
        public sentenceBuilder()
        {
            InitializeComponent();

            //intializing the textbox with a "null" value
            textBox.Text = "";
        }

        //loads the form
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //WAY TOO MANY BUTTONS
        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox.Text = String.Empty;
        }

        //closes the application
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uppercaseA_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + uppercaseA.Text;
        }

        private void lowercaseA_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + lowercaseA.Text;
        }

        private void uppercaseAn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + uppercaseAn.Text;
        }

        private void lowercaseAn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + lowercaseAn.Text;
        }

        private void uppercaseThe_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + uppercaseThe.Text;
        }

        private void lowecaseThe_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + lowercaseThe.Text;
        }

        private void manButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + manButton.Text;
        }

        private void womanButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + womanButton.Text;
        }

        private void dogButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + dogButton.Text;
        }

        private void catButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + catButton.Text;
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + carButton.Text;
        }

        private void bicycleButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + bicycleButton.Text;
        }

        private void beautifulButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + beautifulButton.Text;
        }

        private void bigButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + bigButton.Text;
        }

        private void smallButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + smallButton.Text;
        }

        private void strangeButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + strangeButton.Text;
        }

        private void lookedAtButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + lookedAtButton.Text;
        }

        private void rodeButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + rodeButton.Text;
        }

        private void spokeToButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + spokeToButton.Text;
        }

        private void laughedAtButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + laughedAtButton.Text;
        }

        private void droveButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + droveButton.Text;
        }

        //creates 1 blank space
        private void spaceButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " ";
        }

        //Puncuation mark buttons
        private void periodButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + periodButton.Text;
        }

        private void exclamationButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + exclamationButton.Text;
        }
    }
}
