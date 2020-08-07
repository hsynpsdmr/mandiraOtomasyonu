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
    public partial class SiparislerEkrani : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=MandiraDB;Integrated Security=True");
        public SiparislerEkrani()
        {
            InitializeComponent();
            SiparisListeleme();
            dataGridViewSiparisler.AllowUserToAddRows = false;
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            KullaniciAnasayfaEkrani kae = new KullaniciAnasayfaEkrani();
            kae.Show();
            this.Close();
        }

        void SiparisListeleme()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = baglan;
                command.CommandText = "Select * from Siparisler";
                SqlDataAdapter dAdapter = new SqlDataAdapter(command);
                DataSet dSet = new DataSet();
                dAdapter.Fill(dSet, "Siparisler");
                dataGridViewSiparisler.DataSource = dSet.Tables["Siparisler"];
                baglan.Close();
            }
        }
    }
}
