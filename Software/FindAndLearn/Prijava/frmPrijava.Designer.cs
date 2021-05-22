
namespace FindAndLearn
{
    partial class frmPrijava
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
            this.llblPromjenaLozinke = new System.Windows.Forms.LinkLabel();
            this.cbPokaziLozinku = new System.Windows.Forms.CheckBox();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // llblPromjenaLozinke
            // 
            this.llblPromjenaLozinke.ActiveLinkColor = System.Drawing.Color.White;
            this.llblPromjenaLozinke.AutoSize = true;
            this.llblPromjenaLozinke.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblPromjenaLozinke.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.llblPromjenaLozinke.Location = new System.Drawing.Point(141, 387);
            this.llblPromjenaLozinke.Name = "llblPromjenaLozinke";
            this.llblPromjenaLozinke.Size = new System.Drawing.Size(111, 18);
            this.llblPromjenaLozinke.TabIndex = 74;
            this.llblPromjenaLozinke.TabStop = true;
            this.llblPromjenaLozinke.Text = "Promijeni lozinku";
            this.llblPromjenaLozinke.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblPromjenaLozinke_LinkClicked);
            // 
            // cbPokaziLozinku
            // 
            this.cbPokaziLozinku.AutoSize = true;
            this.cbPokaziLozinku.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPokaziLozinku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.cbPokaziLozinku.Location = new System.Drawing.Point(58, 281);
            this.cbPokaziLozinku.Name = "cbPokaziLozinku";
            this.cbPokaziLozinku.Size = new System.Drawing.Size(112, 22);
            this.cbPokaziLozinku.TabIndex = 73;
            this.cbPokaziLozinku.Text = "Pokaži lozinku";
            this.cbPokaziLozinku.UseVisualStyleBackColor = true;
            this.cbPokaziLozinku.CheckedChanged += new System.EventHandler(this.cbPokaziLozinku_CheckedChanged);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnRegistracija.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistracija.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegistracija.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistracija.Location = new System.Drawing.Point(206, 326);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(129, 35);
            this.btnRegistracija.TabIndex = 72;
            this.btnRegistracija.Text = "REGISTRIRAJ SE";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrijava.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijava.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrijava.Location = new System.Drawing.Point(56, 326);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(125, 35);
            this.btnPrijava.TabIndex = 71;
            this.btnPrijava.Text = "PRIJAVA";
            this.btnPrijava.UseVisualStyleBackColor = false;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLozinka.Location = new System.Drawing.Point(55, 246);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(281, 25);
            this.txtLozinka.TabIndex = 69;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnickoIme.Location = new System.Drawing.Point(55, 183);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(280, 25);
            this.txtKorisnickoIme.TabIndex = 68;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblLozinka.Location = new System.Drawing.Point(55, 223);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(69, 18);
            this.lblLozinka.TabIndex = 67;
            this.lblLozinka.Text = "*Lozinka:";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(54, 161);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(116, 18);
            this.lblKorisnickoIme.TabIndex = 66;
            this.lblKorisnickoIme.Text = "*Korisničko ime:";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::FindAndLearn.Properties.Resources.PrijavaLogo;
            this.pbLogo.Location = new System.Drawing.Point(118, 30);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(155, 109);
            this.pbLogo.TabIndex = 75;
            this.pbLogo.TabStop = false;
            // 
            // frmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(384, 437);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.llblPromjenaLozinke);
            this.Controls.Add(this.cbPokaziLozinku);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Name = "frmPrijava";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.frmPrijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblPromjenaLozinke;
        private System.Windows.Forms.CheckBox cbPokaziLozinku;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

