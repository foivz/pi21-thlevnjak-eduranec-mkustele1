using FindAndLearn.Klase;
using FindAndLearn.MojeRezervacije;
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
using VrsteKolegijaLib;

namespace FindAndLearn.Profil
{
    public partial class frmStudentProfil : Form
    {
        Student postojeciStudent = null;

        public frmStudentProfil(Student student)
        {
            InitializeComponent();
            postojeciStudent = student;
            UcitajTipoveInstrukcija();
            comboTipInstrukcije.SelectedIndexChanged += ComboTipInstrukcije_SelectedIndexChanged;
            OsvjeziProfil();
        }

        private void frmStudentProfil_Load(object sender, EventArgs e)
        {

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

        private void ComboTipInstrukcije_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajKolegijeZaTip();
        }


        // Rezervirani termin se odnosi na samo 1 instrukciju tako se dohvaćanjem termina studenta dolazi do studentovih instrukcija

        public List<Rezervacija> DohvatiRezervacijeStudenta()
        {
            List<Rezervacija> listaRezervacija = RepozitorijRezervacija.PopuniPopisRezervacija();
            List<Rezervacija> rezervacijeStudenta = new List<Rezervacija>();

            foreach (var item in listaRezervacija)
            {
                if (item.Student.KorisnickoIme == postojeciStudent.KorisnickoIme)
                {
                    rezervacijeStudenta.Add(item);
                }
            }

            return rezervacijeStudenta;
        }

        public void UcitajTipoveInstrukcija()
        {
            List<Rezervacija> listaRezervacija = RepozitorijRezervacija.PopuniPopisRezervacija();
            List<TipInstrukcije> listaTipova = new List<TipInstrukcije>();

            foreach (var item in listaRezervacija)
            {
                bool postojiTip = listaTipova.Exists(x => x.Id == item.Termin.Instrukcija.TipInstrukcije.Id);

                if (item.Student.KorisnickoIme == postojeciStudent.KorisnickoIme && postojiTip == false)
                {
                    listaTipova.Add(item.Termin.Instrukcija.TipInstrukcije);
                }
            }

            comboTipInstrukcije.DataSource = null;
            comboTipInstrukcije.DataSource = listaTipova.ToList();
        }

        public void UcitajKolegijeZaTip()
        {
            comboKolegiji.DataSource = null;
            List<Rezervacija> rezervacijeStudenta = DohvatiRezervacijeStudenta();
            TipInstrukcije selektiraniTip = comboTipInstrukcije.SelectedItem as TipInstrukcije;
            List<Kolegij> listaKolegija = new List<Kolegij>();

            foreach (var item in rezervacijeStudenta)
            {
                if (item.Termin.Instrukcija.TipInstrukcije.Id == selektiraniTip.Id)
                {
                    listaKolegija.Add(item.Termin.Instrukcija.Kolegij);
                }
            }

            comboKolegiji.DataSource = listaKolegija;
        }

        // Dohvaćanje entitetne klase Instuktor kako bi se mogla prikazati slika tipa Image i ostali podaci o instruktoru

        private void PrikaziInstruktoraZaKolegij(Instruktor instruktor)
        {
            if (instruktor != null)
            {
                pbSlikaInstruktora.Image = instruktor.Slika;
                lblImeInstruktora.Text = instruktor.Ime + " " + instruktor.Prezime;
                lblEmailInstruktor.Text = instruktor.Email;
                lblMobitelInstruktora.Text = instruktor.Mobitel;
            }
        }

        // Prikaz podataka o terminu instrukcija vezanih uz odabrani kolegij i pretvorba prikaza datuma po danu i mjesecu

        public void PrikaziTerminInstrukcija(Termin termin)
        {
            string[] datum = termin.VrijemeTermina.ToString().Split('.');

            lblDan.Text = datum[0];
            lblMjesec.Text = datum[1];
            lblNazivTermina.Text = termin.NazivTermina;
            lblMjestoOdrzavanja.Text = termin.MjestoOdrzavanja;
        }


        // Ovisno o odabranom kolegiju prikazuju se kontakt podaci o instruktoru radi lakšeg kontaktiranja instruktora i podaci o terminu

        private void btnPrikaziInstrukcije_Click(object sender, EventArgs e)
        {
            List<Rezervacija> rezervacijeStudenta = DohvatiRezervacijeStudenta();
            Kolegij selektiraniKolegij = comboKolegiji.SelectedItem as Kolegij;
            TipInstrukcije selektiraniTip = comboTipInstrukcije.SelectedItem as TipInstrukcije;


            if (selektiraniTip != null && selektiraniKolegij != null)
            {
                foreach (var item in rezervacijeStudenta)
                {
                    if (item.Termin.Instrukcija.TipInstrukcije.Id == selektiraniTip.Id && item.Termin.Instrukcija.Kolegij.Id == selektiraniKolegij.Id)
                    {
                        PrikaziTerminInstrukcija(item.Termin);
                        PrikaziInstruktoraZaKolegij(item.Termin.Instrukcija.Instruktor);
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

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
