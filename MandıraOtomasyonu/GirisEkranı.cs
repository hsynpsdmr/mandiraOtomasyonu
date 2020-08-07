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
    public partial class GirisEkranı : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=MandiraDB;Integrated Security=True");
        MusteriKayitEkrani mke = new MusteriKayitEkrani();
        AlisverisEkrani f4 = new AlisverisEkrani();
        public int musteriId;
        public GirisEkranı()
        {
            InitializeComponent();
        }



        private void MbuttonGirisYap_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * from Musteriler Where email='" + MtextBoxEmail.Text.Trim() + "' and sifre = '" + MtextBoxSifre.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglan);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                f4.Show();
                this.Hide();
                SuankiKullaniciEkle();
            }
            else
            {
                MessageBox.Show("E-Mailinizi veya Şifrenizi Hatalı Girdiniz!!!");
            }
        }

        public void SuankiKullaniciEkle()
        {
            string sorgu = "SELECT id From Musteriler WHERE email = '" + MtextBoxEmail.Text + "'";


            SqlCommand komut = new SqlCommand(sorgu, baglan);
            baglan.Open();
            musteriId = (int)komut.ExecuteScalar();
            baglan.Close();

            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = baglan;
                command.CommandText = "update SuankiKullanici set suankikullaniciid  = " + musteriId + " where id=1 ";
                command.ExecuteNonQuery();
                command.Dispose();
                baglan.Close();
            }


        }

        private void MbuttonKayıtOl_Click(object sender, EventArgs e)
        {
            mke.Show();
            this.Hide();
        }

        private void KbuttonGirisYap_Click(object sender, EventArgs e)
        {
            if(KtextBoxEmail.Text=="admin"&& KtextBoxSifre.Text == "12345")
            {
                KullaniciAnasayfaEkrani kae = new KullaniciAnasayfaEkrani();
                kae.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KULLANICI ADINIZ VEYA ŞİFRENİZ YANLIŞ");
            }
        }
    }
}
