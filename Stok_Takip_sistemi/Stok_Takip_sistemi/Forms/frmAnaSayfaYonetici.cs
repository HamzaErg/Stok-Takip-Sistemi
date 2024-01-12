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

namespace Stok_Takip_sistemi.Forms
{
    public partial class frmAnaSayfaYonetici : Form
    {
        public frmAnaSayfaYonetici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            frmUrunler frm = new frmUrunler();
            frm.Show();
        }

        private void btnMüsteriler_Click(object sender, EventArgs e)
        {
            frmMüsteriler frm = new frmMüsteriler();
            frm.Show();
        }

        private void btnTedarikciler_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalısanlar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnCalis_Click(object sender, EventArgs e)
        {
            frmIsciler frm = new frmIsciler();
            frm.Show();
        }
    }
}
