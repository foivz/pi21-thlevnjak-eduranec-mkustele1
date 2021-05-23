
namespace FindAndLearn.Prijava
{
    partial class frmPromjenaLozinke
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
            this.txtPonovljenaLozinka = new System.Windows.Forms.TextBox();
            this.lblPonoviLozinku = new System.Windows.Forms.Label();
            this.txtNovaLozinka = new System.Windows.Forms.TextBox();
            this.lblNovaLozinka = new System.Windows.Forms.Label();
            this.cbPokaziLozinke = new System.Windows.Forms.CheckBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtTrenutnaLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblTrenutnaLozinka = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNatrag.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNatrag.Location = new System.Drawing.Point(54, 439);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(134, 32);
            this.btnNatrag.TabIndex = 86;
            this.btnNatrag.Text = "NATRAG";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // txtPonovljenaLozinka
            // 
            this.txtPonovljenaLozinka.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPonovljenaLozinka.Location = new System.Drawing.Point(55, 359);
            this.txtPonovljenaLozinka.Name = "txtPonovljenaLozinka";
            this.txtPonovljenaLozinka.PasswordChar = '*';
            this.txtPonovljenaLozinka.Size = new System.Drawing.Size(281, 25);
            this.txtPonovljenaLozinka.TabIndex = 85;
            // 
            // lblPonoviLozinku
            // 
            this.lblPonoviLozinku.AutoSize = true;
            this.lblPonoviLozinku.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPonoviLozinku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblPonoviLozinku.Location = new System.Drawing.Point(53, 338);
            this.lblPonoviLozinku.Name = "lblPonoviLozinku";
            this.lblPonoviLozinku.Size = new System.Drawing.Size(114, 18);
            this.lblPonoviLozinku.TabIndex = 84;
            this.lblPonoviLozinku.Text = "*Ponovi lozinku:";
            // 
            // txtNovaLozinka
            // 
            this.txtNovaLozinka.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNovaLozinka.Location = new System.Drawing.Point(56, 297);
            this.txtNovaLozinka.Name = "txtNovaLozinka";
            this.txtNovaLozinka.PasswordChar = '*';
            this.txtNovaLozinka.Size = new System.Drawing.Size(281, 25);
            this.txtNovaLozinka.TabIndex = 83;
            // 
            // lblNovaLozinka
            // 
            this.lblNovaLozinka.AutoSize = true;
            this.lblNovaLozinka.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNovaLozinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblNovaLozinka.Location = new System.Drawing.Point(56, 274);
            this.lblNovaLozinka.Name = "lblNovaLozinka";
            this.lblNovaLozinka.Size = new System.Drawing.Size(103, 18);
            this.lblNovaLozinka.TabIndex = 82;
            this.lblNovaLozinka.Text = "*Nova lozinka:";
            // 
            // cbPokaziLozinke
            // 
            this.cbPokaziLozinke.AutoSize = true;
            this.cbPokaziLozinke.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPokaziLozinke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.cbPokaziLozinke.Location = new System.Drawing.Point(59, 398);
            this.cbPokaziLozinke.Name = "cbPokaziLozinke";
            this.cbPokaziLozinke.Size = new System.Drawing.Size(111, 22);
            this.cbPokaziLozinke.TabIndex = 81;
            this.cbPokaziLozinke.Text = "Pokaži lozinke";
            this.cbPokaziLozinke.UseVisualStyleBackColor = true;
            this.cbPokaziLozinke.CheckedChanged += new System.EventHandler(this.cbPokaziLozinke_CheckedChanged);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpremi.Location = new System.Drawing.Point(202, 439);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(134, 32);
            this.btnSpremi.TabIndex = 80;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = false;
            // 
            // txtTrenutnaLozinka
            // 
            this.txtTrenutnaLozinka.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTrenutnaLozinka.Location = new System.Drawing.Point(56, 220);
            this.txtTrenutnaLozinka.Name = "txtTrenutnaLozinka";
            this.txtTrenutnaLozinka.PasswordChar = '*';
            this.txtTrenutnaLozinka.Size = new System.Drawing.Size(281, 25);
            this.txtTrenutnaLozinka.TabIndex = 79;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnickoIme.Location = new System.Drawing.Point(56, 164);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(280, 25);
            this.txtKorisnickoIme.TabIndex = 78;
            // 
            // lblTrenutnaLozinka
            // 
            this.lblTrenutnaLozinka.AutoSize = true;
            this.lblTrenutnaLozinka.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrenutnaLozinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblTrenutnaLozinka.Location = new System.Drawing.Point(56, 197);
            this.lblTrenutnaLozinka.Name = "lblTrenutnaLozinka";
            this.lblTrenutnaLozinka.Size = new System.Drawing.Size(132, 18);
            this.lblTrenutnaLozinka.TabIndex = 77;
            this.lblTrenutnaLozinka.Text = "*Trenutna lozinka:";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(55, 142);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(116, 18);
            this.lblKorisnickoIme.TabIndex = 76;
            this.lblKorisnickoIme.Text = "*Korisničko ime:";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::FindAndLearn.Properties.Resources.PrijavaLogo;
            this.pbLogo.Location = new System.Drawing.Point(118, 20);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(151, 107);
            this.pbLogo.TabIndex = 87;
            this.pbLogo.TabStop = false;
            // 
            // frmPromjenaLozinke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(400, 502);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.txtPonovljenaLozinka);
            this.Controls.Add(this.lblPonoviLozinku);
            this.Controls.Add(this.txtNovaLozinka);
            this.Controls.Add(this.lblNovaLozinka);
            this.Controls.Add(this.cbPokaziLozinke);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtTrenutnaLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.lblTrenutnaLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Name = "frmPromjenaLozinke";
            this.Text = "frmPromjenaLozinke";
            this.Load += new System.EventHandler(this.frmPromjenaLozinke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.TextBox txtPonovljenaLozinka;
        private System.Windows.Forms.Label lblPonoviLozinku;
        private System.Windows.Forms.TextBox txtNovaLozinka;
        private System.Windows.Forms.Label lblNovaLozinka;
        private System.Windows.Forms.CheckBox cbPokaziLozinke;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtTrenutnaLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label lblTrenutnaLozinka;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}