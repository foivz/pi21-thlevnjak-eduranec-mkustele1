
namespace FindAndLearn.Registracija
{
    partial class frmRegistracija
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
            this.cbPokaziLozinku = new System.Windows.Forms.CheckBox();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblUloga = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.comboUloga = new System.Windows.Forms.ComboBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.cbKoristiGeneriranoKorisnickoIme = new System.Windows.Forms.CheckBox();
            this.lblPonovljenaLozinka = new System.Windows.Forms.Label();
            this.txtPonovljenaLozinka = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMobitel = new System.Windows.Forms.Label();
            this.txtMobitel = new System.Windows.Forms.TextBox();
            this.lblMjesto = new System.Windows.Forms.Label();
            this.txtMjesto = new System.Windows.Forms.TextBox();
            this.lblUlica = new System.Windows.Forms.Label();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cbPokaziPonovljenuLozinku = new System.Windows.Forms.CheckBox();
            this.lblTitula = new System.Windows.Forms.Label();
            this.txtTitula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPokaziLozinku
            // 
            this.cbPokaziLozinku.AutoSize = true;
            this.cbPokaziLozinku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPokaziLozinku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.cbPokaziLozinku.Location = new System.Drawing.Point(648, 232);
            this.cbPokaziLozinku.Name = "cbPokaziLozinku";
            this.cbPokaziLozinku.Size = new System.Drawing.Size(112, 20);
            this.cbPokaziLozinku.TabIndex = 13;
            this.cbPokaziLozinku.Text = "Pokaži lozinku";
            this.cbPokaziLozinku.UseVisualStyleBackColor = true;
            this.cbPokaziLozinku.CheckedChanged += new System.EventHandler(this.cbPokaziLozinku_CheckedChanged);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnRegistracija.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegistracija.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistracija.Location = new System.Drawing.Point(280, 530);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(280, 35);
            this.btnRegistracija.TabIndex = 14;
            this.btnRegistracija.Text = "REGISTRIRAJ SE";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.Location = new System.Drawing.Point(40, 280);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(281, 22);
            this.txtIme.TabIndex = 2;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblIme.Location = new System.Drawing.Point(40, 260);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(43, 16);
            this.lblIme.TabIndex = 77;
            this.lblIme.Text = "*Ime:";
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUloga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblUloga.Location = new System.Drawing.Point(40, 160);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(60, 16);
            this.lblUloga.TabIndex = 0;
            this.lblUloga.Text = "*Uloga:";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::FindAndLearn.Properties.Resources.PrijavaLogo;
            this.pbLogo.Location = new System.Drawing.Point(340, 30);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(155, 109);
            this.pbLogo.TabIndex = 84;
            this.pbLogo.TabStop = false;
            // 
            // comboUloga
            // 
            this.comboUloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboUloga.FormattingEnabled = true;
            this.comboUloga.Location = new System.Drawing.Point(40, 180);
            this.comboUloga.Name = "comboUloga";
            this.comboUloga.Size = new System.Drawing.Size(281, 24);
            this.comboUloga.TabIndex = 1;
            this.comboUloga.SelectedValueChanged += new System.EventHandler(this.comboUloga_SelectedValueChanged);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblPrezime.Location = new System.Drawing.Point(40, 310);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(74, 16);
            this.lblPrezime.TabIndex = 77;
            this.lblPrezime.Text = "*Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrezime.Location = new System.Drawing.Point(40, 330);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(281, 22);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrezime_KeyUp);
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(361, 160);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(119, 16);
            this.lblKorisnickoIme.TabIndex = 77;
            this.lblKorisnickoIme.Text = "*Korisničko ime:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnickoIme.Location = new System.Drawing.Point(361, 180);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(281, 22);
            this.txtKorisnickoIme.TabIndex = 4;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblLozinka.Location = new System.Drawing.Point(361, 210);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(71, 16);
            this.lblLozinka.TabIndex = 77;
            this.lblLozinka.Text = "*Lozinka:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLozinka.Location = new System.Drawing.Point(361, 230);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(281, 22);
            this.txtLozinka.TabIndex = 6;
            // 
            // cbKoristiGeneriranoKorisnickoIme
            // 
            this.cbKoristiGeneriranoKorisnickoIme.AutoSize = true;
            this.cbKoristiGeneriranoKorisnickoIme.Checked = true;
            this.cbKoristiGeneriranoKorisnickoIme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKoristiGeneriranoKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKoristiGeneriranoKorisnickoIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.cbKoristiGeneriranoKorisnickoIme.Location = new System.Drawing.Point(648, 180);
            this.cbKoristiGeneriranoKorisnickoIme.Name = "cbKoristiGeneriranoKorisnickoIme";
            this.cbKoristiGeneriranoKorisnickoIme.Size = new System.Drawing.Size(131, 20);
            this.cbKoristiGeneriranoKorisnickoIme.TabIndex = 5;
            this.cbKoristiGeneriranoKorisnickoIme.Text = "Koristi generirano";
            this.cbKoristiGeneriranoKorisnickoIme.UseVisualStyleBackColor = true;
            this.cbKoristiGeneriranoKorisnickoIme.CheckedChanged += new System.EventHandler(this.cbKoristiGeneriranoKorisnickoIme_CheckedChanged);
            // 
            // lblPonovljenaLozinka
            // 
            this.lblPonovljenaLozinka.AutoSize = true;
            this.lblPonovljenaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPonovljenaLozinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblPonovljenaLozinka.Location = new System.Drawing.Point(361, 260);
            this.lblPonovljenaLozinka.Name = "lblPonovljenaLozinka";
            this.lblPonovljenaLozinka.Size = new System.Drawing.Size(149, 16);
            this.lblPonovljenaLozinka.TabIndex = 77;
            this.lblPonovljenaLozinka.Text = "*Ponovljena lozinka:";
            // 
            // txtPonovljenaLozinka
            // 
            this.txtPonovljenaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPonovljenaLozinka.Location = new System.Drawing.Point(361, 280);
            this.txtPonovljenaLozinka.Name = "txtPonovljenaLozinka";
            this.txtPonovljenaLozinka.PasswordChar = '*';
            this.txtPonovljenaLozinka.Size = new System.Drawing.Size(281, 22);
            this.txtPonovljenaLozinka.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblEmail.Location = new System.Drawing.Point(361, 310);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 16);
            this.lblEmail.TabIndex = 77;
            this.lblEmail.Text = "*Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmail.Location = new System.Drawing.Point(361, 330);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(418, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // lblMobitel
            // 
            this.lblMobitel.AutoSize = true;
            this.lblMobitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMobitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblMobitel.Location = new System.Drawing.Point(40, 360);
            this.lblMobitel.Name = "lblMobitel";
            this.lblMobitel.Size = new System.Drawing.Size(104, 16);
            this.lblMobitel.TabIndex = 77;
            this.lblMobitel.Text = "Broj mobitela:";
            // 
            // txtMobitel
            // 
            this.txtMobitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMobitel.Location = new System.Drawing.Point(40, 380);
            this.txtMobitel.Name = "txtMobitel";
            this.txtMobitel.Size = new System.Drawing.Size(281, 22);
            this.txtMobitel.TabIndex = 9;
            // 
            // lblMjesto
            // 
            this.lblMjesto.AutoSize = true;
            this.lblMjesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMjesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblMjesto.Location = new System.Drawing.Point(40, 410);
            this.lblMjesto.Name = "lblMjesto";
            this.lblMjesto.Size = new System.Drawing.Size(58, 16);
            this.lblMjesto.TabIndex = 77;
            this.lblMjesto.Text = "Mjesto:";
            // 
            // txtMjesto
            // 
            this.txtMjesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMjesto.Location = new System.Drawing.Point(40, 430);
            this.txtMjesto.Name = "txtMjesto";
            this.txtMjesto.Size = new System.Drawing.Size(281, 22);
            this.txtMjesto.TabIndex = 10;
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUlica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblUlica.Location = new System.Drawing.Point(40, 460);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(48, 16);
            this.lblUlica.TabIndex = 77;
            this.lblUlica.Text = "Ulica:";
            // 
            // txtUlica
            // 
            this.txtUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUlica.Location = new System.Drawing.Point(40, 480);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(281, 22);
            this.txtUlica.TabIndex = 11;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblOpis.Location = new System.Drawing.Point(361, 360);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(44, 16);
            this.lblOpis.TabIndex = 77;
            this.lblOpis.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(361, 380);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(418, 122);
            this.txtOpis.TabIndex = 12;
            // 
            // cbPokaziPonovljenuLozinku
            // 
            this.cbPokaziPonovljenuLozinku.AutoSize = true;
            this.cbPokaziPonovljenuLozinku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPokaziPonovljenuLozinku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.cbPokaziPonovljenuLozinku.Location = new System.Drawing.Point(648, 280);
            this.cbPokaziPonovljenuLozinku.Name = "cbPokaziPonovljenuLozinku";
            this.cbPokaziPonovljenuLozinku.Size = new System.Drawing.Size(137, 20);
            this.cbPokaziPonovljenuLozinku.TabIndex = 13;
            this.cbPokaziPonovljenuLozinku.Text = "Pokaži ponovljenu";
            this.cbPokaziPonovljenuLozinku.UseVisualStyleBackColor = true;
            this.cbPokaziPonovljenuLozinku.CheckedChanged += new System.EventHandler(this.cbPokaziPonovljenuLozinku_CheckedChanged);
            // 
            // lblTitula
            // 
            this.lblTitula.AutoSize = true;
            this.lblTitula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblTitula.Location = new System.Drawing.Point(40, 210);
            this.lblTitula.Name = "lblTitula";
            this.lblTitula.Size = new System.Drawing.Size(51, 16);
            this.lblTitula.TabIndex = 77;
            this.lblTitula.Text = "Titula:";
            // 
            // txtTitula
            // 
            this.txtTitula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTitula.Location = new System.Drawing.Point(40, 230);
            this.txtTitula.Name = "txtTitula";
            this.txtTitula.Size = new System.Drawing.Size(281, 22);
            this.txtTitula.TabIndex = 2;
            // 
            // frmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(824, 601);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.comboUloga);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.cbKoristiGeneriranoKorisnickoIme);
            this.Controls.Add(this.cbPokaziPonovljenuLozinku);
            this.Controls.Add(this.cbPokaziLozinku);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.lblUlica);
            this.Controls.Add(this.txtMjesto);
            this.Controls.Add(this.lblMjesto);
            this.Controls.Add(this.txtMobitel);
            this.Controls.Add(this.lblMobitel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPonovljenaLozinka);
            this.Controls.Add(this.lblPonovljenaLozinka);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtTitula);
            this.Controls.Add(this.lblTitula);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblUloga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.frmRegistracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.CheckBox cbPokaziLozinku;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.ComboBox comboUloga;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.CheckBox cbKoristiGeneriranoKorisnickoIme;
        private System.Windows.Forms.Label lblPonovljenaLozinka;
        private System.Windows.Forms.TextBox txtPonovljenaLozinka;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblMobitel;
        private System.Windows.Forms.TextBox txtMobitel;
        private System.Windows.Forms.Label lblMjesto;
        private System.Windows.Forms.TextBox txtMjesto;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.CheckBox cbPokaziPonovljenuLozinku;
        private System.Windows.Forms.Label lblTitula;
        private System.Windows.Forms.TextBox txtTitula;
    }
}