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
    public partial class frmStudentProfil : Form
    {
        Student postojeciStudent = null;
        List<Instrukcije> instrukcijeStudenta;
        List<Rezervacije> rezervacijeStudenta;

        public frmStudentProfil(Student student)
        {
            InitializeComponent();
            postojeciStudent = student;
            UcitajInstrukcije();
            OsvjeziProfil();
        }

        private void OsvjeziProfil()
        {
            if (postojeciStudent != null)
            {
                lblImePrezime.Text = postojeciStudent.Ime + " " + postojeciStudent.Prezime;
                lblEmail.Text = postojeciStudent.Email;
                lblMobitel.Text = postojeciStudent.Mobitel;
                lblMjesto.Text = postojeciStudent.Mjesto;
                lblUlica.Text = postojeciStudent.Ulica;
                txtOpis.Text = postojeciStudent.Opis;
                pbSlikaStudenta.Image = postojeciStudent.Slika; 
            }
        }

        private void frmStudentProfil_Load(object sender, EventArgs e)
        {
            comboKolegiji.SelectedIndexChanged += ComboKolegiji_SelectedIndexChanged;
        }

        // Ovisno o odabranom kolegiju prikazuju se kontakt podaci o instruktoru radi lakšeg kontaktiranja instruktora

        private void ComboKolegiji_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instruktori instruktorBaza = null;

            foreach (var instrukcije in instrukcijeStudenta)
            {
                using (var context = new Entities())
                {
                    var upitInstruktor = from ins in context.Instruktori
                                where ins.ID_instruktora == instrukcije.instruktor_id
                                select ins;

                    instruktorBaza = upitInstruktor.Single();
                }

                if (instruktorBaza != null)
                {

                    Instruktor instruktor = RepozitorijKorisnika.DohvatiKorisnika(instruktorBaza.korisnicko_ime, instruktorBaza.lozinka) as Instruktor;

                    pbSlikaInstruktora.Image = instruktor.Slika;
                    lblImeInstruktora.Text = instruktor.Ime + " " + instruktor.Prezime;
                    lblEmailInstruktor.Text = instruktor.Email;
                    lblMobitelInstruktora.Text = instruktor.Mobitel;
                }
            }
        }


        private void UcitajInstrukcije()
        {
            using (var context = new Entities())
            {
                Studenti studentBaza = context.Studenti.FirstOrDefault(k => k.korisnicko_ime == postojeciStudent.KorisnickoIme);

               // 1. Dohvaćanja svih potvrđenih rezervacija studenata

                var upitRezervacije = from r in context.Rezervacije
                           where r.student_ID == studentBaza.ID_studenta && r.potvrdjena == true
                           select r;

                rezervacijeStudenta = upitRezervacije.ToList();

                foreach (var item in rezervacijeStudenta)
                {

               // 2. Rezervirani termin se odnosi na samo 1 instrukciju tako se dohvaćanjem termina studenta dolazi do studentovih instrukcija

                    var upitInstrukcije = from t in context.Termini
                                where t.ID_termina == item.termin_ID
                                select t.Instrukcije;

                    instrukcijeStudenta = upitInstrukcije.ToList();


               // 3. Putem dohvaćenih studentovih instrukcija dolazi se do kolegija

                    foreach (var instrukcije in instrukcijeStudenta)
                    {
                        var upitKolegiji = from k in context.Kolegiji
                                    where k.ID_kolegija == instrukcije.kolegij_id
                                    select k;

                        comboKolegiji.DataSource = upitKolegiji.ToList();
                    }
                }
            }
        }

        private void btnIzmijeniPodatke_Click(object sender, EventArgs e)
        {
            frmOMeniStudent form = new frmOMeniStudent(postojeciStudent);
            form.ShowDialog();
            OsvjeziProfil();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
            Close();
        }
    }
}
