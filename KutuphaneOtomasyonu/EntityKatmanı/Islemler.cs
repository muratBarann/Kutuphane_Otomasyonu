using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmanı
{
    public class Islemler
    {
        //Emanet iade işlemleri için sınıf ve degiskenler olusturuldu
        //Amac diger katmanlardan bu sınıfa rahatca ve kolayca erişebilsin diye
        public int islemNumarasi { get; set; }
        public int ogrenciNumarisi { get; set; }
        public int kitapNumarasi { get; set; }
        public string alisTarihi { get; set; }
        public string verisTarihi { get; set; }
        public int ceza { get; set; }
        public string islemTuru { get; set; }

    }
}
