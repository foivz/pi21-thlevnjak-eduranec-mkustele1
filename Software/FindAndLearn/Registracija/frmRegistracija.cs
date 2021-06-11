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

namespace FindAndLearn.Registracija
{
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            comboUloga.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUloga.DataSource = Enum.GetValues(typeof(Uloga)).Cast<Uloga>().ToList();
            cbKoristiGeneriranoKorisnickoIme.Checked = true;
            txtKorisnickoIme.Enabled = false;
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Uloga uloga = (Uloga)comboUloga.SelectedItem;
            string ime = txtIme.Text;
            string titula = txtTitula.Text;
            string prezime = txtPrezime.Text;
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            string ponovljenaLozinka = txtPonovljenaLozinka.Text;
            string email = txtEmail.Text;
            string mobitel = txtMobitel.Text;
            string mjesto = txtMjesto.Text;
            string ulica = txtUlica.Text;
            string opis = txtOpis.Text;

            Korisnik korisnikRegistracija = null;

            try
            {
                korisnikRegistracija = Autentifikator.Registracija(uloga, ime, prezime, korisnickoIme, lozinka, ponovljenaLozinka, email, mobitel, mjesto, ulica, opis, titula);
            }
            catch (UnosException ex)
            {
                MessageBox.Show(ex.Poruka, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (korisnikRegistracija != null)
            {
                MessageBox.Show($"Registracija uspješna! Dodan je novi {uloga.ToString().ToLower()}", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
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

        private void cbPokaziPonovljenuLozinku_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPonovljenaLozinka.PasswordChar == '*')
            {
                txtPonovljenaLozinka.PasswordChar = '\0';
            }
            else
            {
                txtPonovljenaLozinka.PasswordChar = '*';
            }
        }

        private void cbKoristiGeneriranoKorisnickoIme_CheckedChanged(object sender, EventArgs e)
        {
            bool postojiKorisnik = false;
            if (cbKoristiGeneriranoKorisnickoIme.Checked == true)
            {
                txtKorisnickoIme.Enabled = false;
                txtKorisnickoIme.Text = txtIme.Text[0].ToString().ToLower() + txtPrezime.Text.ToString().ToLower();
                try
                {
                    postojiKorisnik = Autentifikator.ProvjeriKorisnickoIme(txtKorisnickoIme.Text.ToString());
                }
                catch
                {
                    Random r = new Random();
                    txtKorisnickoIme.Text += r.Next(0, 9);
                }
            }
            else
            {
                txtKorisnickoIme.Enabled = true;
                txtKorisnickoIme.Text = "";
            }
        }

        private void txtPrezime_KeyUp(object sender, KeyEventArgs e)
        {
            bool postojiKorisnik = false;
            
            try
            {
                txtKorisnickoIme.Text = txtIme.Text[0].ToString().ToLower() + txtPrezime.Text.ToString().ToLower();
                postojiKorisnik = Autentifikator.ProvjeriKorisnickoIme(txtKorisnickoIme.Text.ToString());
            }
            catch
            {
                Random r = new Random();
                txtKorisnickoIme.Text += r.Next(0, 9);
            }
        }

        private void comboUloga_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((Uloga)comboUloga.SelectedItem == Uloga.Instruktor)
            {
                txtTitula.Enabled = true;
            }
            else
            {
                txtTitula.Enabled = false;
                txtTitula.Text = "Samo instruktor bira titulu!";
            }
        }
    }
}
