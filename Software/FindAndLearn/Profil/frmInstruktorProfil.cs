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
    public partial class frmInstruktorProfil : Form
    {
        Instruktor postojeciInstruktor = null;

        public frmInstruktorProfil(Instruktor instruktor)
        {
            InitializeComponent();
            postojeciInstruktor = instruktor;
            OsvjeziProfil();
            UcitajPodatkeZaPregled();
        }

        private void UcitajPodatkeZaPregled()
        {
            using (var context = new Entities())
            {
                comboTipInstrukcija.DataSource = context.Tip_instrukcija.ToList();
                Instruktori instruktorBaza = context.Instruktori.FirstOrDefault(k => k.korisnicko_ime == postojeciInstruktor.KorisnickoIme);


                // Instrukciju definira 1 kolegij i 1 tip instrukcije pa se brojanjem jedinstvenih zapisa dobiva ukupan broj tipova i kolegija

                var brojTipova = (from ins in instruktorBaza.Instrukcije
                                  select ins.tip_instrukcije_id).Distinct().Count();

                var brojKolegija = (from ins in instruktorBaza.Instrukcije
                             select ins.kolegij_id).Distinct().Count();

                var brojInstrukcija = (from ins in instruktorBaza.Instrukcije
                                       select ins).Count();

                lblBrojTipova.Text = brojTipova.ToString();
                lblBrojKolegija.Text = brojKolegija.ToString();
                lblBrojInstrukcija.Text = brojInstrukcija.ToString();
            }
        }

        private void OsvjeziProfil()
        {
            if (postojeciInstruktor != null)
            {
                lblImePrezime.Text = postojeciInstruktor.Ime + " " + postojeciInstruktor.Prezime;
                lblEmail.Text = postojeciInstruktor.Email;
                lblMobitel.Text = postojeciInstruktor.Mobitel;
                lblMjesto.Text = postojeciInstruktor.Mjesto;
                lblUlica.Text = postojeciInstruktor.Ulica;
                lblTitula.Text = postojeciInstruktor.Titula;
                txtOpis.Text = postojeciInstruktor.Opis;
                pbSlikaInstruktora.Image = postojeciInstruktor.Slika;
            }
        }

        private void frmInstruktorProfil_Load(object sender, EventArgs e)
        {

        }

        private void btnIzmijeniPodatke_Click(object sender, EventArgs e)
        {
            frmOMeniInstruktor form = new frmOMeniInstruktor(postojeciInstruktor);
            form.ShowDialog();
            OsvjeziProfil();
        }

        private void btnUcitajGrafikon_Click(object sender, EventArgs e)
        {
            grafikonInstrukcija.Series["Cijena (kn/h)"].Points.Clear();
            lblPorukaGrafikon.Text = "";

            using (var context = new Entities())
            {
                // 1. Dohvaćanje tipa instrukcija i podataka o instruktoru iz baze

                Tip_instrukcija selektiranTip = comboTipInstrukcija.SelectedItem as Tip_instrukcija;
                Instruktori instruktorBaza = context.Instruktori.FirstOrDefault(k => k.korisnicko_ime == postojeciInstruktor.KorisnickoIme);


                // 2. Dohvaćanje liste instrukcija odabranog tipa iz popisa instrukcija samog dohvaćenog instruktora

                var upit = from ins in instruktorBaza.Instrukcije
                           where ins.tip_instrukcije_id == selektiranTip.ID_tip_instrukcije
                           select ins;

                List<Instrukcije> selektiraneInstrukcije = upit.ToList();

                // 3. Ukoliko postoji instrukcija za odabrani tip instrukcije iteracijom svih instrukcija prikazuje se grafikon s nazivima kolegija po cijenama (kn/h)

                if (selektiraneInstrukcije.Count == 0)
                {
                    lblPorukaGrafikon.Text = "Nema kolegija za odabrani tip instrukcije";
                }
                else
                {
                    foreach (Instrukcije item in selektiraneInstrukcije)
                    {
                        Kolegiji kolegij = context.Kolegiji.FirstOrDefault(k => k.ID_kolegija == item.kolegij_id);

                        grafikonInstrukcija.Series["Cijena (kn/h)"].Points.AddXY(kolegij.naziv_kolegija, item.cijena_instrukcije);
                    }
                }
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
            Close();
        }
    }
}
