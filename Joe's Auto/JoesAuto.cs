using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class joesautomotive : Form
    {
        public joesautomotive()
        {
            InitializeComponent();
        }

        //to clear the program
        private void ClearOilLube()
        {
            cbOil.Checked = false;
            cbLube.Checked = false;
        }

        private void ClearFlushes()
        {
            cbRflush.Checked = false;
            cbTflush.Checked = false;
        }

        private void ClearMisc()
        {
            cbMuffler.Checked = false;
            cbInspec.Checked = false;
            cbTire.Checked = false;
        }

        private void ClearOther()
        {
            tbPart1.Text = String.Empty;
            tbLabor1.Text = String.Empty;
        }

        private void ClearSummary()
        {
            tbSandL.Text = String.Empty;
            tbParts2.Text = String.Empty;
            tbTax.Text = String.Empty;
            tbTotal.Text = String.Empty;
        }

        //Doing calculation
        private decimal OilLubeCharges(decimal c)
        {
            if (cbOil.Checked == true)
            {
                c += 26;
            }

            if (cbLube.Checked == true)
            {
                c += 18;
            }

            return c;
        }

        private decimal FlushCharges(decimal c)
        {
            if (cbRflush.Checked == true)
            {
                c += 30;
            }

            if (cbTflush.Checked == true)
            {
                c += 80;
            }

            return c;
        }

        private decimal MiscCharges(decimal c)
        {
            if (cbInspec.Checked == true)
            {
                c += 15;
            }

            if (cbMuffler.Checked == true)
            {
                c += 100;
            }

            if (cbTire.Checked == true)
            {
                c += 20;
            }

            return c;
        }

        private decimal OtherCharges(decimal c)
        {
            if (decimal.TryParse(tbPart1.Text, out decimal parts) || tbPart1.Text == String.Empty)
            {
                c += parts;
            }

            else
            {
                MessageBox.Show("Please enter a vaild number for Parts.");
            }

            if (decimal.TryParse(tbLabor1.Text, out decimal labor) || tbLabor1.Text == String.Empty)
            {
                c += labor;
            }

            else
            {
                MessageBox.Show("Please enter a valid number for Labor.");
            }

            return c;
        }

        private decimal TaxCharges(decimal c)
        {
            if (decimal.TryParse(tbPart1.Text, out decimal tax))
            {
                c = tax * 0.06m;
            }

            return c;
        }

        private decimal TotalCharges(decimal s,decimal p, decimal t)
        {
            decimal c;

            c = s + p + t;

            return c;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal oilLubeTotal = 0m;
            decimal flushTotal = 0m;
            decimal miscTotal = 0m;
            decimal laborTotal = 0m;
            decimal partsTotal = 0m;
            decimal taxTotal = 0m;
            decimal servAndLabor = 0m;

            if (decimal.TryParse(tbPart1.Text, out decimal parts) || tbPart1.Text == String.Empty) 
            {
                partsTotal = parts;
            }

            else
            {
                MessageBox.Show("Please enter a valid number for Parts.");
            }

            if (decimal.TryParse(tbLabor1.Text, out decimal labor) || tbLabor1.Text == String.Empty)
            {
                laborTotal = labor;
            }

            else
            {
                MessageBox.Show("Please enter a valid number for Labor.");
            }

            servAndLabor = (OilLubeCharges(oilLubeTotal) + FlushCharges(flushTotal) + MiscCharges(miscTotal) + laborTotal);
            tbSandL.Text = servAndLabor.ToString("c");

            tbParts2.Text = parts.ToString("c");

            taxTotal = TaxCharges(parts);
            tbTax.Text = taxTotal.ToString("c");

            tbTotal.Text = (TotalCharges(servAndLabor, parts, taxTotal)).ToString("c");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearSummary();
        }
    }
}
