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
    public partial class MusteriKayitEkrani : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=MandiraDB;Integrated Security=True");

        public MusteriKayitEkrani()
        {
            InitializeComponent();
        }

        private void buttonKaydol_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = baglan;
                command.CommandText = "INSERT INTO dbo.Musteriler(ad,soyad,email,telefon,adres,sifre) VALUES ('"
                    + textBoxAd.Text + "','" + textBoxSoyad.Text + "','" + textBoxEMail.Text + "','" + textBoxTelefon.Text + "','" + textBoxAdres.Text + "','" + textBoxSifre.Text + "')";
                command.ExecuteNonQuery();
                command.Dispose();
                baglan.Close();
                TextBoxTemizleme();
                MessageBox.Show("KAYIT EKLENDİ");
            }
            GirisEkranı ge = new GirisEkranı();
            ge.Show();
            this.Close();
        }

        void TextBoxTemizleme()
        {
            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            textBoxEMail.Text = "";
            textBoxTelefon.Text = "";
            textBoxAdres.Text = "";
            textBoxSifre.Text = "";
        }
    }
}
