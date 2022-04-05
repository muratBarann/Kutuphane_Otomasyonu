
namespace KutuphaneOtomasyonu
{
    partial class EmanetVerme
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
            this.EmanetListele = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_emanet_ver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_emanetalma = new System.Windows.Forms.DateTimePicker();
            this.textBox_tarih_emanetalma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_emanetVerme = new System.Windows.Forms.DateTimePicker();
            this.textBox_emanetverme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_kitapNumarasi = new System.Windows.Forms.TextBox();
            this.textBox_ogrenciNumarasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_tum_kayitlar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_iadeEtme = new System.Windows.Forms.Button();
            this.textBox_iade_kitapNumarasi = new System.Windows.Forms.TextBox();
            this.textBox_iade_ogrenciNumarasi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_anaSayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmanetListele)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmanetListele
            // 
            this.EmanetListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmanetListele.Location = new System.Drawing.Point(12, 333);
            this.EmanetListele.Name = "EmanetListele";
            this.EmanetListele.RowHeadersWidth = 51;
            this.EmanetListele.RowTemplate.Height = 24;
            this.EmanetListele.Size = new System.Drawing.Size(1071, 237);
            this.EmanetListele.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Controls.Add(this.button_emanet_ver);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker_emanetalma);
            this.groupBox1.Controls.Add(this.textBox_tarih_emanetalma);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker_emanetVerme);
            this.groupBox1.Controls.Add(this.textBox_emanetverme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_kitapNumarasi);
            this.groupBox1.Controls.Add(this.textBox_ogrenciNumarasi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Vermek İçin Giriş Bilgileri";
            // 
            // button_emanet_ver
            // 
            this.button_emanet_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_emanet_ver.ForeColor = System.Drawing.Color.Maroon;
            this.button_emanet_ver.Location = new System.Drawing.Point(23, 246);
            this.button_emanet_ver.Name = "button_emanet_ver";
            this.button_emanet_ver.Size = new System.Drawing.Size(440, 53);
            this.button_emanet_ver.TabIndex = 11;
            this.button_emanet_ver.Text = "EMANET VER";
            this.button_emanet_ver.UseVisualStyleBackColor = true;
            this.button_emanet_ver.Click += new System.EventHandler(this.button_emanet_ver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Emanet Süresi 15 gündür. 15 gün sonra her gün için ceza uygulanır";
            // 
            // dateTimePicker_emanetalma
            // 
            this.dateTimePicker_emanetalma.Location = new System.Drawing.Point(246, 164);
            this.dateTimePicker_emanetalma.Name = "dateTimePicker_emanetalma";
            this.dateTimePicker_emanetalma.Size = new System.Drawing.Size(209, 27);
            this.dateTimePicker_emanetalma.TabIndex = 9;
            this.dateTimePicker_emanetalma.ValueChanged += new System.EventHandler(this.dateTimePicker_emanetalma_ValueChanged);
            // 
            // textBox_tarih_emanetalma
            // 
            this.textBox_tarih_emanetalma.Location = new System.Drawing.Point(246, 131);
            this.textBox_tarih_emanetalma.Name = "textBox_tarih_emanetalma";
            this.textBox_tarih_emanetalma.Size = new System.Drawing.Size(209, 27);
            this.textBox_tarih_emanetalma.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(268, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Emanet Alınacak Tarih";
            // 
            // dateTimePicker_emanetVerme
            // 
            this.dateTimePicker_emanetVerme.Location = new System.Drawing.Point(21, 164);
            this.dateTimePicker_emanetVerme.Name = "dateTimePicker_emanetVerme";
            this.dateTimePicker_emanetVerme.Size = new System.Drawing.Size(209, 27);
            this.dateTimePicker_emanetVerme.TabIndex = 6;
            this.dateTimePicker_emanetVerme.ValueChanged += new System.EventHandler(this.dateTimePicker_emanetVerme_ValueChanged);
            // 
            // textBox_emanetverme
            // 
            this.textBox_emanetverme.Location = new System.Drawing.Point(21, 131);
            this.textBox_emanetverme.Name = "textBox_emanetverme";
            this.textBox_emanetverme.Size = new System.Drawing.Size(209, 27);
            this.textBox_emanetverme.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Emanet Verilecek Tarih";
            // 
            // textBox_kitapNumarasi
            // 
            this.textBox_kitapNumarasi.Location = new System.Drawing.Point(231, 65);
            this.textBox_kitapNumarasi.Name = "textBox_kitapNumarasi";
            this.textBox_kitapNumarasi.Size = new System.Drawing.Size(163, 27);
            this.textBox_kitapNumarasi.TabIndex = 3;
            // 
            // textBox_ogrenciNumarasi
            // 
            this.textBox_ogrenciNumarasi.Location = new System.Drawing.Point(231, 30);
            this.textBox_ogrenciNumarasi.Name = "textBox_ogrenciNumarasi";
            this.textBox_ogrenciNumarasi.Size = new System.Drawing.Size(163, 27);
            this.textBox_ogrenciNumarasi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numarası";
            // 
            // button_tum_kayitlar
            // 
            this.button_tum_kayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_tum_kayitlar.ForeColor = System.Drawing.Color.Maroon;
            this.button_tum_kayitlar.Location = new System.Drawing.Point(524, 258);
            this.button_tum_kayitlar.Name = "button_tum_kayitlar";
            this.button_tum_kayitlar.Size = new System.Drawing.Size(417, 62);
            this.button_tum_kayitlar.TabIndex = 2;
            this.button_tum_kayitlar.Text = "TÜM KAYITLARI LİSTELE";
            this.button_tum_kayitlar.UseVisualStyleBackColor = true;
            this.button_tum_kayitlar.Click += new System.EventHandler(this.button_tum_kayitlar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox2.Controls.Add(this.button_iadeEtme);
            this.groupBox2.Controls.Add(this.textBox_iade_kitapNumarasi);
            this.groupBox2.Controls.Add(this.textBox_iade_ogrenciNumarasi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(524, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 227);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İade Giriş Bilgileri";
            // 
            // button_iadeEtme
            // 
            this.button_iadeEtme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_iadeEtme.ForeColor = System.Drawing.Color.Maroon;
            this.button_iadeEtme.Location = new System.Drawing.Point(10, 120);
            this.button_iadeEtme.Name = "button_iadeEtme";
            this.button_iadeEtme.Size = new System.Drawing.Size(384, 44);
            this.button_iadeEtme.TabIndex = 12;
            this.button_iadeEtme.Text = "İADE ET";
            this.button_iadeEtme.UseVisualStyleBackColor = true;
            this.button_iadeEtme.Click += new System.EventHandler(this.button_iadeEtme_Click);
            // 
            // textBox_iade_kitapNumarasi
            // 
            this.textBox_iade_kitapNumarasi.Location = new System.Drawing.Point(231, 76);
            this.textBox_iade_kitapNumarasi.Name = "textBox_iade_kitapNumarasi";
            this.textBox_iade_kitapNumarasi.Size = new System.Drawing.Size(163, 27);
            this.textBox_iade_kitapNumarasi.TabIndex = 4;
            // 
            // textBox_iade_ogrenciNumarasi
            // 
            this.textBox_iade_ogrenciNumarasi.Location = new System.Drawing.Point(231, 36);
            this.textBox_iade_ogrenciNumarasi.Name = "textBox_iade_ogrenciNumarasi";
            this.textBox_iade_ogrenciNumarasi.Size = new System.Drawing.Size(163, 27);
            this.textBox_iade_ogrenciNumarasi.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kitap Numarası";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Öğrenci Numarası";
            // 
            // button_anaSayfa
            // 
            this.button_anaSayfa.Location = new System.Drawing.Point(975, 12);
            this.button_anaSayfa.Name = "button_anaSayfa";
            this.button_anaSayfa.Size = new System.Drawing.Size(108, 88);
            this.button_anaSayfa.TabIndex = 4;
            this.button_anaSayfa.Text = "ANA SAYFA";
            this.button_anaSayfa.UseVisualStyleBackColor = true;
            this.button_anaSayfa.Click += new System.EventHandler(this.button_anaSayfa_Click);
            // 
            // EmanetVerme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1095, 590);
            this.Controls.Add(this.button_anaSayfa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_tum_kayitlar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmanetListele);
            this.Name = "EmanetVerme";
            this.Text = "EmanetVerme";
            this.Load += new System.EventHandler(this.EmanetVerme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmanetListele)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmanetListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_kitapNumarasi;
        private System.Windows.Forms.TextBox textBox_ogrenciNumarasi;
        private System.Windows.Forms.Button button_emanet_ver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_emanetalma;
        private System.Windows.Forms.TextBox textBox_tarih_emanetalma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_emanetVerme;
        private System.Windows.Forms.TextBox textBox_emanetverme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_tum_kayitlar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_iadeEtme;
        private System.Windows.Forms.TextBox textBox_iade_kitapNumarasi;
        private System.Windows.Forms.TextBox textBox_iade_ogrenciNumarasi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_anaSayfa;
    }
}