
namespace FindAndLearn.MojeObavijesti
{
    partial class frmProcitajObavijesti
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
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.Location = new System.Drawing.Point(315, 200);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 35;
            this.btnNatrag.Text = "NATRAG";
            this.btnNatrag.UseVisualStyleBackColor = true;
            // 
            // txtPoruka
            // 
            this.txtPoruka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.txtPoruka.Enabled = false;
            this.txtPoruka.Location = new System.Drawing.Point(18, 68);
            this.txtPoruka.Multiline = true;
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(371, 122);
            this.txtPoruka.TabIndex = 34;
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInstruktor.Location = new System.Drawing.Point(17, 39);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(100, 17);
            this.lblInstruktor.TabIndex = 33;
            this.lblInstruktor.Text = "Matija Horvat  | ";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(15, 19);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(182, 17);
            this.lblNaslov.TabIndex = 32;
            this.lblNaslov.Text = "Odgoda instrukcija 1. svibnja";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.Location = new System.Drawing.Point(122, 39);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(75, 17);
            this.lblDatum.TabIndex = 31;
            this.lblDatum.Text = "26.4. 2021.  ";
            // 
            // frmProcitajObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(424, 251);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.lblInstruktor);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblDatum);
            this.Name = "frmProcitajObavijesti";
            this.Text = "frmProcitajObavijesti";
            this.Load += new System.EventHandler(this.frmProcitajObavijesti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.TextBox txtPoruka;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblDatum;
    }
}