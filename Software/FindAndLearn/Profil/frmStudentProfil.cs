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
            comboKolegiji.SelectedIndexChanged += ComboKolegiji_SelectedIndexChanged;
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

        }

        // Ovisno o odabranom kolegiju prikazuju se kontakt podaci o instruktoru radi lakšeg kontaktiranja instruktora i podaci o terminu

        private void ComboKolegiji_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instruktori instruktorBaza = null;

            foreach (var instrukcije in instrukcijeStudenta)
            {
                instruktorBaza = DohvatiInstruktoraZaKolegij(instrukcije);

                if (instruktorBaza != null)
                {
                    // Dohvaćanje entitetne klase Instuktor kako bi se mogla prikazati slika tipa Image i ostali podaci o instruktoru

                    Instruktor instruktor = RepozitorijKorisnika.DohvatiKorisnika(instruktorBaza.korisnicko_ime, instruktorBaza.lozinka) as Instruktor;

                    pbSlikaInstruktora.Image = instruktor.Slika;
                    lblImeInstruktora.Text = instruktor.Ime + " " + instruktor.Prezime;
                    lblEmailInstruktor.Text = instruktor.Email;
                    lblMobitelInstruktora.Text = instruktor.Mobitel;

                    // Dohvaćanje podataka o terminu instrukcija vezanih uz odabrani kolegij i pretvorba prikaza datuma po danu i mjesecu

                    Termini terminBaza = DohvatiTerminInstrukcija(instrukcije);

                    string[] datum = terminBaza.vrijeme_termina.ToString().Split('.');

                    lblDan.Text = datum[0];
                    lblMjesec.Text = datum[1];
                    lblNazivTermina.Text = terminBaza.naziv_termina;
                    lblMjestoOdrzavanja.Text = terminBaza.mjesto_odrzavanja;
                }
            }
        }



      private Instruktori DohvatiInstruktoraZaKolegij(Instrukcije instrukcije)
      {
           using (var context = new Entities())
           {
                Kolegiji kolegijBaza = comboKolegiji.SelectedItem as Kolegiji;

                var upitInstruktor = from ins in context.Instruktori
                                       where ins.ID_instruktora == instrukcije.instruktor_id && instrukcije.kolegij_id == kolegijBaza.ID_kolegija
                                      select ins;

                  return upitInstruktor.Single();
           }
       }

       public Termini DohvatiTerminInstrukcija(Instrukcije instrukcije)
       {
            using (var context = new Entities())
            {
                var upitTermin = from t in context.Termini
                                 where t.instrukcija_id == instrukcije.ID_instrukcije
                                select t;

                return upitTermin.Single();
            }
       }


        private void UcitajInstrukcije()
        {
             rezervacijeStudenta = DohvatiRezervacijeStudenta();

             instrukcijeStudenta = new List<Instrukcije>();

             foreach (var item in rezervacijeStudenta)
             {
                 instrukcijeStudenta.Add(DohvatiInstrukcijuStudenta(item));
             }

             // Putem dohvaćenih studentovih instrukcija dolazi se do kolegija

             foreach (var instrukcije in instrukcijeStudenta)
             {
                  comboKolegiji.Items.Add(DohvatiKolegijStudenta(instrukcije));
             }
        }

        public List<Rezervacije> DohvatiRezervacijeStudenta()
        {
            using (var context = new Entities())
            {
                Studenti studentBaza = context.Studenti.FirstOrDefault(k => k.korisnicko_ime == postojeciStudent.KorisnickoIme);

                var upitRezervacije = from r in context.Rezervacije
                                      where r.student_ID == studentBaza.ID_studenta && r.potvrdjena == true
                                      select r;

                return upitRezervacije.ToList();
            }
        }

       // Rezervirani termin se odnosi na samo 1 instrukciju tako se dohvaćanjem termina studenta dolazi do studentovih instrukcija

        public Instrukcije DohvatiInstrukcijuStudenta(Rezervacije rezervacija)
        {

            using (var context = new Entities())
            {
                var upitInstrukcije = from t in context.Termini
                                      where t.ID_termina == rezervacija.termin_ID
                                      select t.Instrukcije;

                return upitInstrukcije.Single();
            }
        }

        public Kolegiji DohvatiKolegijStudenta (Instrukcije instrukcija)
        {
           using (var context = new Entities())
           {
              var upitKolegiji = from k in context.Kolegiji
                                 where k.ID_kolegija == instrukcija.kolegij_id
                                 select k;

             return upitKolegiji.Single();
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
