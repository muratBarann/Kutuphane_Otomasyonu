using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessKatman;
using EntityKatmanı;
using KutuphaneOtomasyonu;
using BusinessKatmani;
using PresentationKatmanı;

namespace KutuphaneOtomasyonu
{
    public partial class EmanetVerme : Form
    {

        //Burada islemBusinesscs, ogrenciIslemleriBusiness, kitapIslemleriBusiness sınıflarındaki method ve özelliklere erişmek için nesneler olusturulmustur.
        islemBusinesscs emanetIslemleri = new islemBusinesscs();
        ogrenciIslemleriBusiness ogrenci_isleri = new ogrenciIslemleriBusiness();
        kitapIslemleriBusiness kitap_isleri = new kitapIslemleriBusiness();

        public EmanetVerme()
        {
            InitializeComponent();
        }

        private void button_emanet_ver_Click(object sender, EventArgs e)
        {
            //Burada eger emanet ver butonuna tıklanırsa ilk önce textboxlara bakılır eğer boş degillerse öğrenci numarasi ogrenciKontrol fonksiyonu ile öğrenci numarasi parametresi alarak kontrol edilir ve aynı sekilde kitap numarasi kontrol edilir
            //kitap numarasi kitapKontrol fonksiyonuna parametre olarak gönderilir eger bu 2 şart yani öğrenci numarasi ve kitap numarasi veritabanında kayıtları var ise 
            //emanet islemi fonksiyonu calısır bu fonksiyon buradaki textboxları ve dataTimePickerları parametre olarak alır veritabanına islemi yapar ve ekrana mesaj gönderir
            //diger durumlar içinde ekrana mesaj gönderilir.
            if((textBox_kitapNumarasi.Text.Length >0)&&(textBox_ogrenciNumarasi.Text.Length>0)&&(dateTimePicker_emanetVerme.Value.ToString().Length>0)&&(dateTimePicker_emanetalma.Value.ToString().Length>0))
            {
                if((ogrenci_isleri.ogrenciKontrol(int.Parse(textBox_ogrenciNumarasi.Text))) &&(kitap_isleri.kitapKontrol(int.Parse(textBox_kitapNumarasi.Text))))
                {
                    int sonuc;
                    sonuc = emanetIslemleri.emanet_islemi(int.Parse(textBox_kitapNumarasi.Text), int.Parse(textBox_ogrenciNumarasi.Text), DateTime.Parse(textBox_emanetverme.Text), DateTime.Parse(textBox_tarih_emanetalma.Text),"alım");
                    MessageBox.Show("Alım Başarıyla Yapıldı. ");
                }
                else
                {
                    MessageBox.Show("Kitap Numarasını Veya Ogrenci Numarasını Yanlıs Girdiniz .");
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Eksiksiz Doldurunuz.");
            }
        }

        private void dateTimePicker_emanetVerme_ValueChanged(object sender, EventArgs e)
        {
            //Burada tarih kısmından sectigimiz tarihi emanet verme tarihine vermek textbox'a göndermek için yapıyoruz
            textBox_emanetverme.Text = dateTimePicker_emanetVerme.Value.ToShortDateString();
        }

        private void dateTimePicker_emanetalma_ValueChanged(object sender, EventArgs e)
        {
            //Burada tarih kısmından sectigimiz tarihi emanet alma tarihine vermek textbox'a göndermek için yapıyoruz
            textBox_tarih_emanetalma.Text = dateTimePicker_emanetalma.Value.ToShortDateString();
        }

        private void button_tum_kayitlar_Click(object sender, EventArgs e)
        {   
            //Burada eğer Tüm Kayıtları Listeleme butonuna tıklanırsa Islemler sınıfından liste tipinde bir nesne üretilir
            //Bu listeye iadeIslemi Fonksiyonu cagrılarak buradaki gelen listeyi aktarırız
            //en son emanetListele dataGridView'e bu listedeki veriler aktarılır ve ekrana yazdırılır
            //ve emanetIadeRenk fonksiyonu ilede kayıtlardaki renkleri düzenliyoruz
            List<Islemler> islem = new List<Islemler>();
            islem = emanetIslemleri.iadeIslemi();
            EmanetListele.DataSource = islem;
            emanetIadeRenk();
        }

        private void button_iadeEtme_Click(object sender, EventArgs e)
        {
            //Burada eger iade etme butonuna tıklanırsa önce kitap numarasi ve öğrenci numarasi varmı diye kontrolu yapılır sonra ise fonskiyonlar ilede veritabanında varmı diye kontrol edilir
            //eger iki numarada veritabanında var ise iadeyiGuncelleme fonksiyonu cagrilir parametre olarakda öğrenci numarası ve kitap numarası alır
            //ve tüm durumlar içinse ekrana mesaj gönderilir.

            if((textBox_iade_ogrenciNumarasi.Text.Length >0) && (textBox_iade_kitapNumarasi.Text.Length >0))
            {
                if((ogrenci_isleri.ogrenciKontrol(int.Parse(textBox_iade_ogrenciNumarasi.Text)))&&(kitap_isleri.kitapKontrol(int.Parse(textBox_iade_kitapNumarasi.Text))))
                {
                    int sonuc;
                    sonuc = emanetIslemleri.iadeyiGuncelleme(int.Parse(textBox_iade_ogrenciNumarasi.Text), int.Parse(textBox_iade_kitapNumarasi.Text), "iade yapıldı");
                    MessageBox.Show("İade Başarılı Bir Şekilde Yapıldı. ");

                }
                else
                {
                    MessageBox.Show("Kitap Numarasını Veya Ogrenci Numarasını Yanlıs Girdiniz .");
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Eksiksiz Doldurunuz.");
            }
        }

        private void EmanetVerme_Load(object sender, EventArgs e)
        {

        }

        private void button_anaSayfa_Click(object sender, EventArgs e)
        {
            //Burada eger ana sayfa butonuna tıklanırsa Form1 adındaki formdan yeni nesne üretilir ve show metodu ile form ekrana gösterilir.
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        
        public void emanetIadeRenk()
        {
            double ceza;
            for(int i=0; i<EmanetListele.Rows.Count; i++)
            {
                string islemTuru;
                islemTuru = EmanetListele.Rows[i].Cells[6].Value.ToString();
                if(islemTuru == "iade yapıldı")
                {
                    EmanetListele.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    EmanetListele.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                if(islemTuru != "iade yapıldı")
                {
                    string t1, t2;
                    DateTime s1, s2,t3;
                    TimeSpan fark;
                    t1 = DateTime.Now.ToShortDateString();
                    t3 = DateTime.Parse(EmanetListele.Rows[i].Cells[4].Value.ToString());
                    t2 = t3.ToShortDateString();
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);

                    if(Int32.Parse(fark.TotalDays.ToString()) >-3 && Int32.Parse(fark.TotalDays.ToString()) <1)
                    {
                        EmanetListele.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        EmanetListele.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }

                    if(Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        EmanetListele.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        EmanetListele.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if(Int32.Parse(fark.TotalDays.ToString())>0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        EmanetListele.Rows[i].Cells[5].Value = ceza;
                    }
                }
            }
        }
    }
}
