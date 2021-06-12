
namespace FindAndLearn.Controls
{
    partial class frmStudentPodaci
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
            this.btnNatrag = new System.Windows.Forms.Button();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.gbKratkiOpis = new System.Windows.Forms.GroupBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.gbKontakt = new System.Windows.Forms.GroupBox();
            this.lblPozivniBroj = new System.Windows.Forms.Label();
            this.lblUlica = new System.Windows.Forms.Label();
            this.lblMjesto = new System.Windows.Forms.Label();
            this.lblMobitel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pbSlikaStudenta = new System.Windows.Forms.PictureBox();
            this.pbMjesto = new System.Windows.Forms.PictureBox();
            this.pbTelefon = new System.Windows.Forms.PictureBox();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.gbKratkiOpis.SuspendLayout();
            this.gbKontakt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaStudenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMjesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelefon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNatrag.Location = new System.Drawing.Point(385, 375);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 102;
            this.btnNatrag.Text = "NATRAG";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImePrezime.Location = new System.Drawing.Point(26, 24);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(88, 15);
            this.lblImePrezime.TabIndex = 101;
            this.lblImePrezime.Text = "Ime Prezime";
            // 
            // gbKratkiOpis
            // 
            this.gbKratkiOpis.Controls.Add(this.txtOpis);
            this.gbKratkiOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbKratkiOpis.Location = new System.Drawing.Point(25, 225);
            this.gbKratkiOpis.Name = "gbKratkiOpis";
            this.gbKratkiOpis.Size = new System.Drawing.Size(435, 142);
            this.gbKratkiOpis.TabIndex = 100;
            this.gbKratkiOpis.TabStop = false;
            this.gbKratkiOpis.Text = "Kratki opis";
            // 
            // txtOpis
            // 
            this.txtOpis.BackColor = System.Drawing.SystemColors.Control;
            this.txtOpis.Location = new System.Drawing.Point(12, 24);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ReadOnly = true;
            this.txtOpis.Size = new System.Drawing.Size(410, 100);
            this.txtOpis.TabIndex = 39;
            // 
            // gbKontakt
            // 
            this.gbKontakt.Controls.Add(this.lblPozivniBroj);
            this.gbKontakt.Controls.Add(this.pbMjesto);
            this.gbKontakt.Controls.Add(this.pbTelefon);
            this.gbKontakt.Controls.Add(this.pbEmail);
            this.gbKontakt.Controls.Add(this.lblUlica);
            this.gbKontakt.Controls.Add(this.lblMjesto);
            this.gbKontakt.Controls.Add(this.lblMobitel);
            this.gbKontakt.Controls.Add(this.lblEmail);
            this.gbKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbKontakt.Location = new System.Drawing.Point(189, 47);
            this.gbKontakt.Name = "gbKontakt";
            this.gbKontakt.Size = new System.Drawing.Size(271, 158);
            this.gbKontakt.TabIndex = 98;
            this.gbKontakt.TabStop = false;
            this.gbKontakt.Text = "Kontakt";
            // 
            // lblPozivniBroj
            // 
            this.lblPozivniBroj.AutoSize = true;
            this.lblPozivniBroj.Location = new System.Drawing.Point(57, 64);
            this.lblPozivniBroj.Name = "lblPozivniBroj";
            this.lblPozivniBroj.Size = new System.Drawing.Size(0, 15);
            this.lblPozivniBroj.TabIndex = 19;
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.Location = new System.Drawing.Point(58, 117);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(35, 15);
            this.lblUlica.TabIndex = 15;
            this.lblUlica.Text = "Ulica";
            // 
            // lblMjesto
            // 
            this.lblMjesto.AutoSize = true;
            this.lblMjesto.Location = new System.Drawing.Point(57, 98);
            this.lblMjesto.Name = "lblMjesto";
            this.lblMjesto.Size = new System.Drawing.Size(44, 15);
            this.lblMjesto.TabIndex = 14;
            this.lblMjesto.Text = "Mjesto";
            // 
            // lblMobitel
            // 
            this.lblMobitel.AutoSize = true;
            this.lblMobitel.Location = new System.Drawing.Point(57, 64);
            this.lblMobitel.Name = "lblMobitel";
            this.lblMobitel.Size = new System.Drawing.Size(73, 15);
            this.lblMobitel.TabIndex = 13;
            this.lblMobitel.Text = "xxx xxx xxxx";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(57, 31);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(124, 15);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "ime.prezime@....com";
            // 
            // pbSlikaStudenta
            // 
            this.pbSlikaStudenta.Location = new System.Drawing.Point(28, 54);
            this.pbSlikaStudenta.Name = "pbSlikaStudenta";
            this.pbSlikaStudenta.Size = new System.Drawing.Size(154, 148);
            this.pbSlikaStudenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlikaStudenta.TabIndex = 99;
            this.pbSlikaStudenta.TabStop = false;
            // 
            // pbMjesto
            // 
            this.pbMjesto.BackgroundImage = global::FindAndLearn.Properties.Resources.Lokacija;
            this.pbMjesto.Location = new System.Drawing.Point(16, 95);
            this.pbMjesto.Name = "pbMjesto";
            this.pbMjesto.Size = new System.Drawing.Size(24, 22);
            this.pbMjesto.TabIndex = 18;
            this.pbMjesto.TabStop = false;
            // 
            // pbTelefon
            // 
            this.pbTelefon.BackgroundImage = global::FindAndLearn.Properties.Resources.Telefon;
            this.pbTelefon.Location = new System.Drawing.Point(16, 61);
            this.pbTelefon.Name = "pbTelefon";
            this.pbTelefon.Size = new System.Drawing.Size(24, 23);
            this.pbTelefon.TabIndex = 17;
            this.pbTelefon.TabStop = false;
            // 
            // pbEmail
            // 
            this.pbEmail.BackgroundImage = global::FindAndLearn.Properties.Resources.Email;
            this.pbEmail.Location = new System.Drawing.Point(16, 28);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(24, 26);
            this.pbEmail.TabIndex = 16;
            this.pbEmail.TabStop = false;
            // 
            // frmStudentPodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 426);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.gbKratkiOpis);
            this.Controls.Add(this.pbSlikaStudenta);
            this.Controls.Add(this.gbKontakt);
            this.Name = "frmStudentPodaci";
            this.Text = "Podaci o studentu";
            this.Load += new System.EventHandler(this.frmStudentPodaci_Load);
            this.gbKratkiOpis.ResumeLayout(false);
            this.gbKratkiOpis.PerformLayout();
            this.gbKontakt.ResumeLayout(false);
            this.gbKontakt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaStudenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMjesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelefon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.GroupBox gbKratkiOpis;
        private System.Windows.Forms.TextBox txtOpis;
        public System.Windows.Forms.PictureBox pbSlikaStudenta;
        private System.Windows.Forms.GroupBox gbKontakt;
        private System.Windows.Forms.Label lblPozivniBroj;
        private System.Windows.Forms.PictureBox pbMjesto;
        private System.Windows.Forms.PictureBox pbTelefon;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.Label lblMjesto;
        private System.Windows.Forms.Label lblMobitel;
        private System.Windows.Forms.Label lblEmail;
    }
}