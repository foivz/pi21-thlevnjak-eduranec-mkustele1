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
    public partial class frmZatraziRezervaciju : Form
    {
        public frmZatraziRezervaciju()
        {
            InitializeComponent();
        }

        public frmZatraziRezervaciju(Student postojeciStudent)
        {
            InitializeComponent();
            PostojeciStudent = postojeciStudent;
        }

        public Student PostojeciStudent { get; }

        private void frmZatraziRezervaciju_Load(object sender, EventArgs e)
        {
            Osvjezi();

        }

        private void Osvjezi()
        {
            Entities entities = new Entities();
            entities.Instrukcije.Load();
            entities.Rezervacije.Load();
            instrukcijeBindingSource.DataSource = entities.Instrukcije.Local;
            rezervacijeBindingSource.DataSource = entities.Rezervacije.Local.Where(x => x.student_ID == PostojeciStudent.ID_studenta);
            lblTrenutniStudent.Text = PostojeciStudent.ToString();
        }

       

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
            this.Close();
        }

        private void btnZatraziRezervaciju_Click(object sender, EventArgs e)
        {
            if(terminiBindingSource.Current != null)
            {
                int idTermina = (terminiBindingSource.Current as Termini).ID_termina;
                bool prolaz = RepozitorijTermina.ProvjeraKapaciteta(idTermina);
                bool vecZatrazena = RepozitorijRezervacija.ProvjeraPrethodnihRezervacija(PostojeciStudent, idTermina);
                
                Termin termin = RepozitorijTermina.DohvatiTermin(idTermina);
                if (prolaz==true)
                {
                    if (vecZatrazena == false)
                    {
                        Rezervacija novaRezervacija = RepozitorijRezervacija.KreirajRezervaciju();
                        novaRezervacija.Student = PostojeciStudent;
                        novaRezervacija.Termin = termin;
                        novaRezervacija.DatumRezervacije = DateTime.Now;
                        novaRezervacija.RokRezervacije = (terminiBindingSource.Current as Termini).vrijeme_termina;
                        novaRezervacija.Potvrdjena = false;
                        RepozitorijRezervacija.ZatraziRezervaciju(novaRezervacija);
                    }
                    else
                    {
                        MessageBox.Show("Već ste zatražili rezervaciju za odabrani termin!");
                    }
                }

                else
                {
                    MessageBox.Show("Odabrani termin više nema slobodnih mjesta!");
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali termin!");
            }
        }

        private void instrukcijeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            terminiBindingSource.DataSource = (instrukcijeBindingSource.Current as Instrukcije).Termini.Where(x=>x.vrijeme_termina > DateTime.Now);
        }
    }
}
