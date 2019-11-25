namespace Calculator
{
    partial class frmHasil
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
            this.grphasil = new System.Windows.Forms.GroupBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.lstHasil = new System.Windows.Forms.ListBox();
            this.grphasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // grphasil
            // 
            this.grphasil.Controls.Add(this.lstHasil);
            this.grphasil.Location = new System.Drawing.Point(42, 60);
            this.grphasil.Name = "grphasil";
            this.grphasil.Size = new System.Drawing.Size(564, 293);
            this.grphasil.TabIndex = 0;
            this.grphasil.TabStop = false;
            this.grphasil.Text = "Hasil";
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(53, 359);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(541, 23);
            this.btnHitung.TabIndex = 1;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // lstHasil
            // 
            this.lstHasil.FormattingEnabled = true;
            this.lstHasil.Location = new System.Drawing.Point(17, 45);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(524, 238);
            this.lstHasil.TabIndex = 0;
            this.lstHasil.SelectedIndexChanged += new System.EventHandler(this.listHasil_SelectedIndexChanged);
            // 
            // frmHasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.grphasil);
            this.Name = "frmHasil";
            this.Text = "Hasil Perhitungan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grphasil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grphasil;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.ListBox lstHasil;
    }
}

