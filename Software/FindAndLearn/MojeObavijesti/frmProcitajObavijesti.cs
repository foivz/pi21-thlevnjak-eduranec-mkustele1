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
    public partial class frmProcitajObavijesti : Form
    {
        Obavijest obavijest = null;

        public frmProcitajObavijesti(Obavijest selektiranaObavijest)
        {
            InitializeComponent();
            obavijest = selektiranaObavijest;
        }

        private void frmProcitajObavijesti_Load(object sender, EventArgs e)
        {
            lblDatum.Text = obavijest.DatumObavijesti.ToString();
            lblNaslov.Text = obavijest.NazivObavijesti.ToString();
            txtPoruka.Text = obavijest.OpisObavijesti.ToString();
            lblInstruktor.Text = obavijest.Termin.Instrukcija.Instruktor.Ime.ToString() + " " + obavijest.Termin.Instrukcija.Instruktor.Prezime.ToString();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
