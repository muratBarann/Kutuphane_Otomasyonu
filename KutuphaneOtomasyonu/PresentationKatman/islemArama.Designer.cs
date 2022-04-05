
namespace KutuphaneOtomasyonu
{
    partial class islemArama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ogrenciAra = new System.Windows.Forms.Button();
            this.ogrenciListele = new System.Windows.Forms.DataGridView();
            this.textBox_ogrenciNumarasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_kitapAra = new System.Windows.Forms.Button();
            this.kitapListele = new System.Windows.Forms.DataGridView();
            this.textBox_kitapNumarasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_anasayfa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListele)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapListele)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Controls.Add(this.button_ogrenciAra);
            this.groupBox1.Controls.Add(this.ogrenciListele);
            this.groupBox1.Controls.Add(this.textBox_ogrenciNumarasi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1382, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Numası İle Arama";
            // 
            // button_ogrenciAra
            // 
            this.button_ogrenciAra.Location = new System.Drawing.Point(26, 117);
            this.button_ogrenciAra.Name = "button_ogrenciAra";
            this.button_ogrenciAra.Size = new System.Drawing.Size(294, 41);
            this.button_ogrenciAra.TabIndex = 3;
            this.button_ogrenciAra.Text = "ARA";
            this.button_ogrenciAra.UseVisualStyleBackColor = true;
            this.button_ogrenciAra.Click += new System.EventHandler(this.button_ogrenciAra_Click);
            // 
            // ogrenciListele
            // 
            this.ogrenciListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciListele.Location = new System.Drawing.Point(358, 26);
            this.ogrenciListele.Name = "ogrenciListele";
            this.ogrenciListele.RowHeadersWidth = 51;
            this.ogrenciListele.RowTemplate.Height = 24;
            this.ogrenciListele.Size = new System.Drawing.Size(1012, 201);
            this.ogrenciListele.TabIndex = 2;
            // 
            // textBox_ogrenciNumarasi
            // 
            this.textBox_ogrenciNumarasi.Location = new System.Drawing.Point(183, 49);
            this.textBox_ogrenciNumarasi.Name = "textBox_ogrenciNumarasi";
            this.textBox_ogrenciNumarasi.Size = new System.Drawing.Size(159, 27);
            this.textBox_ogrenciNumarasi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numarası";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox2.Controls.Add(this.button_kitapAra);
            this.groupBox2.Controls.Add(this.kitapListele);
            this.groupBox2.Controls.Add(this.textBox_kitapNumarasi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(12, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1382, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Numarası İle Arama";
            // 
            // button_kitapAra
            // 
            this.button_kitapAra.Location = new System.Drawing.Point(26, 130);
            this.button_kitapAra.Name = "button_kitapAra";
            this.button_kitapAra.Size = new System.Drawing.Size(294, 41);
            this.button_kitapAra.TabIndex = 4;
            this.button_kitapAra.Text = "ARA";
            this.button_kitapAra.UseVisualStyleBackColor = true;
            this.button_kitapAra.Click += new System.EventHandler(this.button_kitapAra_Click);
            // 
            // kitapListele
            // 
            this.kitapListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapListele.Location = new System.Drawing.Point(358, 26);
            this.kitapListele.Name = "kitapListele";
            this.kitapListele.RowHeadersWidth = 51;
            this.kitapListele.RowTemplate.Height = 24;
            this.kitapListele.Size = new System.Drawing.Size(1012, 206);
            this.kitapListele.TabIndex = 3;
            // 
            // textBox_kitapNumarasi
            // 
            this.textBox_kitapNumarasi.Location = new System.Drawing.Point(183, 61);
            this.textBox_kitapNumarasi.Name = "textBox_kitapNumarasi";
            this.textBox_kitapNumarasi.Size = new System.Drawing.Size(159, 27);
            this.textBox_kitapNumarasi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Numarası";
            // 
            // button_anasayfa
            // 
            this.button_anasayfa.Location = new System.Drawing.Point(660, 262);
            this.button_anasayfa.Name = "button_anasayfa";
            this.button_anasayfa.Size = new System.Drawing.Size(276, 55);
            this.button_anasayfa.TabIndex = 2;
            this.button_anasayfa.Text = "ANA SAYFA";
            this.button_anasayfa.UseVisualStyleBackColor = true;
            this.button_anasayfa.Click += new System.EventHandler(this.button_anasayfa_Click);
            // 
            // islemArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 589);
            this.Controls.Add(this.button_anasayfa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "islemArama";
            this.Text = "islemArama";
            this.Load += new System.EventHandler(this.islemArama_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListele)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView ogrenciListele;
        private System.Windows.Forms.TextBox textBox_ogrenciNumarasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView kitapListele;
        private System.Windows.Forms.TextBox textBox_kitapNumarasi;
        private System.Windows.Forms.Button button_ogrenciAra;
        private System.Windows.Forms.Button button_kitapAra;
        private System.Windows.Forms.Button button_anasayfa;
    }
}