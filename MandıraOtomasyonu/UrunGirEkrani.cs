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
    public partial class UrunGirEkrani : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=MandiraDB;Integrated Security=True");
        public UrunGirEkrani()
        {
            InitializeComponent();
        }

        private void buttonYeniUrunEkle_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = baglan;
                command.CommandText = "INSERT INTO Urunler(urunadi,fiyat,stok) VALUES ('"+ textBoxUrunAdi.Text + "','" + textBoxUrunFiyati.Text + "','" + textBoxUrunAdeti.Text + "')";
                command.ExecuteNonQuery();
                command.Dispose();
                baglan.Close();
                TexrBoxTemizleme();
                MessageBox.Show("ÜRÜN EKLENDİ");
            }
        }

        void TexrBoxTemizleme()
        {
            textBoxUrunAdi.Text = "";
            textBoxUrunFiyati.Text = "";
            textBoxUrunAdeti.Text = "";
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            KullaniciAnasayfaEkrani kae = new KullaniciAnasayfaEkrani();
            kae.Show();
            this.Close();
        }
    }
}
