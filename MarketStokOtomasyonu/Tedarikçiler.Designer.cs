namespace MarketStokOtomasyonu
{
    partial class Tedarikçiler
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.araText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.temizeBtn = new System.Windows.Forms.Button();
            this.yenileBtn = new System.Windows.Forms.Button();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tedarikciTel = new System.Windows.Forms.TextBox();
            this.tedarikciAdres = new System.Windows.Forms.TextBox();
            this.tedarikciAdi = new System.Windows.Forms.TextBox();
            this.tedarikciDg = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciDg)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 479);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.araText);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.guncelleBtn);
            this.tabPage1.Controls.Add(this.temizeBtn);
            this.tabPage1.Controls.Add(this.yenileBtn);
            this.tabPage1.Controls.Add(this.kaydetBtn);
            this.tabPage1.Controls.Add(this.silBtn);
            this.tabPage1.Controls.Add(this.ekleBtn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tedarikciTel);
            this.tabPage1.Controls.Add(this.tedarikciAdres);
            this.tabPage1.Controls.Add(this.tedarikciAdi);
            this.tabPage1.Controls.Add(this.tedarikciDg);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yeni Tedarikçi Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // araText
            // 
            this.araText.Location = new System.Drawing.Point(56, 6);
            this.araText.Name = "araText";
            this.araText.Size = new System.Drawing.Size(241, 20);
            this.araText.TabIndex = 16;
            this.araText.TextChanged += new System.EventHandler(this.araText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Arama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(171, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Toplam Tedarikçi Sayısı :";
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(461, 3);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(75, 26);
            this.guncelleBtn.TabIndex = 12;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // temizeBtn
            // 
            this.temizeBtn.Location = new System.Drawing.Point(542, 3);
            this.temizeBtn.Name = "temizeBtn";
            this.temizeBtn.Size = new System.Drawing.Size(62, 26);
            this.temizeBtn.TabIndex = 11;
            this.temizeBtn.Text = "Temizle";
            this.temizeBtn.UseVisualStyleBackColor = true;
            this.temizeBtn.Click += new System.EventHandler(this.temizeBtn_Click);
            // 
            // yenileBtn
            // 
            this.yenileBtn.Image = global::MarketStokOtomasyonu.Properties.Resources.iconfinder_refresh_326679;
            this.yenileBtn.Location = new System.Drawing.Point(610, 3);
            this.yenileBtn.Name = "yenileBtn";
            this.yenileBtn.Size = new System.Drawing.Size(28, 26);
            this.yenileBtn.TabIndex = 10;
            this.yenileBtn.UseVisualStyleBackColor = true;
            this.yenileBtn.Click += new System.EventHandler(this.yenileBtn_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Location = new System.Drawing.Point(575, 219);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(60, 23);
            this.kaydetBtn.TabIndex = 9;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(503, 219);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(66, 23);
            this.silBtn.TabIndex = 8;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(446, 219);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(51, 23);
            this.ekleBtn.TabIndex = 7;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tedarikçi Telefon Numaras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tedarikçi Adresi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tedarikçi Adı";
            // 
            // tedarikciTel
            // 
            this.tedarikciTel.Location = new System.Drawing.Point(446, 169);
            this.tedarikciTel.Name = "tedarikciTel";
            this.tedarikciTel.Size = new System.Drawing.Size(189, 20);
            this.tedarikciTel.TabIndex = 3;
            this.tedarikciTel.TextChanged += new System.EventHandler(this.tedarikciTel_TextChanged);
            this.tedarikciTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tedarikciTel_KeyPress);
            // 
            // tedarikciAdres
            // 
            this.tedarikciAdres.Location = new System.Drawing.Point(446, 115);
            this.tedarikciAdres.Name = "tedarikciAdres";
            this.tedarikciAdres.Size = new System.Drawing.Size(190, 20);
            this.tedarikciAdres.TabIndex = 2;
            // 
            // tedarikciAdi
            // 
            this.tedarikciAdi.Location = new System.Drawing.Point(446, 62);
            this.tedarikciAdi.Name = "tedarikciAdi";
            this.tedarikciAdi.Size = new System.Drawing.Size(190, 20);
            this.tedarikciAdi.TabIndex = 1;
            // 
            // tedarikciDg
            // 
            this.tedarikciDg.BackgroundColor = System.Drawing.Color.Azure;
            this.tedarikciDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedarikciDg.Location = new System.Drawing.Point(8, 32);
            this.tedarikciDg.Name = "tedarikciDg";
            this.tedarikciDg.ReadOnly = true;
            this.tedarikciDg.Size = new System.Drawing.Size(430, 395);
            this.tedarikciDg.TabIndex = 0;
            this.tedarikciDg.SelectionChanged += new System.EventHandler(this.tedarikciDg_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(652, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürünlere Tedarikçi Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 406);
            this.dataGridView1.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Arama :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form3";
            this.Text = "Tedarkçiler";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciDg)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tedarikciTel;
        private System.Windows.Forms.TextBox tedarikciAdres;
        private System.Windows.Forms.TextBox tedarikciAdi;
        private System.Windows.Forms.DataGridView tedarikciDg;
        private System.Windows.Forms.Button temizeBtn;
        private System.Windows.Forms.Button yenileBtn;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox araText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}