
namespace PresentationKatmanı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button_ogrenciIslemleri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_kitap_islemleri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_grafik = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "KÜTÜPHANE OTOMASYONU";
            // 
            // button_ogrenciIslemleri
            // 
            this.button_ogrenciIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("button_ogrenciIslemleri.Image")));
            this.button_ogrenciIslemleri.Location = new System.Drawing.Point(71, 109);
            this.button_ogrenciIslemleri.Name = "button_ogrenciIslemleri";
            this.button_ogrenciIslemleri.Size = new System.Drawing.Size(179, 157);
            this.button_ogrenciIslemleri.TabIndex = 4;
            this.button_ogrenciIslemleri.UseVisualStyleBackColor = true;
            this.button_ogrenciIslemleri.Click += new System.EventHandler(this.button_ogrenciIslemleri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Öğrenci İşlemleri";
            // 
            // button_kitap_islemleri
            // 
            this.button_kitap_islemleri.Image = ((System.Drawing.Image)(resources.GetObject("button_kitap_islemleri.Image")));
            this.button_kitap_islemleri.Location = new System.Drawing.Point(605, 96);
            this.button_kitap_islemleri.Name = "button_kitap_islemleri";
            this.button_kitap_islemleri.Size = new System.Drawing.Size(179, 157);
            this.button_kitap_islemleri.TabIndex = 7;
            this.button_kitap_islemleri.UseVisualStyleBackColor = true;
            this.button_kitap_islemleri.Click += new System.EventHandler(this.button_kitap_islemleri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(621, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kitap İşlemleri";
            // 
            // button_grafik
            // 
            this.button_grafik.BackColor = System.Drawing.Color.DarkGray;
            this.button_grafik.Image = ((System.Drawing.Image)(resources.GetObject("button_grafik.Image")));
            this.button_grafik.Location = new System.Drawing.Point(341, 284);
            this.button_grafik.Name = "button_grafik";
            this.button_grafik.Size = new System.Drawing.Size(179, 157);
            this.button_grafik.TabIndex = 9;
            this.button_grafik.UseVisualStyleBackColor = false;
            this.button_grafik.Click += new System.EventHandler(this.button_grafik_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Grafik Gösterimi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(921, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_grafik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_kitap_islemleri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_ogrenciIslemleri);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ogrenciIslemleri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_kitap_islemleri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_grafik;
        private System.Windows.Forms.Label label4;
    }
}

