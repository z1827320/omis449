using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orionConstellation
{
    public partial class OrionConstellation : Form
    {
        public OrionConstellation()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblBetelgeuse.Visible = true;
            lblMeissa.Visible = true;
            lblAlnitak.Visible = true;
            lblAlnilam.Visible = true;
            lblMintaka.Visible = true;
            lblSaiph.Visible = true;
            lblRigel.Visible = true;
            //Shows the stars names
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            lblBetelgeuse.Visible = false;
            lblMeissa.Visible = false;
            lblAlnitak.Visible = false;
            lblAlnilam.Visible = false;
            lblMintaka.Visible = false;
            lblSaiph.Visible = false;
            lblRigel.Visible = false;
            //Hides the stars names
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Closes the program
        }
    }
}
