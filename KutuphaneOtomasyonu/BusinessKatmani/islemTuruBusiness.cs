using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessKatman;
using EntityKatmanı;
using System.Data;
using System.Data.OleDb;

namespace BusinessKatmani
{
    public class islemTuruBusiness
    {
        DataAccessKatman.DataAccess dataAccess1 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public int listeleme()
        {
            //DataAccess Katmanındaki Fonksiyon ile Kitap Tablosundaki verileri alıyoruz
            //Bunları toplam degiskenine atıyoruz buda toplam kitap sayısı.
            int toplam = 0;
            OleDbDataReader dreader = dataAccess1.DRVeriCekme("Select kitapno From kitap", CommandType.Text);
            if(dreader.HasRows)
            {
                List<Kitaplar> kitap = new List<Kitaplar>();
                while(dreader.Read())
                {
                    toplam++;
                }
                return toplam;
            }
            return 0;
        }

        DataAccessKatman.DataAccess dataAccess2 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public int alma()
        {
            //DataAccess Katmanındaki Fonksiyon ile islem taplosundaki islem turu alım olan verileri alıyoruz
            //Bu verileri yani kaç tane alım varsa  toplam degiskenine atıyoruz.
            int toplam = 0;
            OleDbDataReader dreader = dataAccess2.DRVeriCekme("Select * From islem Where islemTuru='" + "alım" + "'", CommandType.Text);
    
            if(dreader.HasRows)
            {
                List<Kitaplar> kitap = new List<Kitaplar>();
                while (dreader.Read())
                {
                    toplam++;
                }
                return toplam;
            }
            return 0;
        }
    }
}
