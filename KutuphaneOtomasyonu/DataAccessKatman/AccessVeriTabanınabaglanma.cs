using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace DataAccessKatman
{
    public class AccessVeriTabanınabaglanma
    {
        //Access veritabanı bağlantısı yapılıyor.
        OleDbConnection baglanti;
        public OleDbConnection BaglantiAdresi
        {
            get
            {
                if (baglanti != null)
                {
                    //Burada Kontrol yapılıyor yani Veritabanı baglı durumda ise
                    //baglanti nin durumu kapalı ise acılıyor.

                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    return baglanti;
                }
                else
                {
                    baglanti = new OleDbConnection(Yolu());
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    return baglanti;
                }
            }
        }

        private string Yolu()
        {
            return Baglanti.adres;
        }
    }
}
