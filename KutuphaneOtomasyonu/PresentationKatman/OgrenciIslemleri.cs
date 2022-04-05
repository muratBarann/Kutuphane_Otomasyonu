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
    public partial class OgrenciIslemleri : Form
    {
        public OgrenciIslemleri()
        {
            InitializeComponent();
        }
    
        //Burada ogrenciİslemleriBusiness sınıfından nesne üretiyoruz business katmanındaki sınıfın özelliklerini kullanabilmek için.

        ogrenciIslemleriBusiness ogrislem = new ogrenciIslemleriBusiness();
        ogrenciIslemleriBusiness ogrislem2 = new ogrenciIslemleriBusiness();

        private void button_ogr_ekle_Click(object sender, EventArgs e)
        {
            //Burada eger ogrenci ekle butonuna tıklandıgında önce if kontrolu ile textboxların ve comboboxların doğrulaması yani bos olmaması kontrolu yapılır.
            //ve bos olup olmamasına göre ekrana mesaj gönderilir.
            if ((textBox_adi.Text.Length > 0) && (textBox_numara.Text.Length > 0) && (textBox_soyadi.Text.Length > 0) && (textBox_dogumtarih.Text.Length > 0) && (textBox_sinif.Text.Length > 0))
            {
                //Eger bos değilse ogrenci ekleme işlemi fonksiyonu cagrılır ve aldıgımız textboxların ve combobaxın verileri paremetre olarak aktarılır fonksiyona
                int sonuc;
                sonuc = ogrislem.ogrenciEkle(int.Parse(textBox_numara.Text), textBox_adi.Text, 
                    textBox_soyadi.Text, comboBox_cinsiyet.SelectedItem.ToString(), textBox_dogumtarih.Text, textBox_sinif.Text);

                MessageBox.Show("Kayıt İşlemi Gerçekleşti");
            }
            else
            {
                MessageBox.Show("Tüm Alanları Eksiksiz Doldurunuz.");
            }
            

        }

        private void button_ogr_sil_Click(object sender, EventArgs e)
        {
            //Burada eger Öğrenci silme butonuna tıklanırsa ilk önce ogrenci numarası parametre olarak alınır ve ogrenciKontrol Fonksiyonunda kontrol edilir
            //eger parametre varsa ogrenciSilme fonksiyonu cagrılır ve ogrenci silinir
            //if ve else her 2 durumdada mesaj gönderilir ekrana
            if(ogrislem.ogrenciKontrol(int.Parse(textBox_numara.Text)))
            {
                ogrislem.ogrenciSilme(int.Parse(textBox_numara.Text));
                MessageBox.Show("Öğrenci Silindi");
            }
            else
            {
                MessageBox.Show("Boyle Bir Öğrenci Bulunamadı");
            }
        }

        private void button_ogr_guncelle_Click(object sender, EventArgs e)
        {
            //Burada eger ogrenci güncelleme butonuna tıklanırsa ilk önce tüm textboxların ve combobaxın bos olup olmadığı kontrol edilir.
            //eger bos degilse ogrenci numarası ogrenciKontrol fonksiyonu ile veritabanında varmı yokmu diye kontrol edilir
            //eger var ise boyle bir ogrenci ogrenciGüncelleme ile ogrenci bilgileri guncellenir
            //if if ve else 3 durum içinde ekrana mesaj gönderilir.
                if ((textBox_adi.Text.Length > 0) && (textBox_numara.Text.Length > 0) && (textBox_soyadi.Text.Length > 0) && (textBox_dogumtarih.Text.Length > 0) && (textBox_sinif.Text.Length > 0))
                {
                    if(ogrislem.ogrenciKontrol(int.Parse(textBox_numara.Text)))
                    {
                        int sonuc;
                        sonuc = ogrislem.ogrenciGuncelleme(int.Parse(textBox_numara.Text), textBox_adi.Text, textBox_soyadi.Text, comboBox_cinsiyet.SelectedItem.ToString(), textBox_dogumtarih.Text, textBox_sinif.Text);
                        MessageBox.Show("Öğrenci Başarıyla Güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("Boyle Bir Ogrenci Bulunamadı");
                    }
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Eksiksiz Doldurunuz.");
                }
            
        }

        private void button_anaSayfa_Click(object sender, EventArgs e)
        {
            //burada anasayfa butonuna tıklanırsa ana sayfa formu için nesne olusturulur ve show metodu calıstırılır.
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void button_ogr_ara_Click(object sender, EventArgs e)
        {
            //Burada ogrenci Ara butonuna tıklanırsa ilk önce bosmu diye bakılır textboxa
            //eger bos degilse Ogrenciler sınıfından bir liste tipinde nesne üretilir ve buraya parametre olarak aramadaki textboxu alan ogrenciGosterme Fonksiyonundan gelen liste atanır ve bu dataGridView'e yazdırılır.
            //eger liste bos veye degilse her 2 durum icinde ekrana mesaj gönderilir.
            if(textBox_arama.Text.Length > 0)
            {
                List<Ogrenciler> ogrenci1 = ogrislem.ogrenciGosterme(int.Parse(textBox_arama.Text));
                ogrencileriListele.DataSource = ogrenci1;

                if (ogrenci1 != null)
                {
                    MessageBox.Show("Ögrenci Listelendi");
                }
                else
                {
                    MessageBox.Show("Böyle Bir Kayıt Bulunmamaktadır.");
                }
            }
            else
            {
                MessageBox.Show("Arama Alanını Boş Bırakmayınız");
            }

            
        }

        
        private void button_ogr_tumkayıtlar_Click(object sender, EventArgs e)
        {
            //Burada eğer Tüm Kayıtları Listele butonuna basılırsa ogrencileriListele adındaki dataGridView'in icerigine ogrenciGosterme Fonksiyonundan gelen liste atanır.
            //ve ekrana mesaj gösterilir.
            ogrencileriListele.DataSource = ogrislem.ogrenciGosterme();
            MessageBox.Show("Öğrenciler Gösterildi");
        }

        private void OgrenciIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
