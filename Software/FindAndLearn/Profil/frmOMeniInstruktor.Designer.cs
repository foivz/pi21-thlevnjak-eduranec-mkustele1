
namespace FindAndLearn.Profil
{
    partial class frmOMeniInstruktor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbKratkiOpis = new System.Windows.Forms.GroupBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.gbOsnovno = new System.Windows.Forms.GroupBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.txtTitula = new System.Windows.Forms.TextBox();
            this.lblTitula = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.gbAdresa = new System.Windows.Forms.GroupBox();
            this.txtMjesto = new System.Windows.Forms.TextBox();
            this.lblMjesto = new System.Windows.Forms.Label();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.lblUlica = new System.Windows.Forms.Label();
            this.gbKontakt = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobitel = new System.Windows.Forms.Label();
            this.txtMobitel = new System.Windows.Forms.TextBox();
            this.pbSlikaInstruktora = new System.Windows.Forms.PictureBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnUkloniSliku = new System.Windows.Forms.Button();
            this.cbZadanaSlika = new System.Windows.Forms.CheckBox();
            this.gbKratkiOpis.SuspendLayout();
            this.gbOsnovno.SuspendLayout();
            this.gbAdresa.SuspendLayout();
            this.gbKontakt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaInstruktora)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKratkiOpis
            // 
            this.gbKratkiOpis.Controls.Add(this.txtOpis);
            this.gbKratkiOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbKratkiOpis.Location = new System.Drawing.Point(45, 428);
            this.gbKratkiOpis.Name = "gbKratkiOpis";
            this.gbKratkiOpis.Size = new System.Drawing.Size(572, 117);
            this.gbKratkiOpis.TabIndex = 53;
            this.gbKratkiOpis.TabStop = false;
            this.gbKratkiOpis.Text = "Kratki opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(17, 28);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(537, 71);
            this.txtOpis.TabIndex = 39;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(45, 558);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(105, 32);
            this.btnOdustani.TabIndex = 52;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.Location = new System.Drawing.Point(513, 558);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(106, 32);
            this.btnSpremi.TabIndex = 51;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // gbOsnovno
            // 
            this.gbOsnovno.Controls.Add(this.txtKorisnickoIme);
            this.gbOsnovno.Controls.Add(this.lblKorisnickoIme);
            this.gbOsnovno.Controls.Add(this.txtTitula);
            this.gbOsnovno.Controls.Add(this.lblTitula);
            this.gbOsnovno.Controls.Add(this.txtPrezime);
            this.gbOsnovno.Controls.Add(this.txtIme);
            this.gbOsnovno.Controls.Add(this.lblPrezime);
            this.gbOsnovno.Controls.Add(this.lblIme);
            this.gbOsnovno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbOsnovno.Location = new System.Drawing.Point(214, 37);
            this.gbOsnovno.Name = "gbOsnovno";
            this.gbOsnovno.Size = new System.Drawing.Size(403, 218);
            this.gbOsnovno.TabIndex = 50;
            this.gbOsnovno.TabStop = false;
            this.gbOsnovno.Text = "Osnovno";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnickoIme.Location = new System.Drawing.Point(19, 44);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(160, 20);
            this.txtKorisnickoIme.TabIndex = 26;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(15, 23);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(96, 15);
            this.lblKorisnickoIme.TabIndex = 25;
            this.lblKorisnickoIme.Text = "*Korisničko ime:";
            // 
            // txtTitula
            // 
            this.txtTitula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTitula.Location = new System.Drawing.Point(21, 152);
            this.txtTitula.Name = "txtTitula";
            this.txtTitula.Size = new System.Drawing.Size(367, 21);
            this.txtTitula.TabIndex = 24;
            // 
            // lblTitula
            // 
            this.lblTitula.AutoSize = true;
            this.lblTitula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitula.Location = new System.Drawing.Point(17, 130);
            this.lblTitula.Name = "lblTitula";
            this.lblTitula.Size = new System.Drawing.Size(40, 15);
            this.lblTitula.TabIndex = 23;
            this.lblTitula.Text = "Titula:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrezime.Location = new System.Drawing.Point(188, 98);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(200, 21);
            this.txtPrezime.TabIndex = 22;
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.Location = new System.Drawing.Point(20, 98);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(159, 21);
            this.txtIme.TabIndex = 21;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(186, 78);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(61, 15);
            this.lblPrezime.TabIndex = 20;
            this.lblPrezime.Text = "*Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(18, 78);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(36, 15);
            this.lblIme.TabIndex = 19;
            this.lblIme.Text = "*Ime:";
            // 
            // gbAdresa
            // 
            this.gbAdresa.Controls.Add(this.txtMjesto);
            this.gbAdresa.Controls.Add(this.lblMjesto);
            this.gbAdresa.Controls.Add(this.txtUlica);
            this.gbAdresa.Controls.Add(this.lblUlica);
            this.gbAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbAdresa.Location = new System.Drawing.Point(298, 272);
            this.gbAdresa.Name = "gbAdresa";
            this.gbAdresa.Size = new System.Drawing.Size(319, 150);
            this.gbAdresa.TabIndex = 49;
            this.gbAdresa.TabStop = false;
            this.gbAdresa.Text = "Adresa";
            // 
            // txtMjesto
            // 
            this.txtMjesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMjesto.Location = new System.Drawing.Point(14, 51);
            this.txtMjesto.Name = "txtMjesto";
            this.txtMjesto.Size = new System.Drawing.Size(290, 21);
            this.txtMjesto.TabIndex = 26;
            // 
            // lblMjesto
            // 
            this.lblMjesto.AutoSize = true;
            this.lblMjesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMjesto.Location = new System.Drawing.Point(12, 31);
            this.lblMjesto.Name = "lblMjesto";
            this.lblMjesto.Size = new System.Drawing.Size(47, 15);
            this.lblMjesto.TabIndex = 19;
            this.lblMjesto.Text = "Mjesto:";
            // 
            // txtUlica
            // 
            this.txtUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUlica.Location = new System.Drawing.Point(14, 102);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(290, 21);
            this.txtUlica.TabIndex = 27;
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUlica.Location = new System.Drawing.Point(14, 82);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(38, 15);
            this.lblUlica.TabIndex = 25;
            this.lblUlica.Text = "Ulica:";
            // 
            // gbKontakt
            // 
            this.gbKontakt.Controls.Add(this.txtEmail);
            this.gbKontakt.Controls.Add(this.lblEmail);
            this.gbKontakt.Controls.Add(this.lblMobitel);
            this.gbKontakt.Controls.Add(this.txtMobitel);
            this.gbKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbKontakt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbKontakt.Location = new System.Drawing.Point(45, 272);
            this.gbKontakt.Name = "gbKontakt";
            this.gbKontakt.Size = new System.Drawing.Size(244, 150);
            this.gbKontakt.TabIndex = 48;
            this.gbKontakt.TabStop = false;
            this.gbKontakt.Text = "Kontakt";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmail.Location = new System.Drawing.Point(19, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 21);
            this.txtEmail.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(17, 26);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "*Email:";
            // 
            // lblMobitel
            // 
            this.lblMobitel.AutoSize = true;
            this.lblMobitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMobitel.Location = new System.Drawing.Point(17, 86);
            this.lblMobitel.Name = "lblMobitel";
            this.lblMobitel.Size = new System.Drawing.Size(51, 15);
            this.lblMobitel.TabIndex = 17;
            this.lblMobitel.Text = "Mobitel:";
            // 
            // txtMobitel
            // 
            this.txtMobitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMobitel.Location = new System.Drawing.Point(19, 106);
            this.txtMobitel.Name = "txtMobitel";
            this.txtMobitel.Size = new System.Drawing.Size(210, 21);
            this.txtMobitel.TabIndex = 24;
            // 
            // pbSlikaInstruktora
            // 
            this.pbSlikaInstruktora.Location = new System.Drawing.Point(48, 44);
            this.pbSlikaInstruktora.Name = "pbSlikaInstruktora";
            this.pbSlikaInstruktora.Size = new System.Drawing.Size(156, 148);
            this.pbSlikaInstruktora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlikaInstruktora.TabIndex = 54;
            this.pbSlikaInstruktora.TabStop = false;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnDodajSliku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajSliku.Location = new System.Drawing.Point(46, 227);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(63, 29);
            this.btnDodajSliku.TabIndex = 88;
            this.btnDodajSliku.Text = "DODAJ";
            this.btnDodajSliku.UseVisualStyleBackColor = false;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.Filter = "|*.png";
            // 
            // btnUkloniSliku
            // 
            this.btnUkloniSliku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnUkloniSliku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUkloniSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUkloniSliku.Location = new System.Drawing.Point(144, 227);
            this.btnUkloniSliku.Name = "btnUkloniSliku";
            this.btnUkloniSliku.Size = new System.Drawing.Size(63, 29);
            this.btnUkloniSliku.TabIndex = 89;
            this.btnUkloniSliku.Text = "UKLONI";
            this.btnUkloniSliku.UseVisualStyleBackColor = false;
            this.btnUkloniSliku.Click += new System.EventHandler(this.btnUkloniSliku_Click);
            // 
            // cbZadanaSlika
            // 
            this.cbZadanaSlika.AutoSize = true;
            this.cbZadanaSlika.Location = new System.Drawing.Point(49, 202);
            this.cbZadanaSlika.Name = "cbZadanaSlika";
            this.cbZadanaSlika.Size = new System.Drawing.Size(116, 17);
            this.cbZadanaSlika.TabIndex = 90;
            this.cbZadanaSlika.Text = "Koristi zadanu sliku";
            this.cbZadanaSlika.UseVisualStyleBackColor = true;
            // 
            // frmOMeniInstruktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(667, 630);
            this.Controls.Add(this.cbZadanaSlika);
            this.Controls.Add(this.btnUkloniSliku);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.pbSlikaInstruktora);
            this.Controls.Add(this.gbKratkiOpis);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.gbOsnovno);
            this.Controls.Add(this.gbAdresa);
            this.Controls.Add(this.gbKontakt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOMeniInstruktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "O Meni ";
            this.Load += new System.EventHandler(this.frmOMeniInstruktor_Load);
            this.gbKratkiOpis.ResumeLayout(false);
            this.gbKratkiOpis.PerformLayout();
            this.gbOsnovno.ResumeLayout(false);
            this.gbOsnovno.PerformLayout();
            this.gbAdresa.ResumeLayout(false);
            this.gbAdresa.PerformLayout();
            this.gbKontakt.ResumeLayout(false);
            this.gbKontakt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaInstruktora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKratkiOpis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.GroupBox gbOsnovno;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.TextBox txtTitula;
        private System.Windows.Forms.Label lblTitula;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.GroupBox gbAdresa;
        private System.Windows.Forms.TextBox txtMjesto;
        private System.Windows.Forms.Label lblMjesto;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.GroupBox gbKontakt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobitel;
        private System.Windows.Forms.TextBox txtMobitel;
        private System.Windows.Forms.PictureBox pbSlikaInstruktora;
        private System.Windows.Forms.Button btnDodajSliku;
        public System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.Button btnUkloniSliku;
        private System.Windows.Forms.CheckBox cbZadanaSlika;
    }
}