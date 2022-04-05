
namespace KutuphaneOtomasyonu
{
    partial class grafikGosterimi
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
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.button_Ana_sayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(31, 120);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(984, 389);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // button_Ana_sayfa
            // 
            this.button_Ana_sayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Ana_sayfa.Location = new System.Drawing.Point(22, 31);
            this.button_Ana_sayfa.Name = "button_Ana_sayfa";
            this.button_Ana_sayfa.Size = new System.Drawing.Size(159, 46);
            this.button_Ana_sayfa.TabIndex = 7;
            this.button_Ana_sayfa.Text = "ANA SAYFA";
            this.button_Ana_sayfa.UseVisualStyleBackColor = true;
            this.button_Ana_sayfa.Click += new System.EventHandler(this.button_Ana_sayfa_Click);
            // 
            // grafikGosterimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 555);
            this.Controls.Add(this.button_Ana_sayfa);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "grafikGosterimi";
            this.Text = "grafikGosterimi";
            this.Load += new System.EventHandler(this.grafikGosterimi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button button_Ana_sayfa;
    }
}