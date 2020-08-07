using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MandıraOtomasyonu
{
    public partial class KullaniciAnasayfaEkrani : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=MandiraDB;Integrated Security=True");
        public KullaniciAnasayfaEkrani()
        {
            InitializeComponent();
            KasaHesapla();
        }

        private void buttonCikisYap_Click(object sender, EventArgs e)
        {
            GirisEkranı ge = new GirisEkranı();
            ge.Show();
            this.Close();
        }

        private void buttonUrunGir_Click(object sender, EventArgs e)
        {
            UrunGirEkrani uge = new UrunGirEkrani();
            uge.Show();
            this.Close();
        }

        private void buttonStoklar_Click(object sender, EventArgs e)
        {
            StoklarEkrani se = new StoklarEkrani();
            se.Show();
            this.Close();
        }

        private void buttonMusteriler_Click(object sender, EventArgs e)
        {
            MusterilerEkrani me = new MusterilerEkrani();
            me.Show();
            this.Close();
        }

        private void buttonSiparisler_Click(object sender, EventArgs e)
        {
            SiparislerEkrani se = new SiparislerEkrani();
            se.Show();
            this.Close();
        }

        public void KasaHesapla()
        {
            string fiyatSorgu = "SELECT Sum(toplamucret) from Siparisler";
            int kasaUcret;
            SqlCommand fcommand = new SqlCommand(fiyatSorgu, baglan);
            baglan.Open();
            kasaUcret = (int)fcommand.ExecuteScalar();
            baglan.Close();

            labelKasa.Text = kasaUcret.ToString();
        }
    }
}
