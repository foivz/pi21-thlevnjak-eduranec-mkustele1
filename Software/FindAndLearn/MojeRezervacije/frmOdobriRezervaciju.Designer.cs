
namespace FindAndLearn.MojeRezervacije
{
    partial class frmOdobriRezervaciju
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
            this.components = new System.ComponentModel.Container();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.gbInstruktor = new System.Windows.Forms.GroupBox();
            this.btnOdobriRezervaciju = new System.Windows.Forms.Button();
            this.dgvOdobreneRezervacije = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbProfil = new System.Windows.Forms.GroupBox();
            this.lblTerminiZaOdobrenje = new System.Windows.Forms.Label();
            this.btnTermin = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.lblOdobreniTermini = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDrezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokrezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potvrdjenaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbInstruktor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdobreneRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbProfil.SuspendLayout();
            this.gbIzbornik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInstruktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblInstruktor.Location = new System.Drawing.Point(77, 21);
            this.lblInstruktor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(95, 20);
            this.lblInstruktor.TabIndex = 3;
            this.lblInstruktor.Text = "Instruktor ";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.Location = new System.Drawing.Point(1188, 16);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(120, 31);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.Text = "POMOĆ";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.Location = new System.Drawing.Point(1032, 16);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(120, 31);
            this.btnOdjava.TabIndex = 29;
            this.btnOdjava.Text = "ODJAVA";
            this.btnOdjava.UseVisualStyleBackColor = false;
            // 
            // gbInstruktor
            // 
            this.gbInstruktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbInstruktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInstruktor.Controls.Add(this.btnOdjava);
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblInstruktor);
            this.gbInstruktor.Location = new System.Drawing.Point(225, -13);
            this.gbInstruktor.Margin = new System.Windows.Forms.Padding(4);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Padding = new System.Windows.Forms.Padding(4);
            this.gbInstruktor.Size = new System.Drawing.Size(1613, 60);
            this.gbInstruktor.TabIndex = 163;
            this.gbInstruktor.TabStop = false;
            // 
            // btnOdobriRezervaciju
            // 
            this.btnOdobriRezervaciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnOdobriRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdobriRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdobriRezervaciju.Location = new System.Drawing.Point(507, 534);
            this.btnOdobriRezervaciju.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdobriRezervaciju.Name = "btnOdobriRezervaciju";
            this.btnOdobriRezervaciju.Size = new System.Drawing.Size(203, 31);
            this.btnOdobriRezervaciju.TabIndex = 160;
            this.btnOdobriRezervaciju.Text = "Odobri rezervaciju";
            this.btnOdobriRezervaciju.UseVisualStyleBackColor = false;
            // 
            // dgvOdobreneRezervacije
            // 
            this.dgvOdobreneRezervacije.AutoGenerateColumns = false;
            this.dgvOdobreneRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdobreneRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDrezervacijaDataGridViewTextBoxColumn,
            this.studentiDataGridViewTextBoxColumn,
            this.terminiDataGridViewTextBoxColumn,
            this.rokrezervacijeDataGridViewTextBoxColumn,
            this.datumrezervacijeDataGridViewTextBoxColumn,
            this.potvrdjenaDataGridViewCheckBoxColumn});
            this.dgvOdobreneRezervacije.DataSource = this.rezervacijeBindingSource;
            this.dgvOdobreneRezervacije.Location = new System.Drawing.Point(306, 149);
            this.dgvOdobreneRezervacije.Name = "dgvOdobreneRezervacije";
            this.dgvOdobreneRezervacije.RowHeadersWidth = 51;
            this.dgvOdobreneRezervacije.RowTemplate.Height = 24;
            this.dgvOdobreneRezervacije.Size = new System.Drawing.Size(579, 330);
            this.dgvOdobreneRezervacije.TabIndex = 168;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(103, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "PROFIL";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::FindAndLearn.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 15);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(101, 73);
            this.pbLogo.TabIndex = 69;
            this.pbLogo.TabStop = false;
            // 
            // gbProfil
            // 
            this.gbProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbProfil.Controls.Add(this.pbLogo);
            this.gbProfil.Controls.Add(this.label2);
            this.gbProfil.Location = new System.Drawing.Point(-9, -15);
            this.gbProfil.Margin = new System.Windows.Forms.Padding(4);
            this.gbProfil.Name = "gbProfil";
            this.gbProfil.Padding = new System.Windows.Forms.Padding(4);
            this.gbProfil.Size = new System.Drawing.Size(281, 92);
            this.gbProfil.TabIndex = 164;
            this.gbProfil.TabStop = false;
            // 
            // lblTerminiZaOdobrenje
            // 
            this.lblTerminiZaOdobrenje.AutoSize = true;
            this.lblTerminiZaOdobrenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTerminiZaOdobrenje.Location = new System.Drawing.Point(302, 106);
            this.lblTerminiZaOdobrenje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerminiZaOdobrenje.Name = "lblTerminiZaOdobrenje";
            this.lblTerminiZaOdobrenje.Size = new System.Drawing.Size(192, 20);
            this.lblTerminiZaOdobrenje.TabIndex = 165;
            this.lblTerminiZaOdobrenje.Text = "Termini za odobrenje:";
            // 
            // btnTermin
            // 
            this.btnTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnTermin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTermin.Location = new System.Drawing.Point(24, 50);
            this.btnTermin.Margin = new System.Windows.Forms.Padding(4);
            this.btnTermin.Name = "btnTermin";
            this.btnTermin.Size = new System.Drawing.Size(245, 38);
            this.btnTermin.TabIndex = 24;
            this.btnTermin.Text = "TERMINI";
            this.btnTermin.UseVisualStyleBackColor = false;
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatvori.Location = new System.Drawing.Point(24, 496);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(245, 38);
            this.btnZatvori.TabIndex = 25;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            // 
            // gbIzbornik
            // 
            this.gbIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbIzbornik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbIzbornik.Controls.Add(this.btnZatvori);
            this.gbIzbornik.Controls.Add(this.btnTermin);
            this.gbIzbornik.Location = new System.Drawing.Point(-17, 38);
            this.gbIzbornik.Margin = new System.Windows.Forms.Padding(4);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Padding = new System.Windows.Forms.Padding(4);
            this.gbIzbornik.Size = new System.Drawing.Size(289, 809);
            this.gbIzbornik.TabIndex = 162;
            this.gbIzbornik.TabStop = false;
            // 
            // lblOdobreniTermini
            // 
            this.lblOdobreniTermini.AutoSize = true;
            this.lblOdobreniTermini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdobreniTermini.Location = new System.Drawing.Point(950, 106);
            this.lblOdobreniTermini.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdobreniTermini.Name = "lblOdobreniTermini";
            this.lblOdobreniTermini.Size = new System.Drawing.Size(155, 20);
            this.lblOdobreniTermini.TabIndex = 169;
            this.lblOdobreniTermini.Text = "Odobreni termini:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(954, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(579, 330);
            this.dataGridView1.TabIndex = 170;
            // 
            // iDrezervacijaDataGridViewTextBoxColumn
            // 
            this.iDrezervacijaDataGridViewTextBoxColumn.DataPropertyName = "ID_rezervacija";
            this.iDrezervacijaDataGridViewTextBoxColumn.HeaderText = "ID_rezervacija";
            this.iDrezervacijaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDrezervacijaDataGridViewTextBoxColumn.Name = "iDrezervacijaDataGridViewTextBoxColumn";
            this.iDrezervacijaDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentiDataGridViewTextBoxColumn
            // 
            this.studentiDataGridViewTextBoxColumn.DataPropertyName = "Studenti";
            this.studentiDataGridViewTextBoxColumn.HeaderText = "Studenti";
            this.studentiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentiDataGridViewTextBoxColumn.Name = "studentiDataGridViewTextBoxColumn";
            this.studentiDataGridViewTextBoxColumn.Width = 125;
            // 
            // terminiDataGridViewTextBoxColumn
            // 
            this.terminiDataGridViewTextBoxColumn.DataPropertyName = "Termini";
            this.terminiDataGridViewTextBoxColumn.HeaderText = "Termini";
            this.terminiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.terminiDataGridViewTextBoxColumn.Name = "terminiDataGridViewTextBoxColumn";
            this.terminiDataGridViewTextBoxColumn.Width = 125;
            // 
            // rokrezervacijeDataGridViewTextBoxColumn
            // 
            this.rokrezervacijeDataGridViewTextBoxColumn.DataPropertyName = "rok_rezervacije";
            this.rokrezervacijeDataGridViewTextBoxColumn.HeaderText = "rok_rezervacije";
            this.rokrezervacijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rokrezervacijeDataGridViewTextBoxColumn.Name = "rokrezervacijeDataGridViewTextBoxColumn";
            this.rokrezervacijeDataGridViewTextBoxColumn.Width = 125;
            // 
            // datumrezervacijeDataGridViewTextBoxColumn
            // 
            this.datumrezervacijeDataGridViewTextBoxColumn.DataPropertyName = "datum_rezervacije";
            this.datumrezervacijeDataGridViewTextBoxColumn.HeaderText = "datum_rezervacije";
            this.datumrezervacijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumrezervacijeDataGridViewTextBoxColumn.Name = "datumrezervacijeDataGridViewTextBoxColumn";
            this.datumrezervacijeDataGridViewTextBoxColumn.Width = 125;
            // 
            // potvrdjenaDataGridViewCheckBoxColumn
            // 
            this.potvrdjenaDataGridViewCheckBoxColumn.DataPropertyName = "potvrdjena";
            this.potvrdjenaDataGridViewCheckBoxColumn.HeaderText = "potvrdjena";
            this.potvrdjenaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.potvrdjenaDataGridViewCheckBoxColumn.Name = "potvrdjenaDataGridViewCheckBoxColumn";
            this.potvrdjenaDataGridViewCheckBoxColumn.Width = 125;
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataSource = typeof(FindAndLearn.Rezervacije);
            // 
            // frmOdobriRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 700);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblOdobreniTermini);
            this.Controls.Add(this.dgvOdobreneRezervacije);
            this.Controls.Add(this.lblTerminiZaOdobrenje);
            this.Controls.Add(this.gbProfil);
            this.Controls.Add(this.gbIzbornik);
            this.Controls.Add(this.btnOdobriRezervaciju);
            this.Controls.Add(this.gbInstruktor);
            this.Name = "frmOdobriRezervaciju";
            this.Text = "frmOdobriRezervaciju";
            this.Load += new System.EventHandler(this.frmOdobriRezervaciju_Load);
            this.gbInstruktor.ResumeLayout(false);
            this.gbInstruktor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdobreneRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
            this.gbIzbornik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.GroupBox gbInstruktor;
        private System.Windows.Forms.Button btnOdobriRezervaciju;
        private System.Windows.Forms.DataGridView dgvOdobreneRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDrezervacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokrezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn potvrdjenaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource rezervacijeBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gbProfil;
        private System.Windows.Forms.Label lblTerminiZaOdobrenje;
        private System.Windows.Forms.Button btnTermin;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.GroupBox gbIzbornik;
        private System.Windows.Forms.Label lblOdobreniTermini;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}