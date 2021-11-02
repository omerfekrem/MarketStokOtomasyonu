using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketStokOtomasyonu.MarketStokWebServis;

namespace MarketStokOtomasyonu
{
   
    public partial class StokYonetim : Form
    {
        public WebService1SoapClient client = new WebService1SoapClient();
        int kategoriID;
        public StokYonetim()
        {
            InitializeComponent();
            pasifYap();
            kategoriComboboxDoldur();
            urunleriListele();
            urunSayisiBul();
            stokUyari();
            timer1.Interval = 1;
            timer1.Start();
        }

        public void urunSayisiBul()
        {

            int kayitsayisi;
            kayitsayisi = urunlerDg.RowCount;

            label3.Text = kayitsayisi.ToString();
        }
        public void kategoriComboboxDoldur()
        {
            DataSet ds = new DataSet();
            ds = client.getKategori();
            urunKategori.DataSource = ds.Tables[0]; // Combobox DataSource belirledikten sonra valueMember ayarlayıp verileri çağırıyoruz.
            urunKategori.ValueMember = "kategori_adi";
        }
        public void stokKontrol()
        {
            DataSet ds = new DataSet();
            ds = client.getStokBiten();
            listBox1.Items.Clear();
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {

                    if (!listBox1.Items.Contains(dr.Field<string>(0)))
                    {
                        listBox1.Items.Add(dr.Field<string>(0));
                    }
                    else
                    {
                    }
                }
            }
            DataSet dsAzalan = new DataSet();
            dsAzalan = client.getStokAzalan();
            listBox2.Items.Clear();
            foreach (DataTable table in dsAzalan.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {

                    if (!listBox2.Items.Contains(dr.Field<string>(0)))
                    {
                        listBox2.Items.Add(dr.Field<string>(0));
                    }
                    else
                    {
                    }
                }
            }
        }
        public void urunleriListele()
        {
            DataSet ds = new DataSet(); // Dataset tanımla
            ds = client.getUrunler(); // Web servisteki getUrunler metodunu çağırarak gelen ürünleri dataset'e al
            urunlerDg.DataSource = ds.Tables[0]; // Dataset'e gelen verileri datagrid'e yazdır.
            urunlerDg.RowHeadersVisible = false;  // DataGrid başlangıçtaki boşluğu silme
            this.urunlerDg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // DataGrid genişliğine göre sütun genişliklerini ayarlama.
            urunlerDg.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // DataGrid tıklandığında full row seçili hale getir.
            urunlerDg.AllowUserToAddRows = false; //Datagrid'deki en alttaki satırı gizle.
            stokKontrol();
        }

        private void urunlerDg_SelectionChanged(object sender, EventArgs e)
        {
            textboxKontrol();
            pasifYap();
            urunSil.Enabled = true;
        }

        public void textboxKontrol()
        {
            if (urunlerDg.CurrentRow.Cells[0].Value.ToString() == null)
            {
                urunBarkod.Text = "";
            }
            else
            {
                urunBarkod.Text = urunlerDg.CurrentRow.Cells[0].Value.ToString();
            }

            if (urunlerDg.CurrentRow.Cells[1].Value.ToString() == null)
            {
                urunAdi.Text = "";
            }
            else
            {
                urunAdi.Text = urunlerDg.CurrentRow.Cells[1].Value.ToString();
            }

            if (urunlerDg.CurrentRow.Cells[2].Value.ToString() == null)
            {
                urunKategori.Text = "";
            }
            else
            {
                urunKategori.Text = urunlerDg.CurrentRow.Cells[2].Value.ToString();
            }

            if (urunlerDg.CurrentRow.Cells[3].Value.ToString() == null)
            {
                urunMiktar.Text = "";
            }
            else
            {
                urunMiktar.Text = urunlerDg.CurrentRow.Cells[3].Value.ToString();
            }

            if (urunlerDg.CurrentRow.Cells[4].Value.ToString() == null)
            {
                urunFiyat.Text = "";
            }
            else
            {
                urunFiyat.Text = urunlerDg.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            urunleriListele();
            urunSayisiBul();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(urunBarkod.Text);
        }

        public void pasifYap()
        {
            urunBarkod.Enabled = false;
            urunAdi.Enabled = false;
            urunKategori.Enabled = false;
            urunMiktar.Enabled = false;
            urunFiyat.Enabled = false;
            kaydetBtn.Enabled = false;
            urunEkleBtn.Enabled = false;
            sayi.Text = "";
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            urunEkle();
        }

        private void urunKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            kategoriID = Convert.ToInt32(urunKategori.SelectedIndex + 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            aramaYap();
        }

        private void urunSil_Click(object sender, EventArgs e)
        {

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Ürün Silinsin mi?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                client.postUrunSil(urunBarkod.Text);
                urunleriListele();
                urunSayisiBul();
                stokKontrol();
                MessageBox.Show("Ürün Başarıyla Silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
            }
            
           
        }

        private void urunBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            urunAdi.Enabled = true;
            urunKategori.Enabled = true;
            urunMiktar.Enabled = true;
            urunFiyat.Enabled = true;
            kaydetBtn.Enabled = true;
            urunEkleBtn.Enabled = false;
            urunSil.Enabled = false;
            sayi.Text = "Barkod güncellenemez barkodu güncellemek için\nürünü silip tekrar ekleyiniz.";
            sayi.ForeColor = Color.Blue;
        }

