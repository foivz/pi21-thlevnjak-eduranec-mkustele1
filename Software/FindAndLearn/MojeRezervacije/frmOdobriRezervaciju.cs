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
            Entities entities = new Entities();
            entities.Rezervacije.Load();
            entities.Instrukcije.Load();
            entities.Termini.Load();
            var rezZaInstruktora = from i in entities.Instrukcije.Local
                                              from t in entities.Termini.Local
                                              from r in entities.Rezervacije.Local
                                              where (i.instruktor_id == PostojeciInstruktor.ID_instruktora && t.instrukcija_id == i.ID_instrukcije && t.ID_termina == r.termin_ID && r.potvrdjena==false)
                                              select r;
            rezervacijeBindingSource.DataSource = rezZaInstruktora;

            var rezZaInstruktora2 = from i in entities.Instrukcije.Local
                                    from t in entities.Termini.Local
                                    from r in entities.Rezervacije.Local
                                    where (i.instruktor_id == PostojeciInstruktor.ID_instruktora && t.instrukcija_id == i.ID_instrukcije && t.ID_termina == r.termin_ID && r.potvrdjena == true)
                                    select r;
            dgvOdobreneRezervacije.DataSource = rezZaInstruktora2.ToList();
            lblTrenutniInstruktor.Text = PostojeciInstruktor.ToString();
        }

        private void btnOdobriRezervaciju_Click(object sender, EventArgs e)
        {
            Rezervacije odabranaRezervacija = rezervacijeBindingSource.Current as Rezervacije;

            if (odabranaRezervacija != null)
            {
                RepozitorijTermina.DopuniKapacitet(odabranaRezervacija);
                RepozitorijRezervacija.OdobriRezervaciju(rezervacijeBindingSource.Current as Rezervacije);
                
            }
            else
            {
                MessageBox.Show("Niste odabrali niti jednu rezervaciju!");
            }
            Osvjezi();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
