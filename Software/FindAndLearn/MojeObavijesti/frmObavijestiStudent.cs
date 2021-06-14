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
    public partial class frmObavijestiStudent : Form
    {
        Student postojeciStudent = null;
        List<Termin> terminiStudenta = null;


        public frmObavijestiStudent(Student student)
        {
            InitializeComponent();
            postojeciStudent = student;
            terminiStudenta = PopuniTermineStudenta();
            comboPopisTermina.DataSource = terminiStudenta;
            comboPopisTermina.SelectedIndexChanged += ComboPopisTermina_SelectedIndexChanged;
        }

        private void ComboPopisTermina_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziObavijesti();
            PrikaziSudionike();
        }

        private void frmObavijestiStudent_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmObavijestiStudent_KeyDown);
        }

        private void frmObavijestiStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Student/Obavijesti/index.html");
            }
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
            }
        }

        // Dohvaćaju se samo oni termini koji su aktualni odnosno koji još uvijek nisu prošli

        public List<Termin> PopuniTermineStudenta()
        {
            List<Termin> listaTermina = RepozitorijTermina.PopuniListuTermina();
            terminiStudenta = new List<Termin>();

            using (var context = new Entities())
            {
                var upit = from r in context.Rezervacije
                           where r.student_ID == postojeciStudent.ID_studenta && r.potvrdjena==true
                           select r.Termini;

                List<Termini> terminiBaza = upit.ToList();

                foreach (var item in terminiBaza)
                {
                    if(item.vrijeme_termina >= DateTime.Now)
                    {
                        Termin termin = listaTermina.Find(x => x.IdTermina == item.ID_termina);
                        terminiStudenta.Add(termin);
                    }
                }
            }

            return terminiStudenta;
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

        public List<Obavijest> DohvatiSveTrenutneObavijesti()
        {
            Termin termin = DohvatiTermin();
            List<Obavijest> dohvaceneObavijesti = new List<Obavijest>();

            if (termin != null)
            {
                dohvaceneObavijesti = RepozitorijObavijesti.PopuniListuTrenutnihObavijesti(termin);
            }

            return dohvaceneObavijesti;
        }

        public List<Obavijest> FiltrirajObavijestiPoDatumu(DateTime odDatuma, DateTime doDatuma)
        {
            List<Obavijest> filtriraneObavijesti = new List<Obavijest>();
            List<Obavijest> dohvaceneObavijesti = DohvatiSveTrenutneObavijesti();

            if (dohvaceneObavijesti != null)
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

        public List<Obavijest> PretraziObavijestiPoNaslovu(string naslov)
        {
            List<Obavijest> pronadjeneObavijesti = new List<Obavijest>();
            List<Obavijest> dohvaceneObavijesti = DohvatiSveTrenutneObavijesti();

            if (dohvaceneObavijesti != null)
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

            if (porukaProvjere == "")
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
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Student/Obavijesti/index.html");
        }
    }
}
