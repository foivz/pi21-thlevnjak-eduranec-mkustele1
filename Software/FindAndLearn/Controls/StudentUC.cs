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

namespace FindAndLearn.Controls
{
    public partial class StudentUC : UserControl
    {
        Student student = null;

        public StudentUC()
        {
            InitializeComponent();
        }

        public void LoadStudent(Student selektiraniStudent)
        {
            student = selektiraniStudent;
        }

        private void StudentUC_Load(object sender, EventArgs e)
        {
            pbSlika.Image = student.Slika;
            lblImePrezime.Text = student.Ime + " " + student.Prezime;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frmStudentPodaci form = new frmStudentPodaci(student);
            form.ShowDialog();
        }
    }
}
