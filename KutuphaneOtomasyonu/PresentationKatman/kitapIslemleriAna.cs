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
    public partial class kitapIslemleriAna : Form
    {
        public kitapIslemleriAna()
        {
            InitializeComponent();
        }

        private void button_kitap_islemleri_Click(object sender, EventArgs e)
        {
            //Burada eger kitap islemleri butonuna tıklanırsa kitapİslemleri adındaki formdan bir nesne üretilir ve show metodu ile bu form ekrana gösterilir.
            kitapIslemleri kitapislem = new kitapIslemleri();
            kitapislem.Show();
            this.Hide();
        }

        private void button_emanet_verme_Click(object sender, EventArgs e)
        {
            //Burada eger Emanet Verme ve İade İşlemleri adı altındaki butona tıklanırsa EmanetVerme adındaki formdan yeni nesne olusturulur ve show metodu cagrılarak yeni form ekrana gösterilir. 
            EmanetVerme emanetVerme = new EmanetVerme();
            emanetVerme.Show();
            this.Hide();
        }

        private void button_islem_arama_Click(object sender, EventArgs e)
        {
            //Burada eger kitap numarası ve öğrenci numarası ile işlem arama butonuna tıklanırsa islemArama adındaki formdan yeni nesne üretilir ve show metodu cagrılır ve ekrana yeni form ekrana gösterilir.
            islemArama islem_Arama = new islemArama();
            islem_Arama.Show();
            this.Hide();
        }

        private void kitapIslemleriAna_Load(object sender, EventArgs e)
        {

        }
    }
}
