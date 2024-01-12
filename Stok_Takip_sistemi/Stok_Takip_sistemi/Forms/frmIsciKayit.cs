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
    public partial class frmIsciKayit : Form
    {
        int? id = null;
        public bool Kaydedildi = false;
        public frmIsciKayit(int? Id = null)
        {
            InitializeComponent();
            if (Id != null)
                this.id = Id;
        }

        private void frmIsciKayit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                string sql = "Insert into DbCalisanlar (CAdiSoyadi, CMaas,CSifre) Values('" + txtCAd.Text + "','" + txtCMaas.Text + "','" + txtCSifre.Text + "')";



                if (CRUD.ESGCalisan(sql))
                {
                    Kaydedildi = true;
                    MessageBox.Show("Ekleme işlemi başarıyla gerçekleşti");
                }
                this.Close();
            }
            else
            {
                string sql = "Update DbCalisanlar set CAdiSoyadi='" + txtCAd.Text + "', CMaas='" + txtCMaas.Text + "', CSifre='" + txtCSifre.Text + "' Where Id='" + id + "'  ";


                if (CRUD.ESGCalisan(sql))
                {
                    Kaydedildi = true;
                    MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti");
                }
                this.Close();
            }
        }
    }
}
