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

        public void PronadjiInstruktore(string imePrezime = null, string korisnickoIme = null)
        {
            if (imePrezime != null)
            {
                using (var context = new Entities())
                {
                    List<Instruktori> popisInstruktora = new List<Instruktori>();

                    var upit = from i in context.Instruktori
                                where i.ime.Contains(imePrezime) || i.prezime.Contains(imePrezime)
                                select i;

                    popisInstruktora = upit.ToList();

                    dtgSviInstruktoriNaKolegiju.DataSource = popisInstruktora;
                }
            }
            if (korisnickoIme != null)
            {
                using (var context = new Entities())
                {
                    List<Instruktori> popisInstruktora = new List<Instruktori>();

                    var upit = from i in context.Instruktori
                               where i.korisnicko_ime.Contains(korisnickoIme)
                               select i;

                    popisInstruktora = upit.ToList();

                    dtgSviInstruktoriNaKolegiju.DataSource = popisInstruktora;
                }
            }
        }

        public void PronadjiRecenzijeZaKolegij(Kolegiji kolegij, string nazivKolegija)
        {
            if (kolegij != null)
            {
                using (var context = new Entities())
                {
                    List<Instruktori> listaInstruktora = new List<Instruktori>();

                    var upit = from instruktori in context.Instruktori
                               join instrukcije in context.Instrukcije on instruktori.ID_instruktora equals instrukcije.instruktor_id
                               join kolegiji in context.Kolegiji on instrukcije.kolegij_id equals kolegij.ID_kolegija
                               where kolegiji.naziv_kolegija.Contains(nazivKolegija)
                               select instruktori;

                    listaInstruktora = upit.ToList();

                    dtgSviInstruktoriNaKolegiju.DataSource = listaInstruktora;
                    dtgSviInstruktoriNaKolegiju.Columns["ID_instruktora"].Visible = false;
                }
            }
        }

        private void txtInstruktor_KeyUp(object sender, KeyEventArgs e)
        {
            lblNaslovDatagrida.Visible = true;
            lblNaslovDatagrida.Text = "Instruktori";
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
            lblNaslovDatagrida.Text = "Kolegiji";
            string nazivKolegija = txtKolegij.Text;
            Kolegiji kolegij = new Kolegiji();
            try
            {
                if (nazivKolegija == "")
                {
                    dtgSviInstruktoriNaKolegiju.DataSource = null;
                    lblNaslovDatagrida.Visible = false;
                }
                else
                {
                    PronadjiRecenzijeZaKolegij(kolegij, nazivKolegija);
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
        }
    }
}
