
namespace FindAndLearn.MojeObavijesti
{
    partial class frmAzurirajObavijesti
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTermin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(22, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 126;
            this.label7.Text = "Termin:";
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmijeni.Location = new System.Drawing.Point(481, 279);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmijeni.TabIndex = 125;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(77, 279);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 124;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(77, 97);
            this.txtPoruka.Multiline = true;
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(479, 168);
            this.txtPoruka.TabIndex = 123;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(77, 63);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(254, 20);
            this.txtNaslov.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 121;
            this.label2.Text = "Poruka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 120;
            this.label1.Text = "Naslov:";
            // 
            // txtTermin
            // 
            this.txtTermin.Enabled = false;
            this.txtTermin.Location = new System.Drawing.Point(77, 29);
            this.txtTermin.Name = "txtTermin";
            this.txtTermin.Size = new System.Drawing.Size(157, 20);
            this.txtTermin.TabIndex = 127;
            // 
            // frmAzurirajObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(622, 350);
            this.Controls.Add(this.txtTermin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAzurirajObavijesti";
            this.Text = "Ažuriraj obavijesti";
            this.Load += new System.EventHandler(this.frmAzurirajObavijesti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtPoruka;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTermin;
    }
}