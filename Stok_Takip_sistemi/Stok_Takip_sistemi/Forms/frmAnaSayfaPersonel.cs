using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_sistemi.Forms
{
    public partial class frmAnaSayfaPersonel : Form
    {
        public frmAnaSayfaPersonel()
        {
            InitializeComponent();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            frmUrunler frm = new frmUrunler();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
