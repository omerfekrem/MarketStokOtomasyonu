namespace MarketStokOtomasyonu
{
    partial class StokYonetim
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stokYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciroRaporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.araText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.urunlerDg = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.urunBarkod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.urunAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.urunKategori = new System.Windows.Forms.ComboBox();
            this.kopyalaBtn = new System.Windows.Forms.Button();
            this.güncelleBtn = new System.Windows.Forms.Button();
            this.TemizleBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.urunMiktar = new System.Windows.Forms.TextBox();
            this.urunFiyat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.urunEkleBtn = new System.Windows.Forms.Button();
            this.urunSil = new System.Windows.Forms.Button();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.sayi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yenileBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokYönetimiToolStripMenuItem,
            this.satışEkranıToolStripMenuItem,
            this.ürünlerToolStripMenuItem,
            this.ciroRaporlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stokYönetimiToolStripMenuItem
            // 
            this.stokYönetimiToolStripMenuItem.Name = "stokYönetimiToolStripMenuItem";
            this.stokYönetimiToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.stokYönetimiToolStripMenuItem.Text = "Stok Yönetimi";
            // 
            // satışEkranıToolStripMenuItem
            // 
            this.satışEkranıToolStripMenuItem.Name = "satışEkranıToolStripMenuItem";
            this.satışEkranıToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.satışEkranıToolStripMenuItem.Text = "Satış Ekranı";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // ciroRaporlamaToolStripMenuItem
            // 
            this.ciroRaporlamaToolStripMenuItem.Name = "ciroRaporlamaToolStripMenuItem";
            this.ciroRaporlamaToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.ciroRaporlamaToolStripMenuItem.Text = "Ciro Raporlama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama :";
            // 
            // araText
            // 
            this.araText.Location = new System.Drawing.Point(61, 38);
            this.araText.Name = "araText";
            this.araText.Size = new System.Drawing.Size(241, 20);
            this.araText.TabIndex = 2;
            this.araText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(308, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Ürün Sayısı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(448, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // urunlerDg
            // 
            this.urunlerDg.BackgroundColor = System.Drawing.Color.Azure;
            this.urunlerDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerDg.Location = new System.Drawing.Point(15, 76);
            this.urunlerDg.Name = "urunlerDg";
            this.urunlerDg.ReadOnly = true;
            this.urunlerDg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.urunlerDg.Size = new System.Drawing.Size(449, 517);
            this.urunlerDg.TabIndex = 5;
            this.urunlerDg.SelectionChanged += new System.EventHandler(this.urunlerDg_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Barkod Numarası";
            // 
            // urunBarkod
            // 
            this.urunBarkod.Location = new System.Drawing.Point(470, 92);
            this.urunBarkod.Name = "urunBarkod";
            this.urunBarkod.Size = new System.Drawing.Size(172, 20);
            this.urunBarkod.TabIndex = 9;
            this.urunBarkod.TextChanged += new System.EventHandler(this.urunBarkod_TextChanged);
            this.urunBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urunBarkod_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kategorisi";
            // 
            // urunAdi
            // 
            this.urunAdi.Location = new System.Drawing.Point(470, 199);
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.Size = new System.Drawing.Size(274, 20);
            this.urunAdi.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "İsmi";
            // 
            // urunKategori
            // 
            this.urunKategori.FormattingEnabled = true;
            this.urunKategori.Location = new System.Drawing.Point(470, 159);
            this.urunKategori.Name = "urunKategori";
            this.urunKategori.Size = new System.Drawing.Size(274, 21);
            this.urunKategori.TabIndex = 14;
            this.urunKategori.SelectedIndexChanged += new System.EventHandler(this.urunKategori_SelectedIndexChanged);
            // 
            // kopyalaBtn
            // 
            this.kopyalaBtn.Location = new System.Drawing.Point(648, 90);
            this.kopyalaBtn.Name = "kopyalaBtn";
            this.kopyalaBtn.Size = new System.Drawing.Size(96, 23);
            this.kopyalaBtn.TabIndex = 15;
            this.kopyalaBtn.Text = "Kopyala";
            this.kopyalaBtn.UseVisualStyleBackColor = true;
            this.kopyalaBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // güncelleBtn
            // 
            this.güncelleBtn.Location = new System.Drawing.Point(587, 59);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(61, 25);
            this.güncelleBtn.TabIndex = 16;
            this.güncelleBtn.Text = "Güncelle";
            this.güncelleBtn.UseVisualStyleBackColor = true;
            this.güncelleBtn.Click += new System.EventHandler(this.güncelleBtn_Click);
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.Location = new System.Drawing.Point(654, 59);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(56, 25);
            this.TemizleBtn.TabIndex = 17;
            this.TemizleBtn.Text = "Temizle";
            this.TemizleBtn.UseVisualStyleBackColor = true;
            this.TemizleBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Miktar";
            // 
            // urunMiktar
            // 
            this.urunMiktar.Location = new System.Drawing.Point(470, 249);
            this.urunMiktar.Name = "urunMiktar";
            this.urunMiktar.Size = new System.Drawing.Size(100, 20);
            this.urunMiktar.TabIndex = 20;
            this.urunMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urunMiktar_KeyPress);
            // 
            // urunFiyat
            // 
            this.urunFiyat.Location = new System.Drawing.Point(576, 249);
            this.urunFiyat.Name = "urunFiyat";
            this.urunFiyat.Size = new System.Drawing.Size(100, 20);
            this.urunFiyat.TabIndex = 21;
            this.urunFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urunFiyat_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(574, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Birim Fiyat";
            // 
            // urunEkleBtn
            // 
            this.urunEkleBtn.Location = new System.Drawing.Point(470, 277);
            this.urunEkleBtn.Name = "urunEkleBtn";
            this.urunEkleBtn.Size = new System.Drawing.Size(75, 23);
            this.urunEkleBtn.TabIndex = 23;
            this.urunEkleBtn.Text = "Ürün Ekle";
            this.urunEkleBtn.UseVisualStyleBackColor = true;
            this.urunEkleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // urunSil
            // 
            this.urunSil.Location = new System.Drawing.Point(551, 277);
            this.urunSil.Name = "urunSil";
            this.urunSil.Size = new System.Drawing.Size(112, 23);
            this.urunSil.TabIndex = 24;
            this.urunSil.Text = "Sil";
            this.urunSil.UseVisualStyleBackColor = true;
            this.urunSil.Click += new System.EventHandler(this.urunSil_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Location = new System.Drawing.Point(669, 277);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetBtn.TabIndex = 25;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(470, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(266, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "STOKTA BİTMİŞ OLAN ÜRÜNLER";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(474, 327);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 121);
            this.listBox1.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(470, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(224, 18);
            this.label12.TabIndex = 28;
            this.label12.Text = "STOKTA AZALAN ÜRÜNLER";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(474, 472);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(270, 121);
            this.listBox2.TabIndex = 29;
            // 
            // sayi
            // 
            this.sayi.AutoSize = true;
            this.sayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi.Location = new System.Drawing.Point(467, 115);
            this.sayi.Name = "sayi";
            this.sayi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sayi.Size = new System.Drawing.Size(101, 13);
            this.sayi.TabIndex = 30;
            this.sayi.Text = "7 Karakter Kaldı.";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yenileBtn
            // 
            this.yenileBtn.Image = global::MarketStokOtomasyonu.Properties.Resources.iconfinder_refresh_326679;
            this.yenileBtn.Location = new System.Drawing.Point(716, 59);
            this.yenileBtn.Name = "yenileBtn";
            this.yenileBtn.Size = new System.Drawing.Size(28, 25);
            this.yenileBtn.TabIndex = 18;
            this.yenileBtn.UseVisualStyleBackColor = true;
            this.yenileBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 600);
            this.Controls.Add(this.sayi);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.urunSil);
            this.Controls.Add(this.urunEkleBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.urunFiyat);
            this.Controls.Add(this.urunMiktar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.yenileBtn);
            this.Controls.Add(this.TemizleBtn);
            this.Controls.Add(this.güncelleBtn);
            this.Controls.Add(this.kopyalaBtn);
            this.Controls.Add(this.urunKategori);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.urunAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.urunBarkod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.urunlerDg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.araText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Stok Yönetimi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem satışEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciroRaporlamaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox araText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView urunlerDg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox urunBarkod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox urunAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox urunKategori;
        private System.Windows.Forms.Button kopyalaBtn;
        private System.Windows.Forms.Button güncelleBtn;
        private System.Windows.Forms.Button TemizleBtn;
        private System.Windows.Forms.Button yenileBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox urunMiktar;
        private System.Windows.Forms.TextBox urunFiyat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button urunEkleBtn;
        private System.Windows.Forms.Button urunSil;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label sayi;
        private System.Windows.Forms.Timer timer1;
    }
}