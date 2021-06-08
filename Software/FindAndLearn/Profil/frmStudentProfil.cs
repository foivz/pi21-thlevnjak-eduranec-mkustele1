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
            instrukcijeStudenta = UcitajInstrukcije();
            UcitajTipoveInstrukcija();
            comboTipInstrukcije.SelectedIndexChanged += ComboTipInstrukcije_SelectedIndexChanged;
            comboKolegiji.SelectedIndexChanged += ComboKolegiji_SelectedIndexChanged;
            OsvjeziProfil();
        }

        private void ComboTipInstrukcije_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipInstrukcije selektiraniTip = comboTipInstrukcije.SelectedItem as TipInstrukcije;
            List<Kolegij> listaKolegija = RepozitorijInstrukcija.PopuniPopisKolegija();
            List<Kolegij> kolegijiZaTip = new List<Kolegij>();

            foreach (var instrukcije in instrukcijeStudenta)
            {
                if(instrukcije.tip_instrukcije_id == selektiraniTip.Id)
                {
                    Kolegij kolegij = listaKolegija.Find(x => x.Id == instrukcije.kolegij_id);
                    kolegijiZaTip.Add(kolegij);
                }
            }

            comboKolegiji.DataSource = null;
            comboKolegiji.DataSource = kolegijiZaTip.ToList();
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
            Kolegij kolegij = comboKolegiji.SelectedItem as Kolegij;

            foreach (var instrukcije in instrukcijeStudenta)
            {
                if (kolegij != null)
                {
                    PrikaziInstruktoraZaKolegij(instrukcije, kolegij);
                    PokaziTerminInstrukcija(instrukcije);
                }
             }
        }



      private void PrikaziInstruktoraZaKolegij(Instrukcije instrukcije, Kolegij kolegij)
      {
           Instruktori instruktorBaza = null;

           using (var context = new Entities())
           {
                var upitInstruktor =   from ins in context.Instruktori
                                       where ins.ID_instruktora == instrukcije.instruktor_id && instrukcije.kolegij_id == kolegij.Id
                                       select ins;

                instruktorBaza = upitInstruktor.Single();
            }

            if (instruktorBaza != null)
            {
                // Dohvaćanje entitetne klase Instuktor kako bi se mogla prikazati slika tipa Image i ostali podaci o instruktoru

                Instruktor instruktor = RepozitorijKorisnika.DohvatiKorisnika(instruktorBaza.korisnicko_ime, instruktorBaza.lozinka) as Instruktor;

                pbSlikaInstruktora.Image = instruktor.Slika;
                lblImeInstruktora.Text = instruktor.Ime + " " + instruktor.Prezime;
                lblEmailInstruktor.Text = instruktor.Email;
                lblMobitelInstruktora.Text = instruktor.Mobitel;
             }
       }

        // Prikaz podataka o terminu instrukcija vezanih uz odabrani kolegij i pretvorba prikaza datuma po danu i mjesecu

        public void PokaziTerminInstrukcija (Instrukcije instrukcije)
       {
            Termini termin = null;

            foreach (var rezervacije in rezervacijeStudenta)
            {
                using (var context = new Entities())
                {
                    var upitTermin = from t in context.Termini
                                     where t.instrukcija_id == instrukcije.ID_instrukcije && t.ID_termina == rezervacije.termin_ID
                                     select t;

                    termin = upitTermin.Single();
                }
            }

            string[] datum = termin.vrijeme_termina.ToString().Split('.');

            lblDan.Text = datum[0];
            lblMjesec.Text = datum[1];
            lblNazivTermina.Text = termin.naziv_termina;
            lblMjestoOdrzavanja.Text = termin.mjesto_odrzavanja;
        }


        private List<Instrukcije> UcitajInstrukcije()
        {
            comboTipInstrukcije.DataSource = null;
            rezervacijeStudenta = DohvatiRezervacijeStudenta();

            instrukcijeStudenta = new List<Instrukcije>();

            foreach (var item in rezervacijeStudenta)
            {
                instrukcijeStudenta.Add(DohvatiInstrukcijuStudenta(item));
            }

            return instrukcijeStudenta;
        }

        public void UcitajTipoveInstrukcija()
        {
            foreach (var instrukcije in instrukcijeStudenta)
            {
                 List<TipInstrukcije> listaTipova = RepozitorijInstrukcija.PopuniPopisTipovaInstrukcija();
                 TipInstrukcije tipInstrukcije = listaTipova.Find(x => x.Id == instrukcije.tip_instrukcije_id);

                 comboTipInstrukcije.Items.Add(tipInstrukcije);
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

        public List<Kolegij> DohvatiKolegijStudenta (TipInstrukcije tip)
        {
           List<Kolegij> listaKolegija = RepozitorijInstrukcija.PopuniPopisKolegija();

           foreach (var instrukcije in instrukcijeStudenta)
           {
                Kolegij kolegij = listaKolegija.Find(x => x.Id == instrukcije.kolegij_id && instrukcije.tip_instrukcije_id == tip.Id);
                listaKolegija.Add(kolegij);
           }

           return listaKolegija;
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
