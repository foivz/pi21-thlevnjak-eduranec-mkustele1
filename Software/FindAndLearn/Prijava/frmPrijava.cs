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
using FindAndLearn.Klase;
using FindAndLearn.Iznimke;
using FindAndLearn.Registracija;

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

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmPrijava_KeyDown);
        }

        private void frmPrijava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, "AppHelp.chm", HelpNavigator.Topic, "Student/Profil/index.html");
            }
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

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            Korisnik korisnikPrijava = null;

            // Dohvaća se korisnik u slučaju da je prijava ispravna, u suprotnom se korisniku prikazuje poruka greške

            try
            {
                korisnikPrijava = Autentifikator.Prijava(korisnickoIme, lozinka);

            }
            catch (UnosException ex)
            {
                MessageBox.Show(ex.Poruka);
            }

            if (korisnikPrijava != null)
            {
                // Usporedbom atributa uloga otvara se odgovarajuća početna stranica (instruktor/student) i prosljeđuju se podaci o korisniku

                if (korisnikPrijava.Uloga == Uloga.Student)
                {
                    frmPocetnaStudent form = new frmPocetnaStudent(korisnikPrijava as Student);
                    form.ShowDialog();
                }
                else if (korisnikPrijava.Uloga == Uloga.Instruktor)
                {
                    frmPocetnaInstruktor form = new frmPocetnaInstruktor(korisnikPrijava as Instruktor);
                    form.ShowDialog();
                }
            }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            frmRegistracija formRegistracija = new frmRegistracija();
            formRegistracija.ShowDialog();
        }
    }
}
