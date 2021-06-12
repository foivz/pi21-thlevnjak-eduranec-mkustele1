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
        }

        private void frmStudentProfil_Load(object sender, EventArgs e)
        {
            UcitajTipoveInstrukcija();
            comboTipInstrukcije.SelectedIndexChanged += ComboTipInstrukcije_SelectedIndexChanged;
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

                if (comboTipInstrukcije.DataSource == null || comboKolegiji.DataSource == null)
                {
                    btnPrikaziInstrukcije.Enabled = false;
                }
                else
                {
                    btnPrikaziInstrukcije.Enabled = true;
                }
            }
        }

        // Rezervirani termin se odnosi na samo 1 instrukciju tako se dohvaćanjem termina studenta dolazi do studentovih instrukcija

        public void UcitajTipoveInstrukcija()
        {
            using (var context = new Entities())
            {
                var upitTip = (from r in context.Rezervacije
                               where r.student_ID == postojeciStudent.ID_studenta && r.potvrdjena == true
                               && r.Termini.vrijeme_termina >= DateTime.Now
                               select r.Termini.Instrukcije.Tip_instrukcija).Distinct();

                comboTipInstrukcije.DataSource = null;
                comboTipInstrukcije.DataSource = upitTip.ToList();

            }

            OsvjeziProfil();
        }

        // Ovisno o odabranom tipu puni se popis kolegija

        private void ComboTipInstrukcije_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tip_instrukcija selektiraniTip = comboTipInstrukcije.SelectedItem as Tip_instrukcija;
            using (var context = new Entities())
            {
                var upitKolegiji = (from r in context.Rezervacije
                                    where r.student_ID == postojeciStudent.ID_studenta && r.potvrdjena == true
                                    && r.Termini.vrijeme_termina >= DateTime.Now
                                    && r.Termini.Instrukcije.Tip_instrukcija.ID_tip_instrukcije == selektiraniTip.ID_tip_instrukcije
                                    select r.Termini.Instrukcije.Kolegiji).Distinct();

                comboKolegiji.DataSource = null;
                comboKolegiji.DataSource = upitKolegiji.ToList();
            }
            OsvjeziProfil();
        }

        // Dohvaćanje entitetne klase Instruktor kako bi se mogla prikazati slika tipa Image i ostali podaci o instruktoru

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


        // Ovisno o odabranom tipu i kolegiju prikazuju se kontakt podaci o instruktoru radi lakšeg kontaktiranja instruktora i podaci o terminu

        private void btnPrikaziInstrukcije_Click(object sender, EventArgs e)
        {
            Kolegiji selektiraniKolegij = comboKolegiji.SelectedItem as Kolegiji;
            Tip_instrukcija selektiraniTip = comboTipInstrukcije.SelectedItem as Tip_instrukcija;

            using (var context = new Entities())
            {
                var upitTermini = (from r in context.Rezervacije
                                   where r.student_ID == postojeciStudent.ID_studenta && r.potvrdjena == true
                                   && r.Termini.Instrukcije.Tip_instrukcija.ID_tip_instrukcije == selektiraniTip.ID_tip_instrukcije
                                   && r.Termini.Instrukcije.kolegij_id == selektiraniKolegij.ID_kolegija
                                   && r.Termini.vrijeme_termina >= DateTime.Now
                                   orderby r.Termini.vrijeme_termina
                                   select r.Termini).Distinct();

                List<Termini> terminiBaza = upitTermini.ToList();

                foreach (var item in terminiBaza)
                {
                    List<Termin> listaTermina = RepozitorijTermina.PopuniListuTermina();
                    Termin termin = listaTermina.Find(x => x.IdTermina == item.ID_termina);

                    if (termin.VrijemeTermina >= DateTime.Now)
                    {
                        PrikaziTerminInstrukcija(termin);
                        PrikaziInstruktoraZaKolegij(termin.Instrukcija.Instruktor);
                        break;
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
