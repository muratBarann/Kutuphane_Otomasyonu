using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmanı
{
   public class Ogrenciler
    {
        //Öğrenci bilgileri için degiskenler ve sınıf olusturuldu
        //Amac diger katmanlardan bu sınıfa rahatca ve kolayca erişebilsin diye
        public int ogrenciNumara { get; set; }
        public string ogrenciAd { get; set; }
        public string ogrenciSoyad { get; set; }
        public string ogrenciCinsiyet{ get; set;}
        public string ogrenciDogumTarih { get; set; }
        public string ogrenciSinif { get; set; }

    }
}
