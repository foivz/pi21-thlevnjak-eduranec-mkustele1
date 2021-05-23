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

namespace FindAndLearn.Prijava
{
    public partial class frmPromjenaLozinke : Form
    {
        public frmPromjenaLozinke()
        {
            InitializeComponent();
        }

        private void frmPromjenaLozinke_Load(object sender, EventArgs e)
        {

        }

        private void cbPokaziLozinke_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTrenutnaLozinka.PasswordChar == '*' || txtNovaLozinka.PasswordChar == '*' || txtPonovljenaLozinka.PasswordChar == '*')
            {

                txtTrenutnaLozinka.PasswordChar = '\0';
                txtNovaLozinka.PasswordChar = '\0';
                txtPonovljenaLozinka.PasswordChar = '\0';
            }
            else
            {
                txtTrenutnaLozinka.PasswordChar = '*';
                txtNovaLozinka.PasswordChar = '*';
                txtPonovljenaLozinka.PasswordChar = '*';
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
            Hide();
        }
    }
}
