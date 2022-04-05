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
    public partial class kitapIslemleri : Form
    {
        public kitapIslemleri()
        {
            InitializeComponent();
        }

        //Kitap islemleri için kitapIslemleriBusiness sınıfndan yeni nesne üretilir oradaki fonksiyon ve özelliklere erişmek için
        kitapIslemleriBusiness kitap_islemleri = new kitapIslemleriBusiness();
       
        private void button_Ana_sayfa_Click(object sender, EventArgs e)
        {
            //Burada eger ana sayfa butonuna tıklanırsa Form1 adındaki formdan yeni nesne üretilir ve show metodu ile form ekrana gösterilir.
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void button_kitap_ekle_Click(object sender, EventArgs e)
        {
            //Burada eger kitap ekle butonuna basılırsa öncelikle textboxların içlerine bakılır 
            //eger bos degilse yazar kontrolu yapılır eger yazılan yazar numarası veri tabanında var ise yazılan textbox ve combobaxları parametre alan kitapEkleme fonksiyonu calıstırılır
            //3 durum içinde ekrana mesaj gönderilir.
            if ((textBox_kitapNumarasi.Text.Length > 0) && (textBox2_kitapAdi.Text.Length > 0) && 
                (textBox_yazarNumarasi.Text.Length > 0) && (textBox4_sayfaSayisi.Text.Length > 0) && (comboBox_turNumarasi.SelectedItem.ToString().Length > 0))
            {
                if(kitap_islemleri.yazarKontrol(int.Parse(textBox_yazarNumarasi.Text)))
                {
                    int sonuc;
                    sonuc = kitap_islemleri.kitapEkleme(int.Parse(textBox_kitapNumarasi.Text), textBox2_kitapAdi.Text, textBox_yazarNumarasi.Text, comboBox_turNumarasi.SelectedItem.ToString(), textBox4_sayfaSayisi.Text);
                    MessageBox.Show("Kitap Eklendi");
                }
                else
                {
                    MessageBox.Show("Boyle bir Yazar bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Eksiksiz Doldurunuz.");
            }
        }

        private void button_tum_kayitlar_Click(object sender, EventArgs e)
        {
            //Burada eger Tüm Kayıtları Listele butonuna tıklanırsa Kitaplar sinifindan teni bir liste üretilir
            //ve bu listeye kitap_islemleri nesnesi ile kitapGosterme fonksiyonu ile bilgileri listeye alıyoruz ve bunu kitap adındaki listeye atama yapıyoruz
            //Ve kitap adındaki listeyi kitapListele adındaki dataGridView 'e gönderiyoruz ekranda gösterebilmek için.
            List<Kitaplar> kitap = new List<Kitaplar>();
            kitap = kitap_islemleri.kitapGosterme();
            kitapListele.DataSource = kitap;
        }

        private void button_kitap_sil_Click(object sender, EventArgs e)
        {
            //Burada eger kitap sil butonuna tıklanırsa öncelikle kitap numarasinin textboxuna bakılır bos degilse alınan kitap numarasi veri tabanında bir kayıt içeriyormu diye bakılır 
            //eger kayıt içeriyorsa o kayıt kitapSilme fonksiyonu ile veri tabanından silir.
            //diger durumlar için ise ekrana mesaj gönderildi
            if(textBox_kitapNumarasi.Text.Length > 0)
            {
                if(kitap_islemleri.kitapKontrol(int.Parse(textBox_kitapNumarasi.Text)))
                {
                    int sonuc;
                    sonuc = kitap_islemleri.kitapSilme(int.Parse(textBox_kitapNumarasi.Text));
                    MessageBox.Show("Kitap Silindi");
                }
                else
                {
                    MessageBox.Show("Boyle Bir Kitap Bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kitap Numarasini Giriniz. ");
            }
        }

        private void button_kitap_güncelle_Click(object sender, EventArgs e)
        {
            //Burada eger kitap güncelleme butonuna tıklanırsa öncelikle textboxların içlerine bakılır dolumu diye
            //eger dolu ise yazılan kitap numarasi kitapKontrol Fonksiyonu ile bakılır veri tabanında bu kitap numarasi ile ilgili kayıt varmı
            //eger boyle bir kayıt varsa sonra yazarKontrol adındaki Fonksiyona yazar numarası girilen textbox parametre olarak gönderilir
            //eger varsa oyle bir yazar kitapGüncelleme fonksiyonuna textboxdaki bilgiler parametre olarak gönderilir ve kitap güncellenir
            //her durum içinde ekrana mesaj gönderilir.
            if ((textBox_kitapNumarasi.Text.Length > 0) && (textBox2_kitapAdi.Text.Length > 0) &&
                (textBox_yazarNumarasi.Text.Length > 0) && (textBox4_sayfaSayisi.Text.Length > 0) && (comboBox_turNumarasi.SelectedItem.ToString().Length > 0))
            {
                if(kitap_islemleri.kitapKontrol(int.Parse(textBox_kitapNumarasi.Text)))
                {
                    if (kitap_islemleri.yazarKontrol(int.Parse(textBox_yazarNumarasi.Text)))
                    {
                        int sonuc;
                        sonuc = kitap_islemleri.kitapGuncelleme(int.Parse(textBox_kitapNumarasi.Text), textBox2_kitapAdi.Text, textBox4_sayfaSayisi.Text, comboBox_turNumarasi.SelectedItem.ToString(), textBox_yazarNumarasi.Text);
                        MessageBox.Show("Kitap Güncellendi. ");
                    }
                }
                else
                {
                    MessageBox.Show("Boyle Bir Kitap Bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Eksiksiz Doldurunuz. ");
            }

        }

        private void button_kitap_ara_Click(object sender, EventArgs e)
        {
            //Burada eger kitap ara butonuna basılırsa ilk önce kitap numarası adındaki textboxa bakılır textbox bos degilse Kitaplar sınıf türünde bir liste nesnesi üretilir
            //bu nesne kitapGosterme fonksiyonunu cagırır bu fonksiyonun textboxu parametre alır ve gelecek olan veritabanındaki kayıtı kitapListele adındaki dataGridView'e aktarır
            //eger dataGridView bos degilse kitapları listeler
            //diger durumlar için isede mesajlar ekrana gönderilir.

            if (textBox_kitapNumarasii.Text.Length>0)
            {
                List<Kitaplar> kitap = new List<Kitaplar>();
                kitap = kitap_islemleri.kitapGosterme(textBox_kitapNumarasii.Text);
                kitapListele.DataSource = kitap;
                if(kitap != null)
                {
                    MessageBox.Show("Kitap Listelendi. ");
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

        private void kitapIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
