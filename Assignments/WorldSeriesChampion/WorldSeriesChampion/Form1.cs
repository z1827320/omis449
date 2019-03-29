using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSeriesChampion
{
    public partial class WorldSeries : Form
    {
        public WorldSeries()
        {
            InitializeComponent();
        }

        //Delares list for World Series Wins
        List<string> WSWins = new List<string>();

        //Read files
        private List<string> ReadFile(List<string> s)
        {
            OpenFileDialog OpenFile = new OpenFileDialog
            {
                Filter = "TXT|*.txt"
            };

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                s = System.IO.File.ReadAllLines(OpenFile.FileName).ToList();
            }

            else
                MessageBox.Show("Something went wrong.");

            MessageBox.Show("File Loaded Successfully.");

            return s;
        }

        //Sums number of appearences of a string and sum
        private void WSWinners(string T, List<string> W)
        {
            int Wins = 0;

            foreach (string Line in W)
            {
                if (Line == T)
                    Wins++;
            }

            if (TeamBox.SelectedIndex != -1)
            {
                lblTeam.Text = T.ToString();
            }
            
            lblWin.Text = Wins.ToString();
        }

        //Button Space
        private void btnLoad_Click(object sender, EventArgs e)
        {
            WSWins = ReadFile(WSWins);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                String Team = TeamBox.SelectedItem.ToString();

                WSWinners(Team, WSWins);
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex + "Please select a team.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorldSeries_Load_1(object sender, EventArgs e)
        {
            List<string> Teams = new List<string>();

            Teams = ReadFile(Teams);

            foreach (string s in Teams)
            {
                TeamBox.Items.Add(s);
            }
        }
    }
}
