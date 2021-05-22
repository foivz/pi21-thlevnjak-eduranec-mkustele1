using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAndLearn.Prijava
{
    public partial class frmPromjenaLozinke : Form
    {
        public frmPromjenaLozinke()
        {
            InitializeComponent();
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
    }
}
