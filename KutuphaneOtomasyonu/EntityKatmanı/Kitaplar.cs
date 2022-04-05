using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmanı
{
    public class Kitaplar
    {
        //Kitap bilgiler için değişkenler ve sınıf oluşturuldu
        //Amac diger katmanlardan bu sınıfa rahatca ve kolayca erişebilsin diye
        public int kitapNumara { get; set; }
        public string kitapAd { get; set; }
        public int yazarNumara { get; set; }
        public int turNumara { get; set; }
        public int sayfaSayisi { get; set; }
    }
}
