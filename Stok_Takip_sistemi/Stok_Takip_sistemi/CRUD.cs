using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip_sistemi
{
    public class CRUD
    {
        public static DataTable dt;
        //DbUrun Tablosu Bağlantı Kodları
        public static DataTable ListeUrun(string sql)
        {
            dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter(sql, BagUrun.BaglanUrun);
            adtr.Fill(dt);
            return dt;
        }

        public static bool ESG(string sql)
        {
            int dogrula = 0;
            SQLiteCommand command = new SQLiteCommand(sql, BagUrun.BaglanUrun);
            BagUrun.BaglanUrun.Open();
            dogrula = command.ExecuteNonQuery();
            BagUrun.BaglanUrun.Close();
            if (dogrula == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //DbCalisanlar Tablosu Bağlantı Kodları
        public static DataTable ListeCalisan(string sql)
        {
            dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter(sql, BagCalisan.BaglanCalisan);
            adtr.Fill(dt);
            return dt;
        }

        public static bool ESGCalisan(string sql)
        {
            int dogrulaa = 0;
            SQLiteCommand command = new SQLiteCommand(sql, BagCalisan.BaglanCalisan);
            BagCalisan.BaglanCalisan.Open();
            dogrulaa = command.ExecuteNonQuery();
            BagCalisan.BaglanCalisan.Close();
            if (dogrulaa == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
