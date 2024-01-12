using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip_sistemi
{
    public static class BagUrun
    {
        public static SQLiteConnection BaglanUrun = new SQLiteConnection("Data source= .\\DbUrunler.db; Versiyon=3");
    }
    public static class BagCalisan
    {
        public static SQLiteConnection BaglanCalisan = new SQLiteConnection("Data source= .\\DbCalisanlar.db; Versiyon=3");
    }
}
