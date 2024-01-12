using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Stok_Takip_sistemi.Forms
{
    public partial class frmUrunKayit : Form
    {
        int? id = null;
        public bool Kaydedildi = false;
        public frmUrunKayit(int?  Id=null)
        {
            InitializeComponent();
            if (Id != null)
                this.id = Id;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                string sql = "Insert into DbUrunler (UAdi, UStok) Values('" + txtUAdi.Text + "','" + txtUStok.Text + "')";



                if (CRUD.ESG(sql))
                {
                    Kaydedildi=true;
                    MessageBox.Show("Ekleme işlemi başarıyla gerçekleşti");
                }
                this.Close();
            }
            else
            {
                string sql = "Update DbUrunler set UAdi='" + txtUAdi.Text + "',UStok='" + txtUStok.Text + "' Where Id='"+id+"'  ";


                if (CRUD.ESG(sql))
                {
                    Kaydedildi = true;
                    MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti");
                }
                this .Close();
            }
        }

        private void frmUrunKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
