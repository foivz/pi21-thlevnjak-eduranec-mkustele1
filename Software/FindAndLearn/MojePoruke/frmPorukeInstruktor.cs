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

namespace FindAndLearn.MojePoruke
{
    public partial class frmPorukeInstruktor : Form
    {
        private Instruktor instruktor;

        public frmPorukeInstruktor(Instruktor postojeciInstruktor)
        {
            InitializeComponent();
            instruktor = postojeciInstruktor;
        }

        private void frmPorukeInstruktor_Load(object sender, EventArgs e)
        {
            comboPrimatelj.DataSource = RepozitorijPoruka.DohvatiPrimateljeInstruktora();
            dgvPopisPoruka.DataSource = RepozitorijPoruka.ListaPorukaInstruktora(instruktor);
            dgvPopisPoruka.Columns["Instruktori"].Visible = false;
            dgvPopisPoruka.Columns["Studenti"].Visible = false;
            dgvPopisPoruka.Columns["ID_poruke"].Visible = false;
            dgvPopisPoruka.Columns["instruktor_id"].Visible = false;
            dgvPopisPoruka.Columns["student_id"].Visible = false;
            dgvPopisPoruka.Columns["sadrzaj"].Visible = false;

            dgvPopisPoruka.Columns["ImePrezime"].HeaderText = "Ime i prezime";
            dgvPopisPoruka.Columns["naslov_poruke"].HeaderText = "Naslov poruke";
            dgvPopisPoruka.Columns["datum"].HeaderText = "Datum";
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmPorukeInstruktor_KeyDown);
        }

        private void frmPorukeInstruktor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Instruktor/Poruke/index.html");
            }
        }

        private void btnPošalji_Click(object sender, EventArgs e)
        {
            Student student = comboPrimatelj.SelectedItem as Student;
            string naslov = txtNaslovPoruke.Text;
            string sadrzaj = txtSadržajPoruke.Text;
            DateTime datum = DateTime.Now;

            if (naslov != "" && sadrzaj != "")
            {
                RepozitorijPoruka.PosaljiPorukuStudentu(student, instruktor, naslov, sadrzaj, datum);
                MessageBox.Show($"Uspješno poslana poruka studentu {student.KorisnickoIme}!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNaslovPoruke.Text = "";
                txtSadržajPoruke.Text = "";
            }
            else
            {
                MessageBox.Show("Polja ne smiju biti prazna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvPopisPoruka.DataSource = RepozitorijPoruka.ListaPorukaInstruktora(instruktor);
        }

        private void btnDetaljiPoruke_Click(object sender, EventArgs e)
        {
            Poruke selektiranaPoruka = dgvPopisPoruka.CurrentRow.DataBoundItem as Poruke;

            MessageBox.Show(selektiranaPoruka.sadrzaj, selektiranaPoruka.naslov_poruke, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Instruktor/Poruke/index.html");
        }
    }
}
