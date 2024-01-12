using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_sistemi.Forms
{
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
            ListeUrun();
        }
        void ListeUrun()
        {
            
            string sql = "Select * from DbUrunler";
            DgvUrun.DataSource = CRUD.ListeUrun(sql);
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            ListeUrun();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmUrunKayit frm = new frmUrunKayit();
            frm.Show();
            if (frm.Kaydedildi)
            {
                ListeUrun();
            }

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int seciliid = Convert.ToInt32(DgvUrun.CurrentRow.Cells["Id"].Value.ToString());
            frmUrunKayit frm = new frmUrunKayit(seciliid);
            frm.txtUAdi.Text = DgvUrun.CurrentRow.Cells["UAdi"].Value.ToString();
            frm.txtUStok.Text = DgvUrun.CurrentRow.Cells["UStok"].Value.ToString();
            frm.Show();
            if (frm.Kaydedildi)
            {
                ListeUrun();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ListeUrun();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seçili kayıt silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int seciliid = Convert.ToInt32(DgvUrun.CurrentRow.Cells["Id"].Value.ToString());
                string sql = "Delete from DbUrunler Where Id='" + seciliid +"' ";
                if (CRUD.ESG(sql))
                {
                    ListeUrun();
                }
            }
        }
    }
}
