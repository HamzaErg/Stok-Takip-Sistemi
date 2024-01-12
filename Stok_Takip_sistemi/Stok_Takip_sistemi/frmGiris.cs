using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stok_Takip_sistemi.Forms;

namespace Stok_Takip_sistemi
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad, sifre;
            ad=txtAd.Text;
            sifre=txtSifre.Text;
            if (ad=="yönetici" && sifre == "yönetici")
            {
                frmAnaSayfaYonetici frm = new frmAnaSayfaYonetici();
                frm.Show();
            }
            else if (ad=="personel" && sifre == "personel")
            {
                frmAnaSayfaPersonel frm = new frmAnaSayfaPersonel();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Yanlış Bilgi ve ya eksik girdi yaptınız.");
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
