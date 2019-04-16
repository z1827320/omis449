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

namespace EmailAddressProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<PersonEntry> Entries = new List<PersonEntry>();

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader File = new StreamReader("EmailList.txt");

            string s;

            string name = "";
            string email = "";
            string phone = "";
            int i;

            while ((s = File.ReadLine()) != null)
            {
                i = 0;

                char delim = ',';

                string[] Lines = s.Split(delim);

                foreach (var substring in Lines)
                {
                    if (i == 0)
                    {
                        name = substring;
                    }

                    else if (i == 1)
                    {
                        email = substring;
                    }

                    else
                    {
                        phone = substring;
                    }

                    i = i + 1;
                }

                PersonEntry Person = new PersonEntry(name, email, phone);
                Entries.Add(Person);

                lbPeople.Items.Add(name);
            }
        }

        private void LbPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbPeople.SelectedIndex;

            MoreDetails AdditionalInfo = new MoreDetails();

            AdditionalInfo.lblName.Text = Entries[index].Name.ToString();
            AdditionalInfo.lblEmail.Text = Entries[index].Email.ToString();
            AdditionalInfo.lblPhone.Text = Entries[index].Phone.ToString();

            AdditionalInfo.Show();
        }
    }
}
