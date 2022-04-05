using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtomasyonu;

namespace PresentationKatmanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button_ogrenciIslemleri_Click(object sender, EventArgs e)
        {
            //Burada Ogrenci islemleri butonuna basıldıgında
            //OgrenciIslemleri Formundan bir nesne üretiyoruz ve show metodu ilede OgrenciIslemleri Formunu ekrana getirmis oluyoruz 
            OgrenciIslemleri ogrenciislem = new OgrenciIslemleri();
            ogrenciislem.Show();
            this.Hide();
            //this.Hide() ile de önceki formu gizliyorum
        }

        private void button_kitap_islemleri_Click(object sender, EventArgs e)
        {
            //Kitap islemleri butonuna basıldıgına
            //kitapİslemleriAna formunda bir nesne üretilecek ve show metodu ilede bu Form ekrana gelecek
            kitapIslemleriAna kitap_islem_ana = new kitapIslemleriAna();
            kitap_islem_ana.Show();
            this.Hide();
            //this.Hide() ile de önceki formu gizliyorum
        }

        private void button_grafik_Click(object sender, EventArgs e)
        {
            //Grafik Butonuna Basıldıgında 
            //GrafikGosterimi formundan bir nesne üretilir ve show metodu ile bu form ekrana getirilir.
            grafikGosterimi grafik_islemi = new grafikGosterimi();
            grafik_islemi.Show();
            this.Hide();
            //this.Hide() ile de önceki formu gizliyorum
        }
    }
}
