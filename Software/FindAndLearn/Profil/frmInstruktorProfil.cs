﻿using FindAndLearn.Klase;
using FindAndLearn.Tražilica;
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
            lblPorukaGrafikona.Text = "";
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

                PrikaziRecenziju();

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
            lblPorukaGrafikona.Text = "";

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
                    lblPorukaGrafikona.Text = "Nema kolegija za odabrani tip instrukcije";
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

        private void btnPrikaziSveInstrukcije_Click(object sender, EventArgs e)
        {
            lblPorukaGrafikona.Text = "";

            using (var context = new Entities())
            {
                grafikonInstrukcija.Series["Cijena (kn/h)"].Points.Clear();

                Instruktori instruktorBaza = context.Instruktori.FirstOrDefault(k => k.korisnicko_ime == postojeciInstruktor.KorisnickoIme);

                var upitSveInstrukcije = from ins in instruktorBaza.Instrukcije
                                         select ins;

                List<Instrukcije> popisInstrukcija = upitSveInstrukcije.ToList();

                if (popisInstrukcija.Count == 0)
                {
                     lblPorukaGrafikona.Text = "Nema instrukcija za trenutnog instruktora";
                }

                else
                {
                    foreach (Instrukcije item in popisInstrukcija)
                    {
                        Kolegiji kolegij = context.Kolegiji.FirstOrDefault(k => k.ID_kolegija == item.kolegij_id);

                        grafikonInstrukcija.Series["Cijena (kn/h)"].Points.AddXY(item.Tip_instrukcija.naziv_tipa.Substring(0, 3).ToUpper() + " - " + item.Kolegiji.naziv_kolegija, item.cijena_instrukcije);
                    }
                }
            }

        }

        public void PrikaziRecenziju()
        {
            Kolegiji kolegiji = new Kolegiji();
            Instruktori instruktorBaza = null;
            btnKomentari.Enabled = false;
            btnKomentari.Text = "KOMENTARI";
            int ocjene = 0;

            using (var context = new Entities())
            {
                instruktorBaza = context.Instruktori.FirstOrDefault(k => k.korisnicko_ime == postojeciInstruktor.KorisnickoIme);

                var upitRecenzije = (from r in instruktorBaza.Recenzije
                                     select r).Count();

                ocjene = upitRecenzije;
            }

            btnKomentari.Text = "KOMENTARI" + " (" + ocjene.ToString() + ")";

            if (ocjene == 0)
            {
                btnKomentari.Enabled = false;
                lblProsjecnaOcjena.Text = "- / 5";
            }
            else
            {
                btnKomentari.Enabled = true;
                decimal prosjecnaOcjena = kolegiji.IzracunProsjecneOcjene(instruktorBaza);
                lblProsjecnaOcjena.Text = prosjecnaOcjena.ToString() + " / 5";
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKomentari_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                Instruktori instruktorBaza = context.Instruktori.FirstOrDefault(k => k.korisnicko_ime == postojeciInstruktor.KorisnickoIme);
                Kolegiji kolegiji = new Kolegiji();

                decimal prosjecnaOcjena = kolegiji.IzracunProsjecneOcjene(instruktorBaza);
                frmDetaljiInstruktora frmDetalji = new frmDetaljiInstruktora(prosjecnaOcjena, instruktorBaza);
                frmDetalji.ShowDialog();
            }
        }
    }
}
