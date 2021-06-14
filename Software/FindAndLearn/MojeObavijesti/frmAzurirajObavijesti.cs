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

namespace FindAndLearn.MojeObavijesti
{
    public partial class frmAzurirajObavijesti : Form
    {
        Obavijest obavijest = null;

        public frmAzurirajObavijesti(Obavijest selektiranaObavijest)
        {
            InitializeComponent();
            obavijest = selektiranaObavijest;

            txtTermin.Text = obavijest.Termin.NazivTermina;
            txtNaslov.Text = obavijest.NazivObavijesti;
            txtPoruka.Text = obavijest.OpisObavijesti;
        }

        private void frmAzurirajObavijesti_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmAzurirajObavijesti_KeyDown);
        }

        private void frmAzurirajObavijesti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, "AppHelp.chm", HelpNavigator.Topic, "Instruktor/Obavijesti/Azuriraj_obavijesti/index.html");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            string naslov = txtNaslov.Text;
            string poruka = txtPoruka.Text;
            DateTime datumObavijesti = DateTime.Now;

            if (obavijest != null)
            {
                obavijest.NazivObavijesti = txtNaslov.Text;
                obavijest.OpisObavijesti = txtPoruka.Text;
                obavijest.DatumObavijesti = datumObavijesti;

                RepozitorijObavijesti.AzurirajObavijest(obavijest);
                MessageBox.Show("Obavijest je ažurirana! Možete ju mijenjati još 30 minuta.");
            }

            Close();
        }
    }
}
