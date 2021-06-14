
namespace FindAndLearn.Prijava
{
    partial class frmPocetnaInstruktor
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
            this.label2 = new System.Windows.Forms.Label();
            this.gbProfil = new System.Windows.Forms.GroupBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnObavijesti = new System.Windows.Forms.Button();
            this.btnPoruke = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnInstrukcije = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.lblDobrodoslica = new System.Windows.Forms.Label();
            this.lblFindAndLearn = new System.Windows.Forms.Label();
            this.gbInstruktor = new System.Windows.Forms.GroupBox();
            this.pbLogoNaslovna = new System.Windows.Forms.PictureBox();
            this.gbProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbIzbornik.SuspendLayout();
            this.gbInstruktor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoNaslovna)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(77, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Find and learn";
            // 
            // gbProfil
            // 
            this.gbProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbProfil.Controls.Add(this.pbLogo);
            this.gbProfil.Controls.Add(this.label2);
            this.gbProfil.Location = new System.Drawing.Point(-1, -10);
            this.gbProfil.Name = "gbProfil";
            this.gbProfil.Size = new System.Drawing.Size(211, 75);
            this.gbProfil.TabIndex = 80;
            this.gbProfil.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::FindAndLearn.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(76, 59);
            this.pbLogo.TabIndex = 69;
            this.pbLogo.TabStop = false;
            // 
            // gbIzbornik
            // 
            this.gbIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbIzbornik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbIzbornik.Controls.Add(this.btnRezervacije);
            this.gbIzbornik.Controls.Add(this.btnObavijesti);
            this.gbIzbornik.Controls.Add(this.btnPoruke);
            this.gbIzbornik.Controls.Add(this.btnProfil);
            this.gbIzbornik.Controls.Add(this.btnInstrukcije);
            this.gbIzbornik.Location = new System.Drawing.Point(-6, 33);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Size = new System.Drawing.Size(217, 657);
            this.gbIzbornik.TabIndex = 78;
            this.gbIzbornik.TabStop = false;
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRezervacije.Location = new System.Drawing.Point(20, 170);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(184, 31);
            this.btnRezervacije.TabIndex = 29;
            this.btnRezervacije.Text = "REZERVACIJE ";
            this.btnRezervacije.UseVisualStyleBackColor = false;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // btnObavijesti
            // 
            this.btnObavijesti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnObavijesti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObavijesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObavijesti.Location = new System.Drawing.Point(20, 130);
            this.btnObavijesti.Name = "btnObavijesti";
            this.btnObavijesti.Size = new System.Drawing.Size(184, 31);
            this.btnObavijesti.TabIndex = 28;
            this.btnObavijesti.Text = "OBAVIJESTI";
            this.btnObavijesti.UseVisualStyleBackColor = false;
            this.btnObavijesti.Click += new System.EventHandler(this.btnObavijesti_Click);
            // 
            // btnPoruke
            // 
            this.btnPoruke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnPoruke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPoruke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoruke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPoruke.Location = new System.Drawing.Point(20, 210);
            this.btnPoruke.Name = "btnPoruke";
            this.btnPoruke.Size = new System.Drawing.Size(184, 31);
            this.btnPoruke.TabIndex = 26;
            this.btnPoruke.Text = "PORUKE";
            this.btnPoruke.UseVisualStyleBackColor = false;
            this.btnPoruke.Click += new System.EventHandler(this.btnPoruke_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProfil.Location = new System.Drawing.Point(20, 50);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(184, 31);
            this.btnProfil.TabIndex = 25;
            this.btnProfil.Text = "PROFIL";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnInstrukcije
            // 
            this.btnInstrukcije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnInstrukcije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInstrukcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInstrukcije.Location = new System.Drawing.Point(20, 90);
            this.btnInstrukcije.Name = "btnInstrukcije";
            this.btnInstrukcije.Size = new System.Drawing.Size(184, 31);
            this.btnInstrukcije.TabIndex = 24;
            this.btnInstrukcije.Text = "INSTRUKCIJE";
            this.btnInstrukcije.UseVisualStyleBackColor = false;
            this.btnInstrukcije.Click += new System.EventHandler(this.btnInstrukcije_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.Location = new System.Drawing.Point(580, 15);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(90, 25);
            this.btnOdjava.TabIndex = 29;
            this.btnOdjava.Text = "ODJAVA";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.Location = new System.Drawing.Point(678, 15);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(90, 25);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.Text = "POMOĆ";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInstruktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblInstruktor.Location = new System.Drawing.Point(58, 17);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(128, 16);
            this.lblInstruktor.TabIndex = 3;
            this.lblInstruktor.Text = "Početna stranica ";
            // 
            // lblDobrodoslica
            // 
            this.lblDobrodoslica.AutoSize = true;
            this.lblDobrodoslica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDobrodoslica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.lblDobrodoslica.Location = new System.Drawing.Point(408, 481);
            this.lblDobrodoslica.Name = "lblDobrodoslica";
            this.lblDobrodoslica.Size = new System.Drawing.Size(372, 25);
            this.lblDobrodoslica.TabIndex = 82;
            this.lblDobrodoslica.Text = "Želimo ti dobrodošlicu u svijet znanja!";
            // 
            // lblFindAndLearn
            // 
            this.lblFindAndLearn.AutoSize = true;
            this.lblFindAndLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFindAndLearn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.lblFindAndLearn.Location = new System.Drawing.Point(472, 134);
            this.lblFindAndLearn.Name = "lblFindAndLearn";
            this.lblFindAndLearn.Size = new System.Drawing.Size(201, 33);
            this.lblFindAndLearn.TabIndex = 81;
            this.lblFindAndLearn.Text = "Find and learn";
            // 
            // gbInstruktor
            // 
            this.gbInstruktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbInstruktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInstruktor.Controls.Add(this.btnOdjava);
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblInstruktor);
            this.gbInstruktor.Location = new System.Drawing.Point(174, -9);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Size = new System.Drawing.Size(907, 49);
            this.gbInstruktor.TabIndex = 79;
            this.gbInstruktor.TabStop = false;
            // 
            // pbLogoNaslovna
            // 
            this.pbLogoNaslovna.BackgroundImage = global::FindAndLearn.Properties.Resources.FindAndLearn;
            this.pbLogoNaslovna.Location = new System.Drawing.Point(363, 196);
            this.pbLogoNaslovna.Name = "pbLogoNaslovna";
            this.pbLogoNaslovna.Size = new System.Drawing.Size(422, 266);
            this.pbLogoNaslovna.TabIndex = 83;
            this.pbLogoNaslovna.TabStop = false;
            // 
            // frmPocetnaInstruktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(962, 612);
            this.Controls.Add(this.pbLogoNaslovna);
            this.Controls.Add(this.gbProfil);
            this.Controls.Add(this.gbIzbornik);
            this.Controls.Add(this.lblDobrodoslica);
            this.Controls.Add(this.lblFindAndLearn);
            this.Controls.Add(this.gbInstruktor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPocetnaInstruktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Početna instruktor";
            this.Load += new System.EventHandler(this.frmPocetnaInstruktor_Load);
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbIzbornik.ResumeLayout(false);
            this.gbInstruktor.ResumeLayout(false);
            this.gbInstruktor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoNaslovna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbProfil;
        private System.Windows.Forms.GroupBox gbIzbornik;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button btnObavijesti;
        private System.Windows.Forms.Button btnPoruke;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnInstrukcije;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.Label lblDobrodoslica;
        private System.Windows.Forms.Label lblFindAndLearn;
        private System.Windows.Forms.GroupBox gbInstruktor;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbLogoNaslovna;
    }
}