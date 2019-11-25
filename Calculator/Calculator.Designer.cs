namespace Calculator
{
    partial class Calculator
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ListOperasi = new System.Windows.Forms.Label();
            this.NilaiA = new System.Windows.Forms.Label();
            this.NilaiB = new System.Windows.Forms.Label();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.cmbOperasi = new System.Windows.Forms.ComboBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ListOperasi
            // 
            this.ListOperasi.AutoSize = true;
            this.ListOperasi.Location = new System.Drawing.Point(12, 28);
            this.ListOperasi.Name = "ListOperasi";
            this.ListOperasi.Size = new System.Drawing.Size(43, 13);
            this.ListOperasi.TabIndex = 2;
            this.ListOperasi.Text = "Operasi";
            // 
            // NilaiA
            // 
            this.NilaiA.AutoSize = true;
            this.NilaiA.Location = new System.Drawing.Point(12, 62);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(37, 13);
            this.NilaiA.TabIndex = 3;
            this.NilaiA.Text = "Nilai A";
            // 
            // NilaiB
            // 
            this.NilaiB.AutoSize = true;
            this.NilaiB.Location = new System.Drawing.Point(12, 96);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(37, 13);
            this.NilaiB.TabIndex = 5;
            this.NilaiB.Text = "Nilai B";
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(67, 62);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(185, 20);
            this.txtNilaiA.TabIndex = 4;
            this.txtNilaiA.TextChanged += new System.EventHandler(this.txtNilaiA_TextChanged);
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(67, 96);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(185, 20);
            this.txtNilaiB.TabIndex = 6;
            this.txtNilaiB.TextChanged += new System.EventHandler(this.txtNilaiB_TextChanged);
            // 
            // cmbOperasi
            // 
            this.cmbOperasi.FormattingEnabled = true;
            this.cmbOperasi.Location = new System.Drawing.Point(67, 25);
            this.cmbOperasi.Name = "cmbOperasi";
            this.cmbOperasi.Size = new System.Drawing.Size(185, 21);
            this.cmbOperasi.TabIndex = 7;
            this.cmbOperasi.SelectedIndexChanged += new System.EventHandler(this.cmbOperasi_SelectedIndexChanged);
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(177, 136);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 8;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 171);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.cmbOperasi);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.ListOperasi);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label ListOperasi;
        private System.Windows.Forms.Label NilaiA;
        private System.Windows.Forms.Label NilaiB;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.ComboBox cmbOperasi;
        private System.Windows.Forms.Button btnProses;
    }
}