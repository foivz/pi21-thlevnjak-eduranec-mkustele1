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
            Entities entities = new Entities();
            entities.Instrukcije.Load();
            instrukcijeBindingSource.DataSource = entities.Instrukcije.Local;
        }

        private void instrukcijeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            terminiBindingSource.DataSource = (instrukcijeBindingSource.Current as Instrukcije).Termini;
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
    }
}
