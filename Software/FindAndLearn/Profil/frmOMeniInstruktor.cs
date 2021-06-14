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
            cbZadanaSlika.CheckedChanged += CbZadanaSlika_CheckedChanged;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmOMeniInstruktor_KeyDown);
        }

        private void frmOMeniInstruktor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Instruktor/Profil/Izmijeni_podatke/index.html");
            }
        }

        private void CbZadanaSlika_CheckedChanged(object sender, EventArgs e)
        {
            if (cbZadanaSlika.Checked == true)
            {
                pbSlikaInstruktora.Image = FindAndLearn.Properties.Resources.Instruktor;
            }
            else
            {
                pbSlikaInstruktora.Image = null;
            }
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
            bool postojiKorisnik = true;
            bool ispravanUnos = false;

            try
            {
                postojiKorisnik = false;

                ispravanUnos = Autentifikator.ProvjeriUnosProfil(txtIme.Text, txtPrezime.Text, txtKorisnickoIme.Text, txtEmail.Text, txtMobitel.Text);

                if (ispravanUnos == true && postojeciInstruktor.KorisnickoIme != txtKorisnickoIme.Text)
                {
                    postojiKorisnik = Autentifikator.ProvjeriKorisnickoIme(txtKorisnickoIme.Text);
                }

                Close();
            }
            catch (UnosException ex)
            {
                MessageBox.Show(ex.Poruka);
                postojiKorisnik = true;
            }

            if (postojiKorisnik == false)
            {
                postojeciInstruktor.Ime = txtIme.Text;
                postojeciInstruktor.Prezime = txtPrezime.Text;
                postojeciInstruktor.KorisnickoIme = txtKorisnickoIme.Text;
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

        private void btnUkloniSliku_Click(object sender, EventArgs e)
        {
            pbSlikaInstruktora.Image = null;
            cbZadanaSlika.Checked = false;
        }
    }
}
