using FindAndLearn.Klase;
using KorisniciLib;
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

namespace FindAndLearn.MojeRezervacije
{
    public partial class frmOdobriRezervaciju : Form
    {
        Entities entities = new Entities();
        public frmOdobriRezervaciju()
        {
            InitializeComponent();
        }

        public frmOdobriRezervaciju(Instruktor postojeciInstruktor)
        {
            InitializeComponent();
            PostojeciInstruktor = postojeciInstruktor;
        }

        public Instruktor PostojeciInstruktor { get; }

        private void frmOdobriRezervaciju_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            entities.Rezervacije.Load();
            entities.Instrukcije.Load();
            entities.Termini.Load();
            var rezZaInstruktora = from i in entities.Instrukcije.Local
                                              from t in entities.Termini.Local
                                              from r in entities.Rezervacije.Local
                                              where (i.instruktor_id == PostojeciInstruktor.ID_instruktora && t.instrukcija_id == i.ID_instrukcije && t.ID_termina == r.termin_ID )
                                              select r;
            rezervacijeBindingSource.DataSource = rezZaInstruktora;
        }

        private void btnOdobriRezervaciju_Click(object sender, EventArgs e)
        {
            Rezervacije odabranaRezervacija = rezervacijeBindingSource.Current as Rezervacije;

            RepozitorijTermina.DopuniKapacitet(odabranaRezervacija);
            RepozitorijRezervacija.OdobriRezervaciju(rezervacijeBindingSource.Current as Rezervacije);
            Osvjezi();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
            this.Close();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
