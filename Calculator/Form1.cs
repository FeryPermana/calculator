using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmHasil : Form
    {
        // Constructor untuk inisialisasi data ketika entri data baru
        public frmHasil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            Calculator myForm = new Calculator();

            myForm.ProsesHitung += FrmHitung_ProsesHitung;
            myForm.ShowDialog();
        }
        private void FrmHitung_ProsesHitung(int index, int a, int b)
        {
            var count = new OperasiPerhitungan();

            if (index == 0)
            {
                lstHasil.Items.Add(string.Format("Hasil penambahan  : {0} + {1} = {2}", a, b, count.Penjumlahan(a, b)));
            }
            else if (index == 1)
            {
                lstHasil.Items.Add(string.Format("Hasil pengurangan : {0} - {1} = {2}", a, b, count.Pengurangan(a, b)));
            }
            else if (index == 2)
            {
                lstHasil.Items.Add(string.Format("Hasil perkalian   : {0} * {1} = {2}", a, b, count.Perkalian(a, b)));
            }
            else
            {
                lstHasil.Items.Add(string.Format("Hasil pembagian   : {0} / {1} = {2}", a, b, count.Pembagian(a, b)));
            }
        }

        private void listHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
