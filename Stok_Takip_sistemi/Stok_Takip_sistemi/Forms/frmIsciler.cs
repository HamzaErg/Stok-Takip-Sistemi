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
    public partial class frmIsciler : Form
    {
        public frmIsciler()
        {
            InitializeComponent();
            ListeCalisan();
        }
        void ListeCalisan()
        {

            string sql = "Select * from DbCalisanlar";
            dataGridView1.DataSource = CRUD.ListeCalisan(sql);
        }

        private void frmIsciler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIsciKayit frm = new frmIsciKayit();
            frm.Show();
            if (frm.Kaydedildi)
            {
                ListeCalisan();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int seciliid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            frmIsciKayit frm = new frmIsciKayit(seciliid);
            //frm.txtCAd.Text = dataGridView1.CurrentRow.Cells["CAdiSoyadi"].Value.ToString();
            //frm.txtCMaas.Text = dataGridView1.CurrentRow.Cells["CMaas"].Value.ToString();
            //frm.txtCSifre.Text = dataGridView1.CurrentRow.Cells["CSifre"].Value.ToString();
            frm.Show();
            if (frm.Kaydedildi)
            {
                ListeCalisan();
            }




            //int seciliid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            //frmIsciKayit frm = new frmIsciKayit(seciliid);
            //frm.txtCAd.Text = dataGridView1.CurrentRow.Cells["CAdiSoyadi"].Value.ToString();
            //frm.txtCMaas.Text = dataGridView1.CurrentRow.Cells["CMaas"].Value.ToString();
            //frm.txtCSifre.Text = dataGridView1.CurrentRow.Cells["CSifre"].Value.ToString();
            //frm.Show();
            //if (frm.Kaydedildi)
            //{
            //    ListeCalisan();
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListeCalisan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili kayıt silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int seciliid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                string sql = "Delete from DbCalisanlar Where Id='" + seciliid + "' ";
                if (CRUD.ESGCalisan(sql))
                {
                    ListeCalisan();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
