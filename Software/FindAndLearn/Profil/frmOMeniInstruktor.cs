using FindAndLearn.Iznimke;
using FindAndLearn.Klase;
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
            pbSlikaInstruktora.Image = postojeciInstruktor.Slika;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                Image slika = Image.FromFile(openPictureDialog.FileName);
                pbSlikaInstruktora.Image = slika;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            // Samo u slučaju mijenjanja korisničkog imena potrebno je provjeriti je li izmijenjeno korisničko ime zauzeto.

            string staroKorisnickoIme = postojeciInstruktor.KorisnickoIme;
            bool postojiKorisnik;

            try
            {
                postojiKorisnik = false;

                if (postojeciInstruktor.KorisnickoIme != txtKorisnickoIme.Text)
                {
                    Autentifikator.ProvjeriKorisnickoIme(txtKorisnickoIme.Text);
                }
                Close();
            }
            catch (UnosException ex)
            {
                MessageBox.Show(ex.Poruka);
                postojiKorisnik = true;
            }

            if(postojiKorisnik == false)
            {
                postojeciInstruktor.KorisnickoIme = txtKorisnickoIme.Text;
            }

            postojeciInstruktor.Ime = txtIme.Text;
            postojeciInstruktor.Prezime = txtPrezime.Text;
            postojeciInstruktor.Email = txtEmail.Text;
            postojeciInstruktor.Mobitel = txtMobitel.Text;
            postojeciInstruktor.Mjesto = txtMjesto.Text;
            postojeciInstruktor.Ulica = txtUlica.Text;
            postojeciInstruktor.Opis = txtOpis.Text;
            postojeciInstruktor.Titula = txtTitula.Text;
            postojeciInstruktor.Slika = pbSlikaInstruktora.Image;

            RepozitorijKorisnika.AzurirajInstruktora(postojeciInstruktor, staroKorisnickoIme);

        }
    }
}
