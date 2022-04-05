using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DataAccessKatman
{
    //Veritabanının bilgisayardaki yolunu yazıyoruz.
    public class Baglanti
    {
        public const string adres = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kutuphane.mdb";
    }
}
