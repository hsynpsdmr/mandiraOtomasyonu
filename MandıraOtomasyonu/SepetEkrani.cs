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
    public partial class SepetEkrani : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=MandiraDB;Integrated Security=True");
        int genelToplam;

        public SepetEkrani()
        {
            InitializeComponent();
        }

        private void buttonSecilenUrunuSil_Click(object sender, EventArgs e)
        {
            AlisverisEkrani ae = new AlisverisEkrani();

            string SecilenUrun = listBoxSepetim.SelectedItem.ToString();
            
                string fiyatSorgu = "SELECT fiyat From Urunler WHERE urunadi = '" + SecilenUrun + "'";
                int urunUcret;
                SqlCommand fcommand = new SqlCommand(fiyatSorgu, baglan);
                baglan.Open();
                urunUcret = (int)fcommand.ExecuteScalar();
                baglan.Close();

            string odenecekUcret=labelOdenecekTutar.Text.ToString();
            int sepetUcret = Int32.Parse(odenecekUcret);
            genelToplam = sepetUcret-urunUcret;
            labelOdenecekTutar.Text = genelToplam.ToString();


            string stokSorgu = "SELECT stok From Urunler WHERE urunadi = '" + SecilenUrun + "'";
            int urunStok;
            SqlCommand scommand = new SqlCommand(stokSorgu, baglan);
            baglan.Open();
            urunStok = (int)scommand.ExecuteScalar();
            baglan.Close();

            int sonStok = urunStok + 1;

            baglan.Open();
            SqlCommand ucommand = new SqlCommand();
            ucommand.Connection = baglan;
            ucommand.CommandText = " update Urunler set stok='" + sonStok + "' where urunadi='" + SecilenUrun + "'";
            ucommand.ExecuteNonQuery();
            ucommand.Dispose();
            baglan.Close();

            listBoxSepetim.Items.Remove(listBoxSepetim.SelectedItem.ToString());
        }

        private void buttonAlisveriseDevamEt_Click(object sender, EventArgs e)
        {
            AlisverisEkrani ae = new AlisverisEkrani();

            for (int i = 0; i < listBoxSepetim.Items.Count; i++)
            {
                ae.listBoxUrunlerim.Items.Add(listBoxSepetim.Items[i].ToString());
            }
            ae.labelToplamTutar.Text = genelToplam.ToString();

            ae.Show();
            this.Close();
        }

        private void buttonSatinAl_Click(object sender, EventArgs e)
        {
            SatinAlEkrani sae = new SatinAlEkrani();
            GirisEkranı ge = new GirisEkranı();
            AlisverisEkrani ae = new AlisverisEkrani();

            string topUcret = labelOdenecekTutar.Text.ToString();
            int toplamUcret = Int32.Parse(topUcret);

            string sorgu = "SELECT suankikullaniciid From SuankiKullanici WHERE id=1";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            baglan.Open();
            int suankikullanici = (int)komut.ExecuteScalar();
            baglan.Close();

            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = baglan;
                command.CommandText = "INSERT INTO Siparisler ( musteriid , toplamucret ) VALUES ( " + suankikullanici + " ,  " + toplamUcret + "  ) ";
                command.ExecuteNonQuery();
                command.Dispose();
                baglan.Close();
            }
            sae.Show();
            this.Close();
        }
    }
}
