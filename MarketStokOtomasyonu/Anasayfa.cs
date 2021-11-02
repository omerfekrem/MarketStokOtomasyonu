using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStokOtomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StokYonetim stokYonetimi = new StokYonetim();

            if (Application.OpenForms["Form2"] == null)
            {
                stokYonetimi.Show();
            }
        }

        private void tedarikciBtn_Click(object sender, EventArgs e)
        {
            Tedarikçiler tedarikciler = new Tedarikçiler();

            if (Application.OpenForms["Form3"] == null)
            {
                tedarikciler.Show();
            }
        }
    }
}
