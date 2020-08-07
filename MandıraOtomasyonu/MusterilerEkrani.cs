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
    public partial class MusterilerEkrani : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=MandiraDB;Integrated Security=True");

        public MusterilerEkrani()
        {
            InitializeComponent();
            MusteriListeleme();
            dataGridViewMusteriler.AllowUserToAddRows = false;
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            KullaniciAnasayfaEkrani kae = new KullaniciAnasayfaEkrani();
            kae.Show();
            this.Close();
        }

        void MusteriListeleme()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = baglan;
                command.CommandText = "Select * from Musteriler";
                SqlDataAdapter dAdapter = new SqlDataAdapter(command);
                DataSet dSet = new DataSet();
                dAdapter.Fill(dSet, "Musteriler");
                dataGridViewMusteriler.DataSource = dSet.Tables["Musteriler"];
                baglan.Close();
            }
        }
    }
}
