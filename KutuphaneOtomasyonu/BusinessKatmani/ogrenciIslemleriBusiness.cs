using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using DataAccessKatman;
using EntityKatmanı;

namespace BusinessKatmani
{
    public class ogrenciIslemleriBusiness
    {
        DataAccessKatman.DataAccess dataAccess1 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public List<Ogrenciler> ogrenciGosterme()
        {
            //DRVeriCekme Fonksiyonu ile ogrenci tablosundaki kayıtlari alıyoruz

            OleDbDataReader dreader = dataAccess1.DRVeriCekme("SELECT * FROM ogrenci", CommandType.Text);
            if(dreader.HasRows)
            {
                //eger kayıt bos degilse bu aldıgımız verieri Ogrenciler sınıfında ürettigimiz listeye gönderiyoruz
                //bu listeyide en son return ediyoruz
                List<Ogrenciler> ogrenciler = new List<Ogrenciler>();
                while(dreader.Read())
                {
                    Ogrenciler ogrenci = new Ogrenciler
                    {
                        ogrenciNumara = int.Parse(dreader["ogrencino"].ToString()),
                        ogrenciAd = dreader["ogrenciad"].ToString(),
                        ogrenciSoyad = dreader["ogrencisoyad"].ToString(),
                        ogrenciCinsiyet = dreader["cinsiyet"].ToString(),
                        ogrenciDogumTarih = dreader["dogumtarih"].ToString(),
                        ogrenciSinif = dreader["sinif"].ToString()
                    };
                    ogrenciler.Add(ogrenci);
                }
                return ogrenciler;
            }
            return null;
        }
        DataAccessKatman.DataAccess dataAccess2 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public List<Ogrenciler> ogrenciGosterme(int ogrenciNumarasi)
        {
            //DRVeriCekme Fonksiyonu ile ogrenci tablosundaki ogrenci numarasi bizim aldıgımız parametre ile aynıysa yani oyle bir kayıt var ise o kaydı alıyoruz
            OleDbDataReader dreader = dataAccess2.DRVeriCekme("SELECT * FROM ogrenci WHERE ogrencino=" + ogrenciNumarasi + "", CommandType.Text);
            if(dreader.HasRows)
            {
                //Eger kayıt bos degilse Ogrenciler sınıfında olusturdugumuz listeye bu verileri atıyoruz ve döndürüyoruz
                List<Ogrenciler> ogrenciler1 = new List<Ogrenciler>();
                while(dreader.Read())
                {
                    Ogrenciler ogrenci = new Ogrenciler()
                    {
                        ogrenciNumara = int.Parse(dreader["ogrencino"].ToString()),
                        ogrenciAd = dreader["ogrenciad"].ToString(),
                        ogrenciSoyad = dreader["ogrencisoyad"].ToString(),
                        ogrenciCinsiyet = dreader["cinsiyet"].ToString(),
                        ogrenciDogumTarih = dreader["dogumtarih"].ToString(),
                        ogrenciSinif = dreader["sinif"].ToString()
                    };
                    ogrenciler1.Add(ogrenci);
                }
                return ogrenciler1;
            }
            return null;
        }

        DataAccessKatman.DataAccess dataAccess3 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public int ogrenciEkle(int ogrenciNumara, string ogrenciAd, string ogrenciSoyad, string ogrenciCinsiyet, string ogrenciDogumTarih, string ogrenciSinif)
        {
            //EkleSilGüncelleme Fonksiyonu ile aldıgımız parametredeki ögrenci bilgierini insert sorgusu ile ogrenci tablosuna kayıt ettiriyoruz
            int sonuc = dataAccess3.EkleSilGüncelleme("INSERT into ogrenci (ogrencino,ogrenciad,ogrencisoyad,cinsiyet,dogumtarih,sinif) VALUES ('" + ogrenciNumara +
                  "','" + ogrenciAd + "','" + ogrenciSoyad + "','" + ogrenciCinsiyet + "','" + ogrenciDogumTarih+"','"+ ogrenciSinif+"')",CommandType.Text);
            return sonuc;
        }

        DataAccessKatman.DataAccess dataAccess4 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public int ogrenciGuncelleme(int ogrenciNumara, string ogrenciAd, string ogrenciSoyad, string ogrenciCinsiyet, string ogrenciDogumTarih, string ogrenciSinif)
        {
            //EkleSilGüncelleme Fonksiyonu ile aldıgımız ogrenciNumarasi parametresi eger ogrenci tablosunda var ise
            //aldıgımız diger parametreleri ogrenci tablosunda ilgili kayıtı upadete sorgusu ile güncelliyoruz
            int sonuc = dataAccess4.EkleSilGüncelleme("UPDATE ogrenci SET ogrenciad='" + ogrenciAd + "',ogrencisoyad='" + ogrenciSoyad
                + "',cinsiyet ='" + ogrenciCinsiyet + "',dogumtarih='" + ogrenciDogumTarih + "',sinif ='" + ogrenciSinif + "'"+ " Where ogrencino=" + ogrenciNumara + "", System.Data.CommandType.Text);
            return sonuc;
        }

        DataAccessKatman.DataAccess dataAccess5 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public int ogrenciSilme(int ogrenciNumara)
        {
            //EkleSilGuncelleme Fonksiyonu ile aldıgımız parametreyi ogrenci tablosunda arıyoruz boyle bir kayıt var ise o kayıtı siliyoruz
            int sonuc = dataAccess5.EkleSilGüncelleme("Delete from ogrenci Where ogrencino=" + ogrenciNumara + "", System.Data.CommandType.Text);
            return sonuc;
        }

        DataAccessKatman.DataAccess dataAccess6 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public bool ogrenciKontrol(int ogrenciNumarasi)
        {
            //DRVeriCekme Fonksiyonu ile aldıgımız parametre eger ogrenci tablosunda var ise bize true deger döndürür eger yok ise bu parametre o zaman false döndürür
            OleDbDataReader dreader = dataAccess6.DRVeriCekme("Select * From ogrenci Where ogrencino=" + ogrenciNumarasi + "", CommandType.Text);
            if(dreader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