        private void urunMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void urunFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.';

        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            urunGuncelle();
        }
        public void temizle()
        {
            int sayac = 7;
            sayi.Text = sayac.ToString() + " Karakter Kaldı.";
            sayi.ForeColor = Color.Black;
            urunBarkod.Text = "";
            urunAdi.Text = "";
            urunKategori.Text = "";
            urunMiktar.Text = "";
            urunFiyat.Text = "";
            urunBarkod.MaxLength = 7;
            urunBarkod.Enabled = true;
            urunAdi.Enabled = true;
            urunKategori.Enabled = true;
            kaydetBtn.Enabled = false;
            urunMiktar.Enabled = true;
            urunFiyat.Enabled = true;
            urunSil.Enabled = false;
            urunEkleBtn.Enabled = true;
        }
        public void urunGuncelle()
        {
            string fiyat = urunFiyat.Text;
            if (String.IsNullOrEmpty(urunAdi.Text) || String.IsNullOrEmpty(urunKategori.Text) || String.IsNullOrEmpty(urunMiktar.Text) || String.IsNullOrEmpty(urunFiyat.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız !", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                client.postUrunGuncelle(urunBarkod.Text, kategoriID, urunAdi.Text, Convert.ToInt32(urunMiktar.Text), fiyat);
                urunleriListele();
                stokKontrol();
                stokRenklendirme();
                MessageBox.Show("Ürün Başarıyla Güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        public void aramaYap()
        {
            DataSet ds = new DataSet();
            ds = client.getArama(araText.Text, araText.Text, araText.Text);
            urunlerDg.DataSource = ds.Tables[0];
            urunSayisiBul();
        }

        public void urunEkle()
        {
            string fiyat = urunFiyat.Text; // fiyatı string gönderdik.
            if (String.IsNullOrEmpty(urunBarkod.Text) || String.IsNullOrEmpty(urunAdi.Text) || String.IsNullOrEmpty(urunKategori.Text) || String.IsNullOrEmpty(urunMiktar.Text) || String.IsNullOrEmpty(urunFiyat.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız !", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                client.postUrun(urunBarkod.Text, kategoriID, urunAdi.Text, Convert.ToInt32(urunMiktar.Text), fiyat);
                pasifYap();
                urunleriListele();
                urunSayisiBul();
                stokKontrol();
                stokRenklendirme();
                MessageBox.Show("Ürün Başarıyla Eklendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
       public void stokUyari()
        {
            if (listBox1.Items.Count > 0 && listBox2.Items.Count > 0)
            {
                MessageBox.Show("Stoklarınızda Hem Bitmiş Hem de Azalmakta Olan Ürünler Var Lütfen Kontrol Edin ve Stoklarınızı Güncelleyin.", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(listBox1.Items.Count > 0)
            {
                MessageBox.Show("Stoklarınızda Bitmiş Olan Ürünler Var Lütfen Kontrol Edin ve Stoklarınızı Güncelleyin.", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(listBox2.Items.Count>0)
            {
                MessageBox.Show("Stoklarınızda Azalmakta Olan Ürünler Var Lütfen Kontrol Edin ve Stoklarınızı Güncelleyin.", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void stokRenklendirme()
        {
            foreach (DataGridViewRow row in urunlerDg.Rows)
            {
                int hücre = Convert.ToInt32(row.Cells[3].Value.ToString());
                if (hücre == 0)
                {
                    row.Cells[3].Style.BackColor = Color.Red;
                }
                else if(hücre <=5)
                {
                    row.Cells[3].Style.BackColor = Color.Aqua;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stokRenklendirme();
        }

        private void urunBarkod_TextChanged(object sender, EventArgs e)
        {
            int sayac = 7;
            sayac = sayac-Convert.ToInt32(urunBarkod.TextLength);

            sayi.Text = sayac + " Karakter kaldı.";

            if(sayac<=4 && sayac>0)
            {
                sayi.ForeColor = Color.Blue;
            }
            else if(sayac ==0)
            {
                sayi.ForeColor = Color.Red;
                sayi.Text = sayac + " Karakter Sınırına Ulaştınız.";
            }
            else
            {
                sayi.ForeColor = Color.Black;
            }
        }
    }


}
