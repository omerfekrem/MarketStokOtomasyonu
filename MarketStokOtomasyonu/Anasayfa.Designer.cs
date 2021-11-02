namespace MarketStokOtomasyonu
{
    partial class Anasayfa
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
            this.button1 = new System.Windows.Forms.Button();
            this.tedarikciBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 102);
            this.button1.TabIndex = 0;
            this.button1.Text = "Satış Ekranı";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tedarikciBtn
            // 
            this.tedarikciBtn.Location = new System.Drawing.Point(168, 12);
            this.tedarikciBtn.Name = "tedarikciBtn";
            this.tedarikciBtn.Size = new System.Drawing.Size(121, 102);
            this.tedarikciBtn.TabIndex = 1;
            this.tedarikciBtn.Text = "Tedarikçiler";
            this.tedarikciBtn.UseVisualStyleBackColor = true;
            this.tedarikciBtn.Click += new System.EventHandler(this.tedarikciBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 102);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ciro Raporlama";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 102);
            this.button4.TabIndex = 3;
            this.button4.Text = "Stok Yönetimi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 262);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tedarikciBtn);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tedarikciBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

