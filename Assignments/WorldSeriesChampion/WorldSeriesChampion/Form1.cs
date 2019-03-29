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

        //Dexlares list for World Series Wins
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

            if (TeamBox.Text).SelectedIndex != -1)
            {
                lblTeam.Text = T.ToString();
            }

            lblWins.Text = Wins.ToString();
        }

        //load team file on load
        private void WorldSeries_Load(object sender, EventArgs e)
        {
            List<string> Teams = new List<string>();

            Teams = ReadFile(Teams);

            foreach (string s in Teams)
            {
                TeamBox.Items.Add(s);
            }
        }

        //Button Space
        private void btnLoad_Click(object sender, EventArgs e)
        {
            WSWins = ReadFile(WSWins);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            String Team = TeamBox.SelectedItem.ToString();

            WSWinners(Team, WSWins);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
