using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessKatmani;
using DataAccessKatman;
using EntityKatmanı;
using KutuphaneOtomasyonu;
using PresentationKatmanı;

namespace KutuphaneOtomasyonu
{
    public partial class islemArama : Form
    {
        public islemArama()
        {
            InitializeComponent();
        }
        //Burada islemBusinesscs, ogrenciIslemleriBusiness, kitapIslemleriBusiness sınıflarındaki method ve özelliklere erişmek için nesneler olusturulmustur.

        islemBusinesscs islem_arama = new islemBusinesscs();
        ogrenciIslemleriBusiness ogrenci_islem = new ogrenciIslemleriBusiness();
        kitapIslemleriBusiness islem_arama2 = new kitapIslemleriBusiness();

        private void button_ogrenciAra_Click(object sender, EventArgs e)
        {
            //Burada eger Ogrenci Ara butonuna tıklarsa ilk önce öğrenci numarasının textboxu bosmu diye kontrol edilir
            //eger bos degilse Islemler sınıfında liste tipinde bir nesne oluşturulur.
            //ogrenciEmanetİadeListesi cagrılır ve fonksiyonun parametresine ogrenci numarasının textboxu gönderilir.
            //Sonra listeye bu fonksiyondan gelen liste atanır. bu listede ogrenciListeleye yani dataGridView'e aktarılır eger bos degilse dataGridView ekrana yazdırılır ve mesaj atılır.
            //en sonda ise islemAramaRenk fonksiyonu cagrilir ve parametre olarak dataGridView gönderilir islemlerin renklendirilmesi için
            //diger durumlar içinde ekrana mesaj gönderilir.

            if (textBox_ogrenciNumarasi.Text.Length > 0)
            {
                List<Islemler> ogrenciArama = new List<Islemler>();
                ogrenciArama = islem_arama.ogrenciEmanetIadeListesi(int.Parse(textBox_ogrenciNumarasi.Text));
                ogrenciListele.DataSource = ogrenciArama;
                islemAramaRenk(ogrenciListele);
                if (kitapListele.DataSource != null)
                {
                    MessageBox.Show("Bu Numarada İşlem Yapmış Öğrenci Bulundu");
                }
                else
                {
                    MessageBox.Show("Bu Numarada İşlem Yapmış Öğrenci Bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Eksiksiz Doldurunuz.");
            }
        }

        private void islemArama_Load(object sender, EventArgs e)
        {

        }

        private void button_kitapAra_Click(object sender, EventArgs e)
        {
            //Burada eger kitap Ara butonuna tıklanırsa önce kitap numarasının textboxu bosmu diye bakılır
            //bos degilse Islemler sınıfından liste tipinde bir nesne olusturulur 
            //bu nesneye kitapKayitlariListele fonksiyonundan gelen liste aktarılır ve bu liste kitapListele dataGridViewe yazdırılır
            //ve islemAramaRenk fonksiyonu kitapListele dataGridView 'e yani parametre olarak alarak islemlere renklendirme yapar
            //her durum icin ise ekrana mesaj gönderilmiştir MessageBox.Show() methodu ile

            if(textBox_kitapNumarasi.Text.Length >0)
            {
                List<Islemler> kitapArama = new List<Islemler>();
                kitapArama = islem_arama2.kitapKayitlariListele(int.Parse(textBox_kitapNumarasi.Text));
                kitapListele.DataSource = kitapArama;
                islemAramaRenk(kitapListele);
                if(kitapListele.DataSource != null)
                {
                    MessageBox.Show("Bu Numarada İşlem Yapılmış Kitap Bulundu");
                }
                else
                {
                    MessageBox.Show("Bu Numarada İşlem Yapılmış Kitap Bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Eksiksiz Doldurunuz.");
            }
        }

        public void islemAramaRenk(DataGridView dgv)
        {
            double ceza;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                string islemTuru;
                islemTuru = dgv.Rows[i].Cells[6].Value.ToString();
                if (islemTuru == "iade yapıldı")
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                if (islemTuru != "iade yapıldı")
                {
                    string t1, t2;
                    DateTime s1, s2, t3;
                    TimeSpan fark;
                    t1 = DateTime.Now.ToShortDateString();
                    t3 = DateTime.Parse(dgv.Rows[i].Cells[4].Value.ToString());
                    t2 = t3.ToShortDateString();
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);

                    if (Int32.Parse(fark.TotalDays.ToString()) > -3 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }

                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        dgv.Rows[i].Cells[5].Value = ceza;
                    }
                }
            }
        }

        private void button_anasayfa_Click(object sender, EventArgs e)
        {
            //Burada eger ana sayfa butonuna tıklanırsa Form1 adındaki formdan yeni nesne üretilir ve show metodu ile form ekrana gösterilir.
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }
    }
}
