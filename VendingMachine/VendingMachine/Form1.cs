using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    struct Drinks
    {
        public string Name;
        public double Price;
        public int Amount;
        public double SubTotal;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalFTotal()
        {
            double t;
            t = Soda[Cola].SubTotal + Soda[Root].SubTotal + Soda[Lime].SubTotal +
                Soda[Grape].SubTotal + Soda[Cream].SubTotal;
            lblTotal.Text = t.ToString("c");
        }

        private double CalSubTotal (double a, double p)
        {
            a = (20 - a) * p;

            return a;
        }

        private int SodaBuy(int a)
        {
            if (a <= 0)
            {
                MessageBox.Show("Sorry, that soda is unavalible.");
                return a;
            }

            else
            {
                a -= 1;
                return a;
            }
        }

        Drinks[] Soda = new Drinks[5];
        int Cola = 0;
        int Root = 1;
        int Lime = 2;
        int Grape = 3;
        int Cream = 4;
        double Total = 0.00;

        private void pbCola_Click(object sender, EventArgs e)
        {
            Soda[Cola].Amount = SodaBuy(Soda[Cola].Amount);
            lblCola.Text = Soda[Cola].Amount.ToString();

            Soda[Cola].SubTotal = CalSubTotal(Soda[Cola].Amount, Soda[Cola].Price);

            CalFTotal();
        }

        private void pbRoot_Click(object sender, EventArgs e)
        {
            Soda[Root].Amount = SodaBuy(Soda[Root].Amount);
            lblRB.Text = Soda[Root].Amount.ToString();

            Soda[Root].SubTotal = CalSubTotal(Soda[Root].Amount, Soda[Root].Price);

            CalFTotal();
        }

        private void pbLime_Click(object sender, EventArgs e)
        {
            Soda[Lime].Amount = SodaBuy(Soda[Lime].Amount);
            lblLL.Text = Soda[Lime].Amount.ToString();

            Soda[Lime].SubTotal = CalSubTotal(Soda[Lime].Amount, Soda[Lime].Price);

            CalFTotal();
        }

        private void pbGrape_Click(object sender, EventArgs e)
        {
            Soda[Grape].Amount = SodaBuy(Soda[Grape].Amount);
            lblG.Text = Soda[Grape].Amount.ToString();

            Soda[Grape].SubTotal = CalSubTotal(Soda[Grape].Amount, Soda[Grape].Price);

            CalFTotal();
        }

        private void pbCream_Click(object sender, EventArgs e)
        {
            Soda[Cream].Amount = SodaBuy(Soda[Cream].Amount);
            lblCS.Text = Soda[Cream].Amount.ToString();

            Soda[Cream].SubTotal = CalSubTotal(Soda[Cream].Amount, Soda[Cream].Price);

            CalFTotal();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Soda[Cola].Name = "Cola";
            Soda[Cola].Price = 1.00;
            Soda[Cola].Amount = 20;
            Soda[Cola].SubTotal = 0.00;
            Soda[Root].Name = "Root Beer";
            Soda[Root].Price = 1.00;
            Soda[Root].Amount = 20;
            Soda[Root].SubTotal = 0.00;
            Soda[Lime].Name = "Lemon Lime";
            Soda[Lime].Price = 1.00;
            Soda[Lime].Amount = 20;
            Soda[Lime].SubTotal = 0.00;
            Soda[Grape].Name = "Grape";
            Soda[Grape].Price = 1.50;
            Soda[Grape].Amount = 20;
            Soda[Grape].SubTotal = 0.00;
            Soda[Cream].Name = "Cream Soda";
            Soda[Cream].Price = 1.50;
            Soda[Cream].Amount = 20;
            Soda[Cream].SubTotal = 0.00;

            lblCola.Text = Soda[Cola].Amount.ToString();
            lblColaPrice.Text = Soda[Cola].Price.ToString("c");

            lblRB.Text = Soda[Root].Amount.ToString();
            lblRPrice.Text = Soda[Root].Price.ToString("c");

            lblLL.Text = Soda[Lime].Amount.ToString();
            lblLPrice.Text = Soda[Lime].Price.ToString("c");

            lblG.Text = Soda[Grape].Amount.ToString();
            lblGPrice.Text = Soda[Grape].Price.ToString("c");

            lblCS.Text = Soda[Cream].Amount.ToString();
            lblCPrice.Text = Soda[Cream].Price.ToString("c");

            lblTotal.Text = Total.ToString("c");
        }
    }
}
