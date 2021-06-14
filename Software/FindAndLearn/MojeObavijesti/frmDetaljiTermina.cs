using FindAndLearn.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAndLearn.MojeObavijesti
{
    public partial class frmDetaljiTermina : Form
    {
        Termin termin = null;

        public frmDetaljiTermina(Termin selektiraniTermin)
        {
            InitializeComponent();
            termin = selektiraniTermin;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDetaljiTermina_Load(object sender, EventArgs e)
        {
            UcitajTermin();
            UcitajInstrukciju();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmDetaljiTermina_KeyDown);
        }

        private void frmDetaljiTermina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Instruktor/Obavijesti/Detalji_termina/index.html");
            }
        }

        public void PrikaziBrojStudenata()
        {
            using (var context = new Entities())
            {
                var upitRezervacije = (from r in context.Rezervacije
                                       where r.termin_ID == termin.IdTermina
                                       select r.Studenti).Count();

                txtBrojStudenata.Text = upitRezervacije.ToString();
            }
        }

        private void UcitajInstrukciju()
        {
            txtTipInstrukcije.Text = termin.Instrukcija.TipInstrukcije.NazivTipa;
            txtKolegij.Text = termin.Instrukcija.Kolegij.NazivKolegija;
            txtCijenaInstrukcije.Text = termin.Instrukcija.CijenaInstrukcije.ToString() + " kn";
            txtOpisInstrukcije.Text = termin.Instrukcija.OpisInstrukcije;
        }

        private void UcitajTermin()
        {
            lblNazivTermina.Text = termin.NazivTermina;
            txtVrijemeTermina.Text = termin.VrijemeTermina.ToString();
            txtTrajanjeTermina.Text = termin.Trajanje.ToString() + " minuta";
            txtMjestoTermina.Text = termin.MjestoOdrzavanja.ToString();
            lblKapacitetTermina.Text = termin.KapacitetTermina.ToString();
            PrikaziBrojStudenata();
        }
    }
}
