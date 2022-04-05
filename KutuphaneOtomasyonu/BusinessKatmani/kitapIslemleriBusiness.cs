using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using EntityKatmanı;
using DataAccessKatman;


namespace BusinessKatmani
{
   public class kitapIslemleriBusiness
   {
        DataAccessKatman.DataAccess dataAccess1 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public List<Kitaplar> kitapGosterme()
        {
            //DataAccess Sınıfındaki Fonksiyon ile kitap tablosundaki verileri alıyoruz
            OleDbDataReader dreader = dataAccess1.DRVeriCekme("Select * from kitap", CommandType.Text);
            if(dreader.HasRows)
            {
                //Eger bu veriler bos degilse Kitaplar Sınıfından ürettiğimiz listeye gonderiyoruz
                //Ve sonunda bu listeyi return ediyoruz
                List<Kitaplar> kitaplar = new List<Kitaplar>();

                while(dreader.Read())
                {
                    Kitaplar kitap = new Kitaplar()
                    {
                        kitapNumara = int.Parse(dreader["kitapno"].ToString()),
                        kitapAd = dreader["kitapadi"].ToString(),
                        sayfaSayisi = int.Parse(dreader["sayfasayisi"].ToString()),
                        turNumara = int.Parse(dreader["turno"].ToString()),
                        yazarNumara = int.Parse(dreader["yazarno"].ToString())
                    };
                    kitaplar.Add(kitap);
                }
                return kitaplar;
            }
            return null;
        }

        DataAccessKatman.DataAccess dataAccess2 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public List<Kitaplar> kitapGosterme(string deger)
        {
            //Bu fonksiyonun önceki fonksiyondan farkı burada aldıgımız deger paremetresi ile istedigimiz kaydı ekrana getiriyoruz (veri tabanındaki)
            //DataAccess Sınıfındaki Fonksiyon ile kitap tablosundaki deger türünde aldıgımız veriyi tabloda arıyoruz
            OleDbDataReader dreader = dataAccess2.DRVeriCekme("Select * From kitap WHERE kitapno=" +deger + "", CommandType.Text);
            
            if(dreader.HasRows)
            {
                //Eger tabloda bu veri var ise yani bos degil ise bu veriyi Kitaplar sınıfında olusturdugumuz listeye gönderiyoruz
                //Bu liste bize aradagımız kitap numarasinda olan kitap bilgileri var ise bunu return ediyor.
                List<Kitaplar> kitaplar = new List<Kitaplar>();
                while(dreader.Read())
                {
                    Kitaplar kitap = new Kitaplar()
                    {
                        kitapNumara = int.Parse(dreader["kitapno"].ToString()),
                        kitapAd = dreader["kitapadi"].ToString(),
                        sayfaSayisi = int.Parse(dreader["sayfasayisi"].ToString()),
                        turNumara = int.Parse(dreader["turno"].ToString()),
                        yazarNumara = int.Parse(dreader["yazarno"].ToString())
                    };
                    kitaplar.Add(kitap);
                }
                return kitaplar;
            }
            return null;
        }

        DataAccessKatman.DataAccess dataAccess3 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public int kitapEkleme(int kitapNumarasi, string kitapAdi, string yazarNo, string turNo, string sayfaSayisi)
        {
            //DataAccess Katmanındaki EkleSilGüncelleme Fonksiyonu ile kitap tablosuna aldıgımız parametredeki bilgileri insert ediyoruz yani tabloya kitapları ekliyoruz
            int sonuc = dataAccess3.EkleSilGüncelleme("insert into kitap (kitapno,kitapadi,yazarno,turno,sayfasayisi) VALUES ('" + kitapNumarasi
                + "','" +kitapAdi+ "','"+ yazarNo + "','" + turNo + "','" + sayfaSayisi + "')",System.Data.CommandType.Text);
            return sonuc;
        }

        DataAccessKatman.DataAccess DataAccess4 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public int kitapGuncelleme(int kitapNumarasi, string kitapAdi, string sayfaSayisi, string turNo, string yazarNo)
        {
            //DataAccess Katmanındaki EkleSilGuncelleme Fonksiyonu ile parametre aldıgımız kitap bilgilerini update sorgusu ile kitap tablosundaki bilgileri güncelliyoruz
            int sonuc = DataAccess4.EkleSilGüncelleme("UPDATE kitap set kitapadi ='" + kitapAdi
                + "',sayfasayisi='" + sayfaSayisi + "',turno= '" + turNo + "',yazarno='" + 
                yazarNo + "'" + "Where kitapno = " + kitapNumarasi + "", System.Data.CommandType.Text);
            return sonuc;
        }

        DataAccessKatman.DataAccess DataAccess5 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public int kitapSilme(int kitapNumarasi)
        {
            //DataAccess Katmanındaki EkleSilGüncelleme Fonksiyonu ile aldıgımız parametreyi kitap tablosunda arıyoruz
            //eger boyle bir kitap numarasi varsa o kitap tablodan delete sorgusu ile silinir sil
            int sonuc = DataAccess5.EkleSilGüncelleme("Delete From kitap Where kitapno = " + 
                kitapNumarasi + "", System.Data.CommandType.Text);
            return sonuc;
        }

        DataAccessKatman.DataAccess dataAccess6 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public List<Islemler> kitapKayitlariListele(int kitapNumarasi)
        {
            // DataAccess Katmanındaki Fonksiyon ile aldıgımız parametreyi veritabanındaki islem tablosunda arıyoruz
            //Eger boyle islem varsa islem tablosunda o kitap numarasındaki bilgileri alıyoruz ve İslemler sınıfından urettiğimiz listeye gönderiyoruz
            //Ve bu listeyide return ediyoruz.
             OleDbDataReader dreader = dataAccess6.DRVeriCekme
                ("Select * From islem Where kitapno="
                + kitapNumarasi + "", CommandType.Text);

            if (dreader.HasRows)
            {
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

        DataAccessKatman.DataAccess dataAccess7 = new DataAccessKatman.DataAccess();
        //dataAccess Katmanındaki Sınıfını kullanmak için nesne ürettik
        public bool yazarKontrol(int yazarNumarasi)
        {
            //Burada DataAccess Katmanındaki DRVeriCekme Fonksiyonu ile aldgımız parametreyi yazar tablosunda arıyoruz
            //Eger boyle bir kayıt varsa true yoksa false deger gönderiyoruz ve yazarın olup olmadıgını kontrol ediyoruz
            OleDbDataReader dreader = dataAccess7.DRVeriCekme("Select * From yazar Where yazarno=" + yazarNumarasi + "", CommandType.Text);
            if(dreader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }

        DataAccessKatman.DataAccess dataAccess8 = new DataAccessKatman.DataAccess();
        //Burada DataAccess Katmanındaki DRVeriCekme Fonksiyonu ile aldgımız parametreyi yazar tablosunda arıyoruz

        public bool kitapKontrol(int kitapNumarasi)
        {
            //Burada DataAccess Katmanındaki DRVeriCekme Fonksiyonu ile aldgımız parametreyi kitap tablosunda arıyoruz
            //Eger boyle bir kayır varsa tabloda true yoksa false deger gonderiyorum boylece kitabın kontrolunu yapıyoruz.
            OleDbDataReader dreader = dataAccess8.DRVeriCekme("Select * From kitap Where kitapno=" + kitapNumarasi + "", CommandType.Text);
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

