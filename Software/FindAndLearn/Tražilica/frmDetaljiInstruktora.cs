using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAndLearn.Tražilica
{
    public partial class frmDetaljiInstruktora : Form
    {
        private decimal prosjecnaOcjena;
        private Instruktori instruktor;

        public frmDetaljiInstruktora(decimal prosjecnaOcjena, Instruktori instruktor)
        {
            InitializeComponent();
            this.prosjecnaOcjena = prosjecnaOcjena;
            this.instruktor = instruktor;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDetaljiInstruktora_Load(object sender, EventArgs e)
        {
            lblOcjena.Text = prosjecnaOcjena.ToString();
            lblImePrezime.Text = instruktor.ime + " " + instruktor.prezime;

            List<Recenzije> listaRecenzija = new List<Recenzije>();

            using (var context = new Entities())
            {
                var upit = (from rec in context.Recenzije
                            where rec.instruktor_id == instruktor.ID_instruktora
                            select new
                            {
                                ImePrezime = rec.Studenti.ime + " " + rec.Studenti.prezime,
                                ocjena = rec.ocjena,
                                komentar = rec.komentar,
                            }).ToList().Select(x => new Recenzije
                            {
                                ImePrezime = x.ImePrezime,
                                ocjena = x.ocjena,
                                komentar = x.komentar
                            });

                listaRecenzija = upit.ToList();

                dtgPopisKomentara.DataSource = upit.ToList();
                dtgPopisKomentara.Columns["Instruktori"].Visible = false;
                dtgPopisKomentara.Columns["ID_recenzije"].Visible = false;
                dtgPopisKomentara.Columns["instruktor_id"].Visible = false;
                dtgPopisKomentara.Columns["student_id"].Visible = false;
                dtgPopisKomentara.Columns["Studenti"].Visible = false;
                dtgPopisKomentara.Columns["ImePrezime"].DisplayIndex = 1;
                dtgPopisKomentara.Columns["komentar"].DisplayIndex = 2;
                dtgPopisKomentara.Columns["ocjena"].DisplayIndex = 3;
                dtgPopisKomentara.Columns["ImePrezime"].HeaderText = "Ime i prezime";
                dtgPopisKomentara.Columns["komentar"].HeaderText = "Komentar";
                dtgPopisKomentara.Columns["ocjena"].HeaderText = "Ocjena";
            }
        }
    }
}
