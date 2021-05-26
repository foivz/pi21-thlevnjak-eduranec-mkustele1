using FindAndLearn.Klase;
using FindAndLearn.Profil;
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
    }
}
