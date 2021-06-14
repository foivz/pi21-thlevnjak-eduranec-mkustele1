
namespace FindAndLearn.Tražilica
{
    partial class frmTrazilica
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
            this.gbInstruktor = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblTrazilica = new System.Windows.Forms.Label();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnTrazilica = new System.Windows.Forms.Button();
            this.gbProfil = new System.Windows.Forms.GroupBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKolegij = new System.Windows.Forms.Label();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.txtKolegij = new System.Windows.Forms.TextBox();
            this.txtInstruktor = new System.Windows.Forms.TextBox();
            this.dtgSviInstruktoriNaKolegiju = new System.Windows.Forms.DataGridView();
            this.lblNaslovDatagrida = new System.Windows.Forms.Label();
            this.btnDetaljiInstruktora = new System.Windows.Forms.Button();
            this.gbInstruktor.SuspendLayout();
            this.gbIzbornik.SuspendLayout();
            this.gbProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSviInstruktoriNaKolegiju)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInstruktor
            // 
            this.gbInstruktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbInstruktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblTrazilica);
            this.gbInstruktor.Location = new System.Drawing.Point(174, -9);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Size = new System.Drawing.Size(907, 49);
            this.gbInstruktor.TabIndex = 78;
            this.gbInstruktor.TabStop = false;
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
            // 
            // lblTrazilica
            // 
            this.lblTrazilica.AutoSize = true;
            this.lblTrazilica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrazilica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblTrazilica.Location = new System.Drawing.Point(58, 17);
            this.lblTrazilica.Name = "lblTrazilica";
            this.lblTrazilica.Size = new System.Drawing.Size(68, 16);
            this.lblTrazilica.TabIndex = 3;
            this.lblTrazilica.Text = "Tražilica";
            // 
            // gbIzbornik
            // 
            this.gbIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbIzbornik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbIzbornik.Controls.Add(this.btnZatvori);
            this.gbIzbornik.Controls.Add(this.btnTrazilica);
            this.gbIzbornik.Location = new System.Drawing.Point(-6, 33);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Size = new System.Drawing.Size(217, 657);
            this.gbIzbornik.TabIndex = 79;
            this.gbIzbornik.TabStop = false;
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatvori.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZatvori.Location = new System.Drawing.Point(17, 536);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(184, 31);
            this.btnZatvori.TabIndex = 30;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnTrazilica
            // 
            this.btnTrazilica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnTrazilica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrazilica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrazilica.Location = new System.Drawing.Point(17, 48);
            this.btnTrazilica.Name = "btnTrazilica";
            this.btnTrazilica.Size = new System.Drawing.Size(184, 31);
            this.btnTrazilica.TabIndex = 29;
            this.btnTrazilica.Text = "TRAŽILICA";
            this.btnTrazilica.UseVisualStyleBackColor = false;
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
            this.pbLogo.Location = new System.Drawing.Point(-1, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(79, 59);
            this.pbLogo.TabIndex = 70;
            this.pbLogo.TabStop = false;
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
            // lblKolegij
            // 
            this.lblKolegij.AutoSize = true;
            this.lblKolegij.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolegij.Location = new System.Drawing.Point(232, 81);
            this.lblKolegij.Name = "lblKolegij";
            this.lblKolegij.Size = new System.Drawing.Size(81, 17);
            this.lblKolegij.TabIndex = 81;
            this.lblKolegij.Text = "Po kolegiju:";
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInstruktor.Location = new System.Drawing.Point(503, 81);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(100, 17);
            this.lblInstruktor.TabIndex = 81;
            this.lblInstruktor.Text = "Po instruktoru:";
            // 
            // txtKolegij
            // 
            this.txtKolegij.Location = new System.Drawing.Point(235, 104);
            this.txtKolegij.Name = "txtKolegij";
            this.txtKolegij.Size = new System.Drawing.Size(218, 20);
            this.txtKolegij.TabIndex = 82;
            this.txtKolegij.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKolegij_KeyUp);
            // 
            // txtInstruktor
            // 
            this.txtInstruktor.Location = new System.Drawing.Point(506, 104);
            this.txtInstruktor.Name = "txtInstruktor";
            this.txtInstruktor.Size = new System.Drawing.Size(218, 20);
            this.txtInstruktor.TabIndex = 82;
            this.txtInstruktor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInstruktor_KeyUp);
            // 
            // dtgSviInstruktoriNaKolegiju
            // 
            this.dtgSviInstruktoriNaKolegiju.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgSviInstruktoriNaKolegiju.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSviInstruktoriNaKolegiju.Location = new System.Drawing.Point(235, 159);
            this.dtgSviInstruktoriNaKolegiju.Name = "dtgSviInstruktoriNaKolegiju";
            this.dtgSviInstruktoriNaKolegiju.Size = new System.Drawing.Size(704, 441);
            this.dtgSviInstruktoriNaKolegiju.TabIndex = 84;
            // 
            // lblNaslovDatagrida
            // 
            this.lblNaslovDatagrida.AutoSize = true;
            this.lblNaslovDatagrida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovDatagrida.Location = new System.Drawing.Point(232, 139);
            this.lblNaslovDatagrida.Name = "lblNaslovDatagrida";
            this.lblNaslovDatagrida.Size = new System.Drawing.Size(34, 17);
            this.lblNaslovDatagrida.TabIndex = 81;
            this.lblNaslovDatagrida.Text = "asd";
            // 
            // btnDetaljiInstruktora
            // 
            this.btnDetaljiInstruktora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnDetaljiInstruktora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetaljiInstruktora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetaljiInstruktora.Location = new System.Drawing.Point(768, 94);
            this.btnDetaljiInstruktora.Name = "btnDetaljiInstruktora";
            this.btnDetaljiInstruktora.Size = new System.Drawing.Size(150, 30);
            this.btnDetaljiInstruktora.TabIndex = 97;
            this.btnDetaljiInstruktora.Text = "Detalji o instruktoru";
            this.btnDetaljiInstruktora.UseVisualStyleBackColor = false;
            this.btnDetaljiInstruktora.Click += new System.EventHandler(this.btnDetaljiInstruktora_Click);
            // 
            // frmTrazilica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 612);
            this.Controls.Add(this.btnDetaljiInstruktora);
            this.Controls.Add(this.dtgSviInstruktoriNaKolegiju);
            this.Controls.Add(this.txtInstruktor);
            this.Controls.Add(this.txtKolegij);
            this.Controls.Add(this.lblInstruktor);
            this.Controls.Add(this.lblNaslovDatagrida);
            this.Controls.Add(this.lblKolegij);
            this.Controls.Add(this.gbProfil);
            this.Controls.Add(this.gbIzbornik);
            this.Controls.Add(this.gbInstruktor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTrazilica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tražilica";
            this.Load += new System.EventHandler(this.frmTrazilica_Load);
            this.gbInstruktor.ResumeLayout(false);
            this.gbInstruktor.PerformLayout();
            this.gbIzbornik.ResumeLayout(false);
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSviInstruktoriNaKolegiju)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInstruktor;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblTrazilica;
        private System.Windows.Forms.GroupBox gbIzbornik;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnTrazilica;
        private System.Windows.Forms.GroupBox gbProfil;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKolegij;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.TextBox txtKolegij;
        private System.Windows.Forms.TextBox txtInstruktor;
        private System.Windows.Forms.DataGridView dtgSviInstruktoriNaKolegiju;
        private System.Windows.Forms.Label lblNaslovDatagrida;
        private System.Windows.Forms.Button btnDetaljiInstruktora;
    }
}