using FindAndLearn.Klase;
using FindAndLearn.MojeObavijesti;
using FindAndLearn.MojePoruke;
using FindAndLearn.MojeRecenzije;
using FindAndLearn.MojeRezervacije;
using FindAndLearn.Profil;
using FindAndLearn.Tražilica;
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

namespace FindAndLearn.Prijava
{
    public partial class frmPocetnaStudent : Form
    {
        Student postojeciStudent = null;
        public frmPocetnaStudent(Student student)
        {
            InitializeComponent();
            postojeciStudent = student;
        }

        private void frmPocetnaStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
            Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmStudentProfil form = new frmStudentProfil(postojeciStudent);
            form.ShowDialog();
            Close();
        }

        private void btnObavijesti_Click(object sender, EventArgs e)
        {
            frmObavijestiStudent form = new frmObavijestiStudent(postojeciStudent);
            form.ShowDialog();
            Close();
        }

        private void btnRezervacijaTermina_Click(object sender, EventArgs e)
        {
            frmZatraziRezervaciju frmRezervacija = new frmZatraziRezervaciju(postojeciStudent);
            frmRezervacija.ShowDialog();
        }

        private void btnRecenzije_Click(object sender, EventArgs e)
        {
            frmDodajRecenziju frmRecenz = new frmDodajRecenziju(postojeciStudent);
            frmRecenz.ShowDialog();
        }

        private void btnPoruke_Click(object sender, EventArgs e)
        {
            frmPorukeStudent frmPoruke = new frmPorukeStudent(postojeciStudent);
            frmPoruke.ShowDialog();
        }

        private void btnTrazilica_Click(object sender, EventArgs e)
        {
            frmTrazilica frmTrazilica = new frmTrazilica();
            frmTrazilica.ShowDialog();
        }
    }
}