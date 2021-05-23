using FindAndLearn.Prijava;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KorisniciLib;

namespace FindAndLearn
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {

        }

        private void llblPromjenaLozinke_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPromjenaLozinke form = new frmPromjenaLozinke();
            form.ShowDialog();
            Close();
        }

        private void cbPokaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            if (txtLozinka.PasswordChar == '*')
            {

                txtLozinka.PasswordChar = '\0';
            }
            else
            {
                txtLozinka.PasswordChar = '*';
            }
        }
    }
}
