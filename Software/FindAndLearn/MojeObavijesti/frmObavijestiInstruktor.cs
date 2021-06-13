using FindAndLearn.Controls;
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
    public partial class frmObavijestiInstruktor : Form
    {
        Instruktor postojeciInstruktor = null;
        List<Termin> listaTermina = RepozitorijTermina.PopuniListuTermina();

        List<Instrukcija> listaInstrukcija = RepozitorijInstrukcija.PopuniPopisInstrukcija();
        List<Termin> terminiInstruktora;


        public frmObavijestiInstruktor(Instruktor instruktor)
        {
            InitializeComponent();
            postojeciInstruktor = instruktor;
            terminiInstruktora = PopuniTermineInstruktora();
            comboPopisTermina.SelectedIndexChanged += ComboPopisTermina_SelectedIndexChanged;

            comboPopisTermina.DataSource = null;
            comboPopisTermina.DataSource=terminiInstruktora;
        }

        private void ComboPopisTermina_SelectedIndexChanged(object sender, EventArgs e)
        {
             OsvjeziObavijesti();
             PrikaziSudionike();
        }

        public void PodesiSirinuPopisaObavijesti()
        {
            dgvPopisObavijesti.Columns["Id"].Visible = false;
            dgvPopisObavijesti.Columns["OpisObavijesti"].Visible = false;
            dgvPopisObavijesti.Columns[1].Width = 138;
            dgvPopisObavijesti.Columns[2].Width = 250;
            dgvPopisObavijesti.Columns[4].Width = 150;
        }

        public void OsvjeziObavijesti()
        {
            Termin termin = DohvatiTermin();

            if (termin != null)
            {
                dgvPopisObavijesti.DataSource = null;
                dgvPopisObavijesti.DataSource = RepozitorijObavijesti.PopuniListuTrenutnihObavijesti(termin);
                PodesiSirinuPopisaObavijesti();
                dgvPopisObavijesti.SelectionChanged += DgvPopisObavijesti_SelectionChanged;
            }
        }

        private void DgvPopisObavijesti_SelectionChanged(object sender, EventArgs e)
        {
            Obavijest obavijest = DohvatiObavijest();
  
            btnAzurirajObavijest.Enabled = false;

            if (obavijest != null)
            {
                // Obavijest se može mijenjati samo pola sata nakon njezina kreiranja

                DateTime vrijemeObjave = obavijest.DatumObavijesti.AddMinutes(30);

                if (vrijemeObjave >= DateTime.Now)
                {
                    btnAzurirajObavijest.Enabled = true;
                }
                else
                {
                    btnAzurirajObavijest.Enabled = false;
                }
            }

        }

        private void frmObavijestiInstruktor_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmObavijestiInstruktor_KeyDown);
        }

        private void frmObavijestiInstruktor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
              //  Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Student/Profil/index.html");
            }
        }

        public List<Termin> PopuniTermineInstruktora()
        {
            terminiInstruktora = new List<Termin>();
            List<Termini> terminiBaza = null;

            using (var context = new Entities())
            {
                var upit = from t in context.Termini
                           where t.Instrukcije.Instruktori.ID_instruktora == postojeciInstruktor.ID_instruktora
                           && t.vrijeme_termina >= DateTime.Now
                           select t;

                terminiBaza = upit.ToList();
            }

            foreach (var item in terminiBaza)
            {
                Termin termin = listaTermina.Find(x => x.IdTermina == item.ID_termina);

                if (termin != null)
                {
                    terminiInstruktora.Add(termin);
                }
            }

            return terminiInstruktora;
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

        private Obavijest DohvatiObavijest()
        {
            Obavijest odabranaObavijest = null;
            if (dgvPopisObavijesti.CurrentRow != null)
            {
                odabranaObavijest = dgvPopisObavijesti.CurrentRow.DataBoundItem as Obavijest;
            }
            return odabranaObavijest;
        }

        public List<Obavijest> FiltrirajObavijestiPoDatumu(DateTime odDatuma, DateTime doDatuma)
        {
            List<Obavijest> filtriraneObavijesti = new List<Obavijest>();
            List<Obavijest> dohvaceneObavijesti = DohvatiTrenutneObavijesti();

            if(dohvaceneObavijesti != null)
            {
                foreach (var item in dohvaceneObavijesti)
                {
                    if (item.DatumObavijesti.Date >= odDatuma.Date && item.DatumObavijesti.Date <= doDatuma.Date)
                    {
                        filtriraneObavijesti.Add(item);
                    }
                }
            }

            return filtriraneObavijesti;
        }

        public List<Obavijest> DohvatiTrenutneObavijesti()
        {
            Termin termin = DohvatiTermin();
            List<Obavijest> dohvaceneObavijesti = new List<Obavijest>();

            if (termin != null)
            {
                dohvaceneObavijesti = RepozitorijObavijesti.PopuniListuTrenutnihObavijesti(termin);
            }

            return dohvaceneObavijesti;
        }

        public List<Obavijest> PretraziObavijestiPoNaslovu(string naslov)
        {
            List<Obavijest> pronadjeneObavijesti = new List<Obavijest>();
            List<Obavijest> dohvaceneObavijesti = DohvatiTrenutneObavijesti();

            if(dohvaceneObavijesti != null)
            {
                string pretraga = naslov;
                string[] pretvorbaPretrage = pretraga.Split(' ');

                foreach (var rijec in pretvorbaPretrage)
                {
                    foreach (var obavijest in dohvaceneObavijesti)
                    {
                        if (obavijest.NazivObavijesti.ToLower().Contains(rijec.ToLower()))
                        {
                            pronadjeneObavijesti.Add(obavijest);
                        }
                    }
                }
            }
            return pronadjeneObavijesti;
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            frmKreirajObavijesti form = new frmKreirajObavijesti(terminiInstruktora);
            form.ShowDialog();
            OsvjeziObavijesti();
        }

        private void btnAzurirajObavijest_Click(object sender, EventArgs e)
        {
            Obavijest obavijest = DohvatiObavijest();

            if(obavijest != null)
            {
                frmAzurirajObavijesti form = new frmAzurirajObavijesti(obavijest);
                form.ShowDialog();
            }

            OsvjeziObavijesti();
        }

        public void PrikaziSudionike()
        {
            List<Studenti> studentiBaza = null;
            Termin termin = DohvatiTermin();
            flpSudionici.Controls.Clear();

            int brojStudenata = 0;

            if (termin != null)
            {
                using (var context = new Entities())
                {
                    var upitRezervacije = from r in context.Rezervacije
                                          where r.termin_ID == termin.IdTermina
                                          select r.Studenti;

                    studentiBaza = upitRezervacije.ToList();
                }

                foreach (var item in studentiBaza)
                {
                    Student student = new Student();
                    StudentUC studentUC = new StudentUC();
                    List<Korisnik> listaKorisnika = RepozitorijKorisnika.PopuniListu();
                    student = listaKorisnika.Find(x => x.KorisnickoIme == item.korisnicko_ime) as Student;

                    studentUC.LoadStudent(student);
                    this.flpSudionici.Controls.Add(studentUC);
                    brojStudenata++;
                }

                gbPopisStudenata.Text = "";
                gbPopisStudenata.Text = "Studenti (" + brojStudenata.ToString() + ") ";
            }
        }

        private void btnProcitaj_Click(object sender, EventArgs e)
        {
            Obavijest obavijest = DohvatiObavijest();

            if (obavijest != null)
            {
                frmProcitajObavijesti form = new frmProcitajObavijesti(obavijest);
                form.ShowDialog();
            }

            OsvjeziObavijesti();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            dgvPopisObavijesti.DataSource = null;
            dgvPopisObavijesti.DataSource = PretraziObavijestiPoNaslovu(txtNaslov.Text);
            PodesiSirinuPopisaObavijesti();
        }

        private void btnPrikaziSveObavijesti_Click(object sender, EventArgs e)
        {
            OsvjeziObavijesti();
        }

        private void btnFiltiraj_Click(object sender, EventArgs e)
        {
            DateTime odDatuma = dtpOd.Value;
            DateTime doDatuma = dtpDo.Value;
            string porukaProvjere = RepozitorijObavijesti.ProvjeraDatuma(odDatuma, doDatuma);

            if(porukaProvjere == "")
            {
                dgvPopisObavijesti.DataSource = null;
                dgvPopisObavijesti.DataSource = FiltrirajObavijestiPoDatumu(odDatuma, doDatuma);
                PodesiSirinuPopisaObavijesti();
            }
            else
            {
                MessageBox.Show(porukaProvjere);
            }
        }

        // Kako bi student imamo uvid u obavijesti čiji su termini prošli omogućena je arhiva obavijesti

        private void btnArhiva_Click(object sender, EventArgs e)
        {
            List<Obavijest> prosleObavijesti = RepozitorijObavijesti.PopuniListuProslihObavijesti(postojeciInstruktor);
            frmArhivaObavijesti form = new frmArhivaObavijesti(prosleObavijesti);
            form.ShowDialog();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDetaljiTermina_Click(object sender, EventArgs e)
        {
            Termin termin = DohvatiTermin();

            if (termin != null)
            {
                frmDetaljiTermina form = new frmDetaljiTermina(termin);
                form.ShowDialog();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
