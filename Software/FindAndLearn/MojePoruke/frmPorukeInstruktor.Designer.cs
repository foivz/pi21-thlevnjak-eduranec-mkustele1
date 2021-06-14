
namespace FindAndLearn.MojePoruke
{
    partial class frmPorukeInstruktor
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
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnPoruke = new System.Windows.Forms.Button();
            this.gbProfil = new System.Windows.Forms.GroupBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPopisPoruka = new System.Windows.Forms.DataGridView();
            this.btnDetaljiPoruke = new System.Windows.Forms.Button();
            this.btnPošalji = new System.Windows.Forms.Button();
            this.txtSadržajPoruke = new System.Windows.Forms.TextBox();
            this.txtNaslovPoruke = new System.Windows.Forms.TextBox();
            this.comboPrimatelj = new System.Windows.Forms.ComboBox();
            this.lblSadržajPoruke = new System.Windows.Forms.Label();
            this.lblNaslovPoruke = new System.Windows.Forms.Label();
            this.lblSvePoruke = new System.Windows.Forms.Label();
            this.lblPrimatelj = new System.Windows.Forms.Label();
            this.gbInstruktor.SuspendLayout();
            this.gbIzbornik.SuspendLayout();
            this.gbProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPoruka)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInstruktor
            // 
            this.gbInstruktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbInstruktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblInstruktor);
            this.gbInstruktor.Location = new System.Drawing.Point(174, -9);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Size = new System.Drawing.Size(907, 49);
            this.gbInstruktor.TabIndex = 82;
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
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInstruktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblInstruktor.Location = new System.Drawing.Point(58, 17);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(57, 16);
            this.lblInstruktor.TabIndex = 3;
            this.lblInstruktor.Text = "Poruke";
            // 
            // gbIzbornik
            // 
            this.gbIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbIzbornik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbIzbornik.Controls.Add(this.btnZatvori);
            this.gbIzbornik.Controls.Add(this.btnPoruke);
            this.gbIzbornik.Location = new System.Drawing.Point(-6, 33);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Size = new System.Drawing.Size(217, 657);
            this.gbIzbornik.TabIndex = 83;
            this.gbIzbornik.TabStop = false;
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatvori.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZatvori.Location = new System.Drawing.Point(18, 536);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(184, 31);
            this.btnZatvori.TabIndex = 30;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnPoruke
            // 
            this.btnPoruke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnPoruke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPoruke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoruke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPoruke.Location = new System.Drawing.Point(17, 48);
            this.btnPoruke.Name = "btnPoruke";
            this.btnPoruke.Size = new System.Drawing.Size(184, 31);
            this.btnPoruke.TabIndex = 30;
            this.btnPoruke.Text = "PORUKE";
            this.btnPoruke.UseVisualStyleBackColor = false;
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
            this.gbProfil.TabIndex = 84;
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
            // dgvPopisPoruka
            // 
            this.dgvPopisPoruka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisPoruka.Location = new System.Drawing.Point(585, 81);
            this.dgvPopisPoruka.Name = "dgvPopisPoruka";
            this.dgvPopisPoruka.Size = new System.Drawing.Size(357, 453);
            this.dgvPopisPoruka.TabIndex = 97;
            // 
            // btnDetaljiPoruke
            // 
            this.btnDetaljiPoruke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnDetaljiPoruke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetaljiPoruke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnDetaljiPoruke.Location = new System.Drawing.Point(792, 540);
            this.btnDetaljiPoruke.Name = "btnDetaljiPoruke";
            this.btnDetaljiPoruke.Size = new System.Drawing.Size(150, 30);
            this.btnDetaljiPoruke.TabIndex = 95;
            this.btnDetaljiPoruke.Text = "Detalji";
            this.btnDetaljiPoruke.UseVisualStyleBackColor = false;
            this.btnDetaljiPoruke.Click += new System.EventHandler(this.btnDetaljiPoruke_Click);
            // 
            // btnPošalji
            // 
            this.btnPošalji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnPošalji.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPošalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPošalji.Location = new System.Drawing.Point(407, 540);
            this.btnPošalji.Name = "btnPošalji";
            this.btnPošalji.Size = new System.Drawing.Size(150, 30);
            this.btnPošalji.TabIndex = 96;
            this.btnPošalji.Text = "Pošalji";
            this.btnPošalji.UseVisualStyleBackColor = false;
            this.btnPošalji.Click += new System.EventHandler(this.btnPošalji_Click);
            // 
            // txtSadržajPoruke
            // 
            this.txtSadržajPoruke.Location = new System.Drawing.Point(239, 169);
            this.txtSadržajPoruke.Multiline = true;
            this.txtSadržajPoruke.Name = "txtSadržajPoruke";
            this.txtSadržajPoruke.Size = new System.Drawing.Size(318, 365);
            this.txtSadržajPoruke.TabIndex = 93;
            // 
            // txtNaslovPoruke
            // 
            this.txtNaslovPoruke.Location = new System.Drawing.Point(239, 127);
            this.txtNaslovPoruke.Name = "txtNaslovPoruke";
            this.txtNaslovPoruke.Size = new System.Drawing.Size(318, 20);
            this.txtNaslovPoruke.TabIndex = 94;
            // 
            // comboPrimatelj
            // 
            this.comboPrimatelj.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPrimatelj.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPrimatelj.FormattingEnabled = true;
            this.comboPrimatelj.Location = new System.Drawing.Point(239, 81);
            this.comboPrimatelj.Name = "comboPrimatelj";
            this.comboPrimatelj.Size = new System.Drawing.Size(318, 21);
            this.comboPrimatelj.TabIndex = 92;
            // 
            // lblSadržajPoruke
            // 
            this.lblSadržajPoruke.AutoSize = true;
            this.lblSadržajPoruke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSadržajPoruke.Location = new System.Drawing.Point(236, 149);
            this.lblSadržajPoruke.Name = "lblSadržajPoruke";
            this.lblSadržajPoruke.Size = new System.Drawing.Size(60, 17);
            this.lblSadržajPoruke.TabIndex = 88;
            this.lblSadržajPoruke.Text = "Sadržaj:";
            // 
            // lblNaslovPoruke
            // 
            this.lblNaslovPoruke.AutoSize = true;
            this.lblNaslovPoruke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslovPoruke.Location = new System.Drawing.Point(236, 107);
            this.lblNaslovPoruke.Name = "lblNaslovPoruke";
            this.lblNaslovPoruke.Size = new System.Drawing.Size(55, 17);
            this.lblNaslovPoruke.TabIndex = 89;
            this.lblNaslovPoruke.Text = "Naslov:";
            // 
            // lblSvePoruke
            // 
            this.lblSvePoruke.AutoSize = true;
            this.lblSvePoruke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSvePoruke.Location = new System.Drawing.Point(582, 61);
            this.lblSvePoruke.Name = "lblSvePoruke";
            this.lblSvePoruke.Size = new System.Drawing.Size(97, 17);
            this.lblSvePoruke.TabIndex = 90;
            this.lblSvePoruke.Text = "Moje poruke";
            // 
            // lblPrimatelj
            // 
            this.lblPrimatelj.AutoSize = true;
            this.lblPrimatelj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrimatelj.Location = new System.Drawing.Point(236, 61);
            this.lblPrimatelj.Name = "lblPrimatelj";
            this.lblPrimatelj.Size = new System.Drawing.Size(66, 17);
            this.lblPrimatelj.TabIndex = 91;
            this.lblPrimatelj.Text = "Primatelj:";
            // 
            // frmPorukeInstruktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 612);
            this.Controls.Add(this.dgvPopisPoruka);
            this.Controls.Add(this.btnDetaljiPoruke);
            this.Controls.Add(this.btnPošalji);
            this.Controls.Add(this.txtSadržajPoruke);
            this.Controls.Add(this.txtNaslovPoruke);
            this.Controls.Add(this.comboPrimatelj);
            this.Controls.Add(this.lblSadržajPoruke);
            this.Controls.Add(this.lblNaslovPoruke);
            this.Controls.Add(this.lblSvePoruke);
            this.Controls.Add(this.lblPrimatelj);
            this.Controls.Add(this.gbProfil);
            this.Controls.Add(this.gbIzbornik);
            this.Controls.Add(this.gbInstruktor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPorukeInstruktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPorukeInstruktor";
            this.Load += new System.EventHandler(this.frmPorukeInstruktor_Load);
            this.gbInstruktor.ResumeLayout(false);
            this.gbInstruktor.PerformLayout();
            this.gbIzbornik.ResumeLayout(false);
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPoruka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInstruktor;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.GroupBox gbIzbornik;
        private System.Windows.Forms.Button btnPoruke;
        private System.Windows.Forms.GroupBox gbProfil;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPopisPoruka;
        private System.Windows.Forms.Button btnDetaljiPoruke;
        private System.Windows.Forms.Button btnPošalji;
        private System.Windows.Forms.TextBox txtSadržajPoruke;
        private System.Windows.Forms.TextBox txtNaslovPoruke;
        private System.Windows.Forms.ComboBox comboPrimatelj;
        private System.Windows.Forms.Label lblSadržajPoruke;
        private System.Windows.Forms.Label lblNaslovPoruke;
        private System.Windows.Forms.Label lblSvePoruke;
        private System.Windows.Forms.Label lblPrimatelj;
        private System.Windows.Forms.Button btnZatvori;
    }
}