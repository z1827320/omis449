using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalsfromFatandCarbs
{
    public partial class CarbandFatCalc : Form
    {
        public CarbandFatCalc()
        {
            InitializeComponent();
        }

        //Close the Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //does the math for the carb entry
        private string carbCalc(string c)
        {
            if (c is string && int.TryParse(c.ToString(), out int carbs))
            {
                c = (carbs *= 4).ToString();
            }

            return c;
        }
        //does the math for the fat entry
        private string fatCalc(string f)
        {
            if (f is string && int.TryParse(f.ToString(), out int fat))
            {
                f = (fat *= 9).ToString();
            }

            return f;
        }
        //calls and outputs the fat and carb calorie count
        private void btnCalc_Click(object sender, EventArgs e)
        {
            string fats;
            string carbohydrates;

            fats = fatCalc(tbFat.Text);
            carbohydrates = carbCalc(tbCarb.Text);

            tbCalFat.Text = fats;
            tbCalCarb.Text = carbohydrates;
        }
    }
}
