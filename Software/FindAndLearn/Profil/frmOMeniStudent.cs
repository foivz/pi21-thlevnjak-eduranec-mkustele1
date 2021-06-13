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
    public partial class frmOMeniStudent : Form
    {
        Student postojeciStudent = null;
        public frmOMeniStudent(Student student)
        {
            InitializeComponent();
            postojeciStudent = student;
        }

        private void frmOMeniStudent_Load(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = postojeciStudent.KorisnickoIme;
            txtIme.Text = postojeciStudent.Ime;
            txtPrezime.Text = postojeciStudent.Prezime;
            txtEmail.Text = postojeciStudent.Email;
            txtMobitel.Text = postojeciStudent.Mobitel;
            txtMjesto.Text = postojeciStudent.Mjesto;
            txtUlica.Text = postojeciStudent.Ulica;
            txtOpis.Text = postojeciStudent.Opis;
            pbSlikaStudenta.Image = postojeciStudent.Slika;
            cbZadanaSlika.CheckedChanged += CbZadanaSlika_CheckedChanged;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmOMeniStudent_KeyDown);
        }

        private void frmOMeniStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, "AppHelp.chm", HelpNavigator.Topic, "Student/Profil/index.html");
            }
        }

        private void CbZadanaSlika_CheckedChanged(object sender, EventArgs e)
        {
            if (cbZadanaSlika.Checked == true)
            {
                pbSlikaStudenta.Image = FindAndLearn.Properties.Resources.student;
            }
            else
            {
                pbSlikaStudenta.Image = null;
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
                pbSlikaStudenta.Image = slika;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string staroKorisnickoIme = postojeciStudent.KorisnickoIme;
            bool postojiKorisnik = true;
            bool ispravanUnos = false;

            try
            {
                postojiKorisnik = false;

                ispravanUnos = Autentifikator.ProvjeriUnosProfil(txtIme.Text, txtPrezime.Text, txtKorisnickoIme.Text, txtEmail.Text, txtMobitel.Text);

                if (ispravanUnos == true && postojeciStudent.KorisnickoIme != txtKorisnickoIme.Text)
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
                postojeciStudent.Ime = txtIme.Text;
                postojeciStudent.Prezime = txtPrezime.Text;
                postojeciStudent.KorisnickoIme = txtKorisnickoIme.Text;
                postojeciStudent.Email = txtEmail.Text;
                postojeciStudent.Mobitel = txtMobitel.Text;
                postojeciStudent.Mjesto = txtMjesto.Text;
                postojeciStudent.Ulica = txtUlica.Text;
                postojeciStudent.Opis = txtOpis.Text;
                postojeciStudent.Slika = pbSlikaStudenta.Image;

                RepozitorijKorisnika.AzurirajStudenta(postojeciStudent, staroKorisnickoIme);
            }

        }

        private void btnUkloniSliku_Click(object sender, EventArgs e)
        {
            pbSlikaStudenta.Image = null;
            cbZadanaSlika.Checked = false;
        }
    }
}
