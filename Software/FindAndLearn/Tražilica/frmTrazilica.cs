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

namespace FindAndLearn.Tražilica
{
    public partial class frmTrazilica : Form
    {
        public frmTrazilica()
        {
            InitializeComponent();
        }

        private void frmTrazilica_Load(object sender, EventArgs e)
        {
            lblNaslovDatagrida.Visible = false;
        }

        public void PronadjiInstruktore(string imePrezime = null, string nazivKolegija = null)
        {
            if (imePrezime != null && nazivKolegija == null)
            {
                using (var context = new Entities())
                {
                    List<Instruktori> popisInstruktora = new List<Instruktori>();

                    var upit = (from i in context.Instruktori
                                select new
                                {
                                    ID = i.ID_instruktora,
                                    ImePrezime = i.ime + " " + i.prezime,
                                    KorisnickoIme = i.korisnicko_ime,
                                    Titula = i.titula,
                                    Email = i.email,
                                    Mobitel = i.mobitel,
                                    Slika = i.slika
                                }).ToList().Select(x => new Instruktori
                                {
                                    ID_instruktora = x.ID,
                                    ime = x.ImePrezime,
                                    korisnicko_ime = x.KorisnickoIme,
                                    titula = x.Titula,
                                    email = x.Email,
                                    mobitel = x.Mobitel,
                                    slika = x.Slika
                                }).Distinct().ToList();

                    var upit2 = from u in upit
                                where u.ime.ToLower().Contains(imePrezime.ToLower())
                                select u;

                    popisInstruktora = upit2.ToList();

                    dtgSviInstruktoriNaKolegiju.DataSource = popisInstruktora;
                    dtgSviInstruktoriNaKolegiju.Columns["ID_instruktora"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["Instrukcije"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["Poruke"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["Recenzije"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["prezime"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["lozinka"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["ulica"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["mjesto"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["opis"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["ime"].HeaderText = "Ime i prezime";
                    dtgSviInstruktoriNaKolegiju.Columns["korisnicko_ime"].HeaderText = "Korisničko ime";
                    dtgSviInstruktoriNaKolegiju.Columns["email"].HeaderText = "Email";
                    dtgSviInstruktoriNaKolegiju.Columns["mobitel"].HeaderText = "Mobitel";
                    dtgSviInstruktoriNaKolegiju.Columns["titula"].HeaderText = "Titula";
                    dtgSviInstruktoriNaKolegiju.Columns["slika"].HeaderText = "Slika";
                }
            }
            if (imePrezime == null && nazivKolegija != null)
            {
                Kolegiji kolegij = new Kolegiji();
                using (var context = new Entities())
                {
                    List<Instruktori> listaInstruktora = new List<Instruktori>();

                    var upit = (from i in context.Instruktori
                                join ins in context.Instrukcije on i.ID_instruktora equals ins.instruktor_id
                                join kol in context.Kolegiji on ins.kolegij_id equals kol.ID_kolegija
                                where kol.naziv_kolegija.ToLower().Contains(nazivKolegija.ToLower())
                                select new {
                                    ID = i.ID_instruktora,
                                    ImePrezime = i.ime + " " + i.prezime,
                                    KorisnickoIme = i.korisnicko_ime,
                                    Titula = i.titula,
                                    Email = i.email,
                                    Mobitel = i.mobitel,
                                    Slika = i.slika
                                }).ToList().Select(x=> new Instruktori
                                {
                                    ID_instruktora = x.ID,
                                    ime = x.ImePrezime,
                                    korisnicko_ime = x.KorisnickoIme,
                                    titula = x.Titula,
                                    email = x.Email,
                                    mobitel = x.Mobitel,
                                    slika = x.Slika
                                }).ToList();

                    listaInstruktora = upit.ToList();

                    dtgSviInstruktoriNaKolegiju.DataSource = listaInstruktora;
                    dtgSviInstruktoriNaKolegiju.Columns["ID_instruktora"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["Instrukcije"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["Poruke"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["Recenzije"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["prezime"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["lozinka"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["ulica"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["mjesto"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["opis"].Visible = false;
                    dtgSviInstruktoriNaKolegiju.Columns["ime"].HeaderText = "Ime i prezime";
                    dtgSviInstruktoriNaKolegiju.Columns["korisnicko_ime"].HeaderText = "Korisničko ime";
                    dtgSviInstruktoriNaKolegiju.Columns["email"].HeaderText = "Email";
                    dtgSviInstruktoriNaKolegiju.Columns["mobitel"].HeaderText = "Mobitel";
                    dtgSviInstruktoriNaKolegiju.Columns["titula"].HeaderText = "Titula";
                    dtgSviInstruktoriNaKolegiju.Columns["slika"].HeaderText = "Slika";
                }
            }
        }

        private void txtInstruktor_KeyUp(object sender, KeyEventArgs e)
        {
            lblNaslovDatagrida.Visible = true;
            lblNaslovDatagrida.Text = "Popis instruktora po imenu";
            string imePrezime = txtInstruktor.Text;
            try
            {
                if (imePrezime == "")
                {
                    dtgSviInstruktoriNaKolegiju.DataSource = null;
                    lblNaslovDatagrida.Visible = false;
                }
                else
                {
                    PronadjiInstruktore(imePrezime, null);
                }
            }
            catch
            {
                MessageBox.Show("Greška!");
            }
        }

        private void txtKolegij_KeyUp(object sender, KeyEventArgs e)
        {
            lblNaslovDatagrida.Visible = true;
            lblNaslovDatagrida.Text = "Popis instruktora po kolegijima";
            string nazivKolegija = txtKolegij.Text;
            try
            {
                if (nazivKolegija == "")
                {
                    dtgSviInstruktoriNaKolegiju.DataSource = null;
                    lblNaslovDatagrida.Visible = false;
                }
                else
                {
                    PronadjiInstruktore(null, nazivKolegija);
                }
            }
            catch
            {
                MessageBox.Show("Greška!");
            }
        }

        private void btnDetaljiInstruktora_Click(object sender, EventArgs e)
        {
            Kolegiji kolegiji = new Kolegiji();
            if(dtgSviInstruktoriNaKolegiju.CurrentCell != null)
            {
                Instruktori instruktor = dtgSviInstruktoriNaKolegiju.CurrentRow.DataBoundItem as Instruktori;
                decimal prosjecnaOcjena;
                try
                {
                    prosjecnaOcjena = kolegiji.IzracunProsjecneOcjene(instruktor);
                    frmDetaljiInstruktora frmDetalji = new frmDetaljiInstruktora(prosjecnaOcjena, instruktor);
                    frmDetalji.ShowDialog();
                }
                catch
                {
                    MessageBox.Show($"Instruktor {instruktor.ime} {instruktor.prezime} nije recenziran!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Niste upisali ništa u tražilice!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
