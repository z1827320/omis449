using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSearchProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //list for namespace
        List<string> BoyNames = new List<string>();
        List<string> GirlNames = new List<string>();

        //reading files into list
        private List<string> LoadFiles(List<string> s)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "TXT|*.txt";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                s = File.ReadAllLines(OpenFile.FileName).ToList();
            }

            return s;
        }

        //Button space
        private void btnBoy_Click(object sender, EventArgs e)
        {
            BoyNames = LoadFiles(BoyNames);
        }

        private void btnGirl_Click(object sender, EventArgs e)
        {
            GirlNames = LoadFiles(GirlNames);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Run a check for boys
            foreach (string Name in BoyNames)
            {
                try
                {
                    if (BoyNames.Contains(tbBoy.Text))
                    {
                        tbBoyOut.Text = tbBoy.Text + " is amongst the most popular boy names.";
                    }

                    else if (tbBoy.Text == String.Empty)
                        tbBoyOut.Text = String.Empty;

                    else
                        tbBoyOut.Text = tbBoy.Text + " is not amongst the most popular boy names.";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("There was an Error: " + ex);
                }

            }

            //Run a check for girls
            foreach (string Name in GirlNames)
            {
                try
                {
                    if (GirlNames.Contains(tbGirl.Text))
                    {
                        tbGirlOut.Text = tbGirl.Text + " is amongst the most popular girl names.";
                    }

                    else if (tbGirl.Text == String.Empty)
                        tbGirlOut.Text = String.Empty;

                    else
                        tbGirlOut.Text = tbGirl.Text + " is not amonst the most popular girl names.";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("There was an Error: " + ex);
                }
            }
        }
    }
}
