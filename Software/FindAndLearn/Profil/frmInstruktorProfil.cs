using KorisniciLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAndLearn.Profil
{
    public partial class frmInstruktorProfil : Form
    {
        Instruktor postojeciInstruktor = null;

        public frmInstruktorProfil(Instruktor instruktor)
        {
            InitializeComponent();
            postojeciInstruktor = instruktor;
            OsvjeziProfil();
        }

        private void OsvjeziProfil()
        {
            if (postojeciInstruktor != null)
            {
                lblImePrezime.Text = postojeciInstruktor.Ime + " " + postojeciInstruktor.Prezime;
                lblEmail.Text = postojeciInstruktor.Email;
                lblMobitel.Text = postojeciInstruktor.Mobitel;
                lblMjesto.Text = postojeciInstruktor.Mjesto;
                lblUlica.Text = postojeciInstruktor.Ulica;
                lblTitula.Text = postojeciInstruktor.Titula;
                txtOpis.Text = postojeciInstruktor.Opis;
               // pbSlikaInstruktora.Image = postojeciInstruktor.Slika;
            }
        }

        private void frmInstruktorProfil_Load(object sender, EventArgs e)
        {

        }

        private void btnIzmijeniPodatke_Click(object sender, EventArgs e)
        {
            frmOMeniInstruktor form = new frmOMeniInstruktor(postojeciInstruktor);
            form.ShowDialog();
            OsvjeziProfil();
        }
    }
}
