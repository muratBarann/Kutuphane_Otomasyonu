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
using ZedGraph;

namespace KutuphaneOtomasyonu
{
    public partial class grafikGosterimi : Form
    {
        public grafikGosterimi()
        {
            InitializeComponent();
        }
        //Burada islemTuruBusiness sınıfından nesne üretiyoruz business katmanındaki sınıfın özelliklerini kullanabilmek için.
        islemTuruBusiness grafik = new islemTuruBusiness();
        private void button_Ana_sayfa_Click(object sender, EventArgs e)
        {
            // Burada eger ana sayfa butonuna tıklanırsa Form1 adındaki formdan yeni nesne üretilir ve show metodu ile form ekrana gösterilir.
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Hide();
        }

        private void grafikGosterimi_Load(object sender, EventArgs e)
        {
            //Burada Load fonksiyonu oldugu için direk çalışır yani bir butona tıklamaya gerek yok
            //iki degisken olusturduk ve bu degiskenlere listeleme ve alma fonksiyonlarıyla veritabanındaki kitap sayılarını degiskenlere atadık
            int butunKitaplar, emanetKitaplar;
            butunKitaplar = grafik.listeleme();
            emanetKitaplar = grafik.alma();

            GraphPane pane = new GraphPane();
            pane = zedGraphControl1.GraphPane;
            
            // Burada satirlarin isimleri ve karsılarına gelecek degerleri hesapladık ve  dizilerle sakladık
            string[] satir_isimleri = { "Emanet Verilen Kitaplar", "Kütüphanedeki Kitaplar", "Bütün Kitaplar" };
            double[] satir_verileri = { emanetKitaplar, butunKitaplar - emanetKitaplar, butunKitaplar };

            //Burada panel renkleri ve koordinatların bilgilerini atadık
            pane.AddPieSlices(satir_verileri, new[] { "Emanet Verilen Kitaplar", "Kütüphanedeki Kitaplar", null });
            pane.Legend.IsVisible = true;
            LineItem hat = pane.AddCurve(null, null, satir_verileri, Color.Red);
            hat.Line.Fill = new Fill(Color.Blue, Color.Yellow, Color.Red);
            pane.XAxis.Scale.TextLabels = satir_isimleri;
            pane.XAxis.Type = AxisType.Text;
            pane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);
            pane.Fill = new Fill(Color.FromArgb(250, 250, 255));
            zedGraphControl1.AxisChange();
        }
    }
}
