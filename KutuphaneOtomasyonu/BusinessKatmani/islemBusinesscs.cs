using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessKatman;
using EntityKatmanı;
using System.Data;
using System.Data.OleDb;
//Burada diger katmanlarla diger sınıflarla baglantı kurmak icin ekleme yapıyoruz 

namespace BusinessKatmani
{
    public class islemBusinesscs
    {
        DataAccessKatman.DataAccess dataAccess1 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public List<Islemler> iadeIslemi()
        {
            OleDbDataReader dreader = dataAccess1.DRVeriCekme("Select * From islem", CommandType.Text);
            //dataAccess1 nesnesi ile islem tablosundaki verileri alıyoruz
            if (dreader.HasRows)  //Satırın içinin bos olup olmadıgını kontrol ediyoruz
            {
                List<Islemler> islemKayit = new List<Islemler>();
                //İslemler sınıfından islemKayit listesi olusturduk.
                while (dreader.Read())
                {
                    //Tablodaki verileri aldıktan sonra islem listesine ekliyoruz.
                    Islemler islem = new Islemler
                    {
                        islemNumarasi = int.Parse(dreader["islemno"].ToString()),
                        ogrenciNumarisi = int.Parse(dreader["ogrencino"].ToString()),
                        kitapNumarasi = int.Parse(dreader["kitapno"].ToString()),
                        alisTarihi = dreader["alistarih"].ToString(),
                        verisTarihi = dreader["veristarih"].ToString(),
                        ceza = int.Parse(dreader["ceza"].ToString()),
                        islemTuru = dreader["islemTuru"].ToString()
                    };
                    islemKayit.Add(islem);  //ekledigmiz bilgileri yani islem listesini islemKayit listesine ekliyoruz
                }
                return islemKayit;
            }
            return null;
        }

        DataAccessKatman.DataAccess dataAccess2 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik

        public int iadeyiGuncelleme(int ogrenciNumarasi, int kitapNumarasi, string islemTuru)
        {
            //Aldıgımız iade verilerini güncellemek için ekleSilGüncelleme fonksiyonununa verileri gönderiyoruz
            int sonuc;
            sonuc = dataAccess2.EkleSilGüncelleme("UPDATE islem set islemTuru='" +
                islemTuru + "'Where ogrencino=" + ogrenciNumarasi + "and kitapno= " +
                kitapNumarasi + "", System.Data.CommandType.Text);

            return sonuc;
        }

        public List<Islemler> kayitlariListele(int ogrenciNumarasi)
        {
            //Ogrenci Numarasi ile kayıtlari listeliyoruz.
            //Listelemek istedigimiz bilgileri verileri Data Access Katmanındaki Fonksiyon ile veritabanından cekiyoruz
            OleDbDataReader dreader = dataAccess2.DRVeriCekme
                ("Select * From islem Where ogrencino in (Select ogrencino From ogrenci Where ogrencino ='"
                + ogrenciNumarasi + "')", CommandType.Text);

            if (dreader.HasRows)
            {
                //Eger bos degilse satir bu bilgileri İslemler sinifindan ürettigimiz kayitİslem Listesine gönderiyoruz
                List<Islemler> kayitIslem = new List<Islemler>();
                while (dreader.Read())
                {
                    Islemler kayitduzen = new Islemler
                    {
                        islemNumarasi = int.Parse(dreader["islemno"].ToString()),
                        ogrenciNumarisi = int.Parse(dreader["ogrencino"].ToString()),
                        kitapNumarasi = int.Parse(dreader["kitapno"].ToString()),
                        alisTarihi = dreader["alistarih"].ToString(),
                        verisTarihi = dreader["veristarih"].ToString(),
                        ceza = int.Parse(dreader["ceza"].ToString()),
                        islemTuru = dreader["islemTuru"].ToString()
                    };
                    kayitIslem.Add(kayitduzen);
                }
                return kayitIslem;
            }
            return null;
        }

        DataAccessKatman.DataAccess dataAccess5 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public int emanet_islemi(int kitapNumarasi, int ogrenciNumarasi, DateTime alisTarihi, DateTime verisTarihi, string islemTuru)
        {
            //Emanet islemi icin DataAccess Katmanındaki EkleSilGüncelleme Fonksiyon ile islem veritabanı tablosuna gerekli bilgileri gönderiyoruz
            int sonuc;
            sonuc = dataAccess5.EkleSilGüncelleme("insert into islem(kitapno,ogrencino,alistarih,veristarih,islemTuru)VALUES(" +
                kitapNumarasi + "," + ogrenciNumarasi + ",'" + alisTarihi + "','" + verisTarihi + "','" + islemTuru + "')", System.Data.CommandType.Text);
            return sonuc;

        }

        DataAccessKatman.DataAccess dataAccess3 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public List<Islemler> ogrenciEmanetIadeListesi(int deger)
        {
            //Listeleme islemi için DataAccess Katmanında DrVeriCekme Fonkisyonuyla verileri islem tablosundan cekiyoruz
            OleDbDataReader dreader = dataAccess3.DRVeriCekme("Select * From islem Where ogrencino in (Select ogrencino From ogrenci Where ogrencino=" + deger + ")", CommandType.Text);

            if (dreader.HasRows)
            {
                //Eger kayıt varsa İslemler Sınıfından bir liste üretiyoruz ve bu listeye veritabanından aldıgımız verileri gönderiyoruz
                List<Islemler> iadeListesi = new List<Islemler>();
                while (dreader.Read())
                {
                    Islemler kayitEmanetListe = new Islemler
                    {
                        islemNumarasi = int.Parse(dreader["islemno"].ToString()),
                        ogrenciNumarisi = int.Parse(dreader["ogrencino"].ToString()),
                        kitapNumarasi = int.Parse(dreader["kitapno"].ToString()),
                        alisTarihi = dreader["alistarih"].ToString(),
                        verisTarihi = dreader["veristarih"].ToString(),
                        ceza = int.Parse(dreader["ceza"].ToString()),
                        islemTuru = dreader["islemTuru"].ToString()
                    };
                    iadeListesi.Add(kayitEmanetListe);
                }
                return iadeListesi;
            }
            return null;
        }

    }
}
