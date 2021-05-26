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
    public partial class frmOMeniInstruktor : Form
    {
        Instruktor postojeciInstruktor = null;

        public frmOMeniInstruktor(Instruktor instruktor)
        {
            InitializeComponent();
            postojeciInstruktor = instruktor;
        }

        private void frmOMeniInstruktor_Load(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = postojeciInstruktor.KorisnickoIme;
            txtIme.Text = postojeciInstruktor.Ime;
            txtPrezime.Text = postojeciInstruktor.Prezime;
            txtEmail.Text = postojeciInstruktor.Email;
            txtMobitel.Text = postojeciInstruktor.Mobitel;
            txtMjesto.Text = postojeciInstruktor.Mjesto;
            txtUlica.Text = postojeciInstruktor.Ulica;
            txtOpis.Text = postojeciInstruktor.Opis;
            txtTitula.Text = postojeciInstruktor.Titula;
        }
    }
}
