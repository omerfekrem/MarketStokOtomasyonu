using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketStokOtomasyonu.MarketStokWebServis;

namespace MarketStokOtomasyonu
{
    public partial class Tedarikçiler : Form
    {
        public WebService1SoapClient client = new WebService1SoapClient();
        public Tedarikçiler()
        {
            InitializeComponent();
            tedarikciListele();
            urunSayisiBul();
            pasifYap();
        }

        public void tedarikciListele()
        {
            DataSet ds = new DataSet(); // Dataset tanımla
            ds = client.getTedarikciler(); // Web servisteki getUrunler metodunu çağırarak gelen ürünleri dataset'e al
            tedarikciDg.DataSource = ds.Tables[0]; // Dataset'e gelen verileri datagrid'e yazdır.
            tedarikciDg.RowHeadersVisible = false;  // DataGrid başlangıçtaki boşluğu silme
            this.tedarikciDg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // DataGrid genişliğine göre sütun genişliklerini ayarlama.
            tedarikciDg.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // DataGrid tıklandığında full row seçili hale getir.
            tedarikciDg.AllowUserToAddRows = false; //Datagrid'deki en alttaki satırı gizle.
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            tedarikciListele();
            urunSayisiBul();
        }

        public void urunSayisiBul()
        {
                int kayitsayisi;
                kayitsayisi = tedarikciDg.RowCount;

                label4.Text = kayitsayisi.ToString();
        }

        public void pasifYap()
        {
            tedarikciAdi.Enabled = false;
            tedarikciTel.Enabled = false;
            tedarikciAdres.Enabled = false;
            ekleBtn.Enabled = false;
            label7.Visible = false;
            kaydetBtn.Enabled = false;
        }

        public void textboxKontrol()
        {
            if (tedarikciDg.CurrentRow.Cells[0].Value.ToString() == null)
            {
                tedarikciAdi.Text = "";
            }
            else
            {
                tedarikciAdi.Text = tedarikciDg.CurrentRow.Cells[0].Value.ToString();
            }

            if (tedarikciDg.CurrentRow.Cells[1].Value.ToString() == null)
            {
                tedarikciAdres.Text = "";
            }
            else
            {
                tedarikciAdres.Text = tedarikciDg.CurrentRow.Cells[1].Value.ToString();
            }

            if (tedarikciDg.CurrentRow.Cells[2].Value.ToString() == null)
            {
                tedarikciTel.Text = "";
            }
            else
            {
                tedarikciTel.Text = tedarikciDg.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void tedarikciDg_SelectionChanged(object sender, EventArgs e)
        {
            textboxKontrol();
            pasifYap();
            silBtn.Enabled = true;
        }

        public void aramaYap()
        {
            DataSet ds = new DataSet();
            ds = client.getTedarikciArama(araText.Text,araText.Text);
            tedarikciDg.DataSource = ds.Tables[0];
            urunSayisiBul();
        }

        private void araText_TextChanged(object sender, EventArgs e)
        {
            aramaYap();
        }

        private void tedarikciTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            tedarikciTel.Enabled = true;
            tedarikciAdi.Enabled = true;
            tedarikciAdres.Enabled = true;
            silBtn.Enabled = false;
            label7.Visible = true;
            kaydetBtn.Enabled = true;
            ekleBtn.Enabled = false;
        }

        private void temizeBtn_Click(object sender, EventArgs e)
        {
            tedarikciTel.Enabled = true;
            tedarikciAdi.Enabled = true;
            tedarikciAdres.Enabled = true;
            tedarikciAdi.Text = "";
            tedarikciAdres.Text = "";
            label7.Visible = true;
            tedarikciTel.Text = "";
            silBtn.Enabled = false;
            kaydetBtn.Enabled = false;
            ekleBtn.Enabled = true;
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            tedarikciGuncelle();
        }
        public void tedarikciGuncelle()
        {
            if (String.IsNullOrEmpty(tedarikciAdi.Text) || String.IsNullOrEmpty(tedarikciAdres.Text) || String.IsNullOrEmpty(tedarikciTel.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız !", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                client.postTedarikciGuncelle(tedarikciAdi.Text,tedarikciAdres.Text,tedarikciTel.Text);
                tedarikciListele();
                MessageBox.Show("Ürün Başarıyla Güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            tedarikciEkle();
            tedarikciListele();
        }

        public void tedarikciEkle()
        {
            if (String.IsNullOrEmpty(tedarikciAdi.Text) || String.IsNullOrEmpty(tedarikciAdres.Text) || String.IsNullOrEmpty(tedarikciTel.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız !", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                client.postTedarikci(tedarikciAdi.Text, tedarikciAdres.Text, tedarikciTel.Text);
                tedarikciListele();
                MessageBox.Show("Ürün Başarıyla Eklendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void tedarikciTel_TextChanged(object sender, EventArgs e)
        {
            int sayac = 11;
            tedarikciTel.MaxLength = 11;
            string text = tedarikciTel.Text;

            foreach (char txt in text)
            {
                sayac--;

            }
            label7.Text = sayac.ToString() + " Karakter Kaldı.";
            if (sayac == 0)
            {
                label7.ForeColor = Color.Red;
                label7.Text = sayac.ToString() + " Karakter Sınırına Ulaştınız.";
            }
            else if (sayac <= 3)
            {
                label7.ForeColor = Color.Blue;
            }
            else if (sayac >= 4)
            {
                label7.ForeColor = Color.Black;
            }
        }
    }
}
