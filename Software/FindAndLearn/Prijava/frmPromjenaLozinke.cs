using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindAndLearn.Iznimke;
using FindAndLearn.Klase;
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

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text;
            string trenutnaLozinka = txtTrenutnaLozinka.Text;
            string novaLozinka = txtNovaLozinka.Text;
            string ponovljenaLozinka = txtPonovljenaLozinka.Text;

            bool ispravnaLozinka = false;
            Korisnik korisnikPrijava = null;

            //Uz provjeru prijave postojećeg korisnika provjerava se podudaranje unosa nove i ponovljene lozinke

            try
            {
                korisnikPrijava = Autentifikator.Prijava(korisnickoIme, trenutnaLozinka);
                ispravnaLozinka = Autentifikator.ProvjeriPromjenuLozinke(trenutnaLozinka, novaLozinka, ponovljenaLozinka);
            }
            catch (UnosException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            if (korisnikPrijava != null && ispravnaLozinka == true)
            {
                korisnikPrijava.Lozinka = novaLozinka;
                RepozitorijKorisnika.AzurirajKorisnika(korisnikPrijava);
                MessageBox.Show("Lozinka je uspješno promijenjena!");
            }
        }
    }
}
