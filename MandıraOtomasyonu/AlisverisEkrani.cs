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
    public partial class AlisverisEkrani : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=MandiraDB;Integrated Security=True");
        SepetEkrani se = new SepetEkrani();
        int toplam;
        public AlisverisEkrani()
        {
            InitializeComponent();
            UrunListeleme();
            dataGridViewUrunler.AllowUserToAddRows = false;
        }

        private void buttonSepeteGit_Click(object sender, EventArgs e)
        {
            se.Show();
            this.Close();
            for(int i = 0; i < listBoxUrunlerim.Items.Count; i++)
            {
                se.listBoxSepetim.Items.Add(listBoxUrunlerim.Items[i].ToString());
            }
        }
        void UrunListeleme()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = baglan;
                command.CommandText = "Select urunadi,fiyat,stok from Urunler";
                SqlDataAdapter dAdapter = new SqlDataAdapter(command);
                DataSet dSet = new DataSet();
                dAdapter.Fill(dSet, "Urunler");
                dataGridViewUrunler.DataSource = dSet.Tables["Urunler"];
                baglan.Close();
            }
        }

        private void dataGridViewUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toplam = Int32.Parse(labelToplamTutar.Text);

            string urun=  dataGridViewUrunler.CurrentRow.Cells[0].Value.ToString();
            listBoxUrunlerim.Items.Add(urun);
            string fiyat = dataGridViewUrunler.CurrentRow.Cells[1].Value.ToString();
            int urunfiyat = Int32.Parse(fiyat);

            toplam =toplam + urunfiyat;
            labelToplamTutar.Text = toplam.ToString();
            se.labelOdenecekTutar.Text= toplam.ToString();

            string sorgu = "SELECT stok From Urunler WHERE urunadi = '" + urun + "'";
            int urunStok;
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            baglan.Open();
            urunStok = (int)komut.ExecuteScalar();
            baglan.Close();

            urunStok = urunStok - 1;
            baglan.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = baglan;
            command.CommandText = " update Urunler set stok='" + urunStok + "' where urunadi='" + urun + "'";
            command.ExecuteNonQuery();
            command.Dispose();
            baglan.Close();

            UrunListeleme();
        }

        private void buttonCikisYap_Click(object sender, EventArgs e)
        {
            GirisEkranı ge = new GirisEkranı();
            ge.Show();
            this.Close();
        }
    }
}
