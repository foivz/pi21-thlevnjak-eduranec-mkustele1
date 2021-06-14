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
    public partial class frmPorukeStudent : Form
    {
        private Student student;

        public frmPorukeStudent(Student trenutniStudent)
        {
            InitializeComponent();
            student = trenutniStudent;
        }

        private void frmPorukeStudent_Load(object sender, EventArgs e)
        {
            comboPrimatelj.DataSource = RepozitorijPoruka.DohvatiPrimateljeStudenta();
            dgvPopisPoruka.DataSource = RepozitorijPoruka.ListaPorukaStudenta(student);
            dgvPopisPoruka.Columns["Instruktori"].Visible = false;
            dgvPopisPoruka.Columns["Studenti"].Visible = false;
            dgvPopisPoruka.Columns["ID_poruke"].Visible = false;
            dgvPopisPoruka.Columns["student_id"].Visible = false;
            dgvPopisPoruka.Columns["instruktor_id"].Visible = false;
            dgvPopisPoruka.Columns["sadrzaj"].Visible = false;

            dgvPopisPoruka.Columns["ImePrezime"].HeaderText = "Ime i prezime";
            dgvPopisPoruka.Columns["naslov_poruke"].HeaderText = "Naslov poruke";
            dgvPopisPoruka.Columns["datum"].HeaderText = "Datum";
        }

        private void btnPošalji_Click(object sender, EventArgs e)
        {
            Instruktor instruktor = comboPrimatelj.SelectedItem as Instruktor;
            string naslov = txtNaslovPoruke.Text;
            string sadrzaj = txtSadržajPoruke.Text;
            DateTime datum = DateTime.Now;

            if (naslov != "" && sadrzaj != "")
            {
                RepozitorijPoruka.PosaljiPorukuInstruktoru(instruktor, student, naslov, sadrzaj, datum);
                MessageBox.Show($"Uspješno poslana poruka instruktoru {instruktor.KorisnickoIme}!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNaslovPoruke.Text = "";
                txtSadržajPoruke.Text = "";
            }
            else
            {
                MessageBox.Show("Polja ne smiju biti prazna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvPopisPoruka.DataSource = RepozitorijPoruka.ListaPorukaStudenta(student);
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
    }
}
