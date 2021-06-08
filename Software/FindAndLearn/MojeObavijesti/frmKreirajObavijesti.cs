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
    public partial class frmKreirajObavijesti : Form
    {
        public frmKreirajObavijesti(List<Termin> termini)
        {
            InitializeComponent();
            comboPopisTermina.DataSource = termini.ToList();
        }


        public Termin DohvatiTermin()
        {
            Termin odabraniTermin = null;
            if (comboPopisTermina.SelectedItem != null)
            {
                odabraniTermin = comboPopisTermina.SelectedItem as Termin;
            }
            return odabraniTermin;
        }

        private void frmKreirajObavijesti_Load(object sender, EventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            Termin termin = DohvatiTermin();
            string naslov = txtNaslov.Text;
            string poruka = txtPoruka.Text;
            DateTime datumObavijesti = DateTime.Now;


            if(termin != null)
            {

                Obavijest novaObavijest = new Obavijest();
                novaObavijest.Termin = termin;
                novaObavijest.NazivObavijesti = naslov;
                novaObavijest.OpisObavijesti = poruka;
                novaObavijest.DatumObavijesti = datumObavijesti;

                RepozitorijObavijesti.DodajObavijest(novaObavijest);
                MessageBox.Show("Obavijest je kreirana! Možete ju mijenjati još 30 minuta.");

            }

            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
