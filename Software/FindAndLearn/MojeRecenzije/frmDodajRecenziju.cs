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

namespace FindAndLearn.MojeRecenzije
{
    public partial class frmDodajRecenziju : Form
    {
        
        public frmDodajRecenziju()
        {
            InitializeComponent();
        }

        public frmDodajRecenziju(Student postojeciStudent)
        {
            InitializeComponent();
            PostojeciStudent = postojeciStudent;
        }

        public Student PostojeciStudent { get; }

        private void frmDodajRecenziju_Load(object sender, EventArgs e)
        {
            
            Osvjezi();
        }

        private void Osvjezi()
        {
            int[] ocjene = { 1, 2, 3, 4, 5 };
            comboOcjena.DataSource = ocjene;
            Entities entities = new Entities();
            entities.Instruktori.Load();
            var mojiInstruktori = entities.Instruktori.Local;
            comboInstruktor.DataSource = mojiInstruktori.Distinct().ToList();
            entities.Recenzije.Load();
            recenzijeBindingSource.DataSource = entities.Recenzije.Local.Where(x => x.student_id == PostojeciStudent.ID_studenta);
            rtbKomentar.Clear();
            lblTrenutniStudent.Text = PostojeciStudent.ToString();
            

        }

       

        private void btnDodajRecenziju_Click(object sender, EventArgs e)
        {
            Recenzija novaRecenzija = RepozitorijRecenzija.KreirajRecenziju();
            List<Korisnik> sviKorisnici = RepozitorijKorisnika.PopuniListu();
            Instruktori instruktorBaza = (comboInstruktor.SelectedItem as Instruktori);
            Instruktor instruktor = (Instruktor)sviKorisnici.Find(x => x.KorisnickoIme == instruktorBaza.korisnicko_ime);
            novaRecenzija.Instruktor = instruktor;
            novaRecenzija.Student = PostojeciStudent;
            novaRecenzija.Ocjena = int.Parse(comboOcjena.SelectedItem.ToString());
            novaRecenzija.Komentar = rtbKomentar.Text;
           if(rtbKomentar.Text !="")
            {
                RepozitorijRecenzija.DodajRecenziju(novaRecenzija);
                Osvjezi();
            }
            else
            {
                MessageBox.Show("Nist popunili sva potrebna polja!");
            }
            Osvjezi();
            
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisiRecenziju_Click(object sender, EventArgs e)
        {
            Recenzije odabranaRecenzija = recenzijeBindingSource.Current as Recenzije;
            if (odabranaRecenzija != null)
            {
                int idBrisanje = odabranaRecenzija.ID_recenzije;

                if (MessageBox.Show("Želite li obrisati odabranu instrukciju?", "Brisanje", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    RepozitorijRecenzija.ObrisiRecenziju(idBrisanje);
                }
            }
            Osvjezi();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
            this.Close();
            
        }
    }
}
