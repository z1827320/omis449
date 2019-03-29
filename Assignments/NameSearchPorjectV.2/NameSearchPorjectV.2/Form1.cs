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

namespace NameSearchPorjectV._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //list for name space
        List<string> BoyNames = new List<string>();
        List<string> GirlNames = new List<string>();

        //reading files into the list
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
        private void btnBoyL_Click(object sender, EventArgs e)
        {
            BoyNames = LoadFiles(BoyNames);
        }

        private void btnGirlL_Click(object sender, EventArgs e)
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
                    if (BoyNames.Contains(tbBoyIn.Text))
                    {
                        tbBoyOutput.Text = tbBoyIn.Text + " is amongst the most popular boy names.";
                    }

                    else if (tbBoyIn.Text == String.Empty)
                        tbBoyOutput.Text = String.Empty;

                    else
                        tbBoyOutput.Text = tbBoyIn.Text + " is not amongst the most popular boy names.";
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
                    if (GirlNames.Contains(tbGirlIn.Text))
                    {
                        tbGirlOutput.Text = tbGirlIn.Text + " is amongst the most popular girl names.";
                    }

                    else if (tbGirlIn.Text == String.Empty)
                        tbGirlOutput.Text = String.Empty;

                    else
                        tbGirlOutput.Text = tbGirlIn.Text + " is not amonst the most popular girl names.";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("There was an Error: " + ex);
                }
            }
        }
    }
}
