
namespace KutuphaneOtomasyonu
{
    partial class kitapIslemleriAna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapIslemleriAna));
            this.button_kitap_islemleri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_emanet_verme = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_islem_arama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_kitap_islemleri
            // 
            this.button_kitap_islemleri.Image = ((System.Drawing.Image)(resources.GetObject("button_kitap_islemleri.Image")));
            this.button_kitap_islemleri.Location = new System.Drawing.Point(118, 32);
            this.button_kitap_islemleri.Name = "button_kitap_islemleri";
            this.button_kitap_islemleri.Size = new System.Drawing.Size(170, 137);
            this.button_kitap_islemleri.TabIndex = 0;
            this.button_kitap_islemleri.UseVisualStyleBackColor = true;
            this.button_kitap_islemleri.Click += new System.EventHandler(this.button_kitap_islemleri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Ekleme Silme Güncelleme Ve Arama İşlemleri";
            // 
            // button_emanet_verme
            // 
            this.button_emanet_verme.Image = ((System.Drawing.Image)(resources.GetObject("button_emanet_verme.Image")));
            this.button_emanet_verme.Location = new System.Drawing.Point(619, 32);
            this.button_emanet_verme.Name = "button_emanet_verme";
            this.button_emanet_verme.Size = new System.Drawing.Size(166, 137);
            this.button_emanet_verme.TabIndex = 2;
            this.button_emanet_verme.UseVisualStyleBackColor = true;
            this.button_emanet_verme.Click += new System.EventHandler(this.button_emanet_verme_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(546, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Emanet Verme Ve İade İşlemi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(180, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(507, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğrenci Numarası Ve Kitap Numarası İle İşlem Arama";
            // 
            // button_islem_arama
            // 
            this.button_islem_arama.Image = ((System.Drawing.Image)(resources.GetObject("button_islem_arama.Image")));
            this.button_islem_arama.Location = new System.Drawing.Point(362, 265);
            this.button_islem_arama.Name = "button_islem_arama";
            this.button_islem_arama.Size = new System.Drawing.Size(166, 137);
            this.button_islem_arama.TabIndex = 5;
            this.button_islem_arama.UseVisualStyleBackColor = true;
            this.button_islem_arama.Click += new System.EventHandler(this.button_islem_arama_Click);
            // 
            // kitapIslemleriAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(923, 478);
            this.Controls.Add(this.button_islem_arama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_emanet_verme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_kitap_islemleri);
            this.Name = "kitapIslemleriAna";
            this.Text = "kitapIslemleriAna";
            this.Load += new System.EventHandler(this.kitapIslemleriAna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_kitap_islemleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_emanet_verme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_islem_arama;
    }
}