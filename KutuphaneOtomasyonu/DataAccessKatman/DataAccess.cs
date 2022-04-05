using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DataAccessKatman
{
    //Bunlar Access Veri Tabanında Kullanacağımız Sorgular
    public class DataAccess
    {
        private OleDbCommand SorguYaz(string Sorgu, CommandType SorguTipi)
        {
            AccessVeriTabanınabaglanma baglanti = new AccessVeriTabanınabaglanma();
            OleDbCommand cmd = baglanti.BaglantiAdresi.CreateCommand();
            cmd.CommandText = Sorgu;
            cmd.CommandType = SorguTipi;
            return cmd;
        }

        List<OleDbParameter> Parametreler = new List<OleDbParameter>();

        //Aldığımız Parametreleri sorguya eklemek için kullandığımız fonksiyon 

        private void ParametreleriSorguyaEkle(OleDbCommand CommandNesnesi)
        {
            CommandNesnesi.Parameters.AddRange(Parametreler.ToArray());
        }


        // Veri Tabanında ekleme,silme,güncelleme gibi sorgu işlemlerini
        // asağıdaki fonksiyon ile yapıyoruz.
        public int EkleSilGüncelleme(string Sorgu, CommandType SorguTipi)
        {
            try
            {
                OleDbCommand cmd = SorguYaz(Sorgu, SorguTipi);
                ParametreleriSorguyaEkle(cmd);
                int sonuc = cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd.Connection.Dispose();
                cmd.Dispose();
                return sonuc;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Burada Veri Tabanından veri çekmek için kullandığımız sorguları
        //asağıdaki fonksiyon ile yapıyoruz
        public OleDbDataReader DRVeriCekme(string Sorgu, CommandType SorguTipi)
        {
            OleDbCommand cmd = SorguYaz(Sorgu, SorguTipi);
            ParametreleriSorguyaEkle(cmd);
            OleDbDataReader dreader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dreader;
        }
    }
}
