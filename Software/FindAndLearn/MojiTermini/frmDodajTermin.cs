using FindAndLearn.Iznimke;
using FindAndLearn.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAndLearn.MojiTermini
{
    public partial class frmDodajTermin : Form
    {
        public frmDodajTermin()
        {
            InitializeComponent();
        }

        public frmDodajTermin(Instrukcija odabranaInstrukcija)
        {
            InitializeComponent();
            OdabranaInstrukcija = odabranaInstrukcija;
        }

        public Instrukcija OdabranaInstrukcija { get; }

        private void btnDodajTermin_Click(object sender, EventArgs e)
        {
            Termin noviTermin = RepozitorijTermina.KreirajTermin();
            noviTermin.Instrukcija = OdabranaInstrukcija;
            noviTermin.NazivTermina = txtNaziv.Text;
            noviTermin.VrijemeTermina = dtpVrijeme.Value;
            noviTermin.MjestoOdrzavanja = txtMjesto.Text;
            int trajanje;
            int kapacitet;
            bool trCheck = int.TryParse(txtTrajanje.Text, out trajanje);
            bool kaCheck = int.TryParse(txtKapacitet.Text, out kapacitet);
            noviTermin.Trajanje = trajanje;
            noviTermin.KapacitetTermina = kapacitet;
            try
            {
                bool korektno = RepozitorijTermina.ProvjeraIspravnostiUnosaTermina(noviTermin);
                
                RepozitorijTermina.DodajTerminUBazu(noviTermin);
        
            }
            catch (UnosTerminaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
           
            Osvjezi();
            ClearInput();
        }

        private void frmDodajTermin_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        private void Osvjezi()
        {
            Entities entities = new Entities();
            entities.Termini.Load();
            var termini = from ter in entities.Termini.Local
                          where ter.instrukcija_id == OdabranaInstrukcija.Id
                          select ter;
            terminiBindingSource.DataSource = termini;
            
        }

        private void btnObrisiTermin_Click(object sender, EventArgs e)
        {
            Termini terminBrisanje = terminiBindingSource.Current as Termini;
            int idBrisanje = terminBrisanje.ID_termina;
            if (terminBrisanje != null)
            {
                if (MessageBox.Show("Želite li obrisati odabrani termin?", "Brisanje", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    RepozitorijTermina.ObrisiTermin(idBrisanje);
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali niti jedan termin!");
            }
            Osvjezi();
            ClearInput();
        }

        private void ClearInput()
        {
           
            txtNaziv.Clear();
            txtMjesto.Clear();
            txtTrajanje.Clear();
            txtTrajanje.Clear();
            txtKapacitet.Clear();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
