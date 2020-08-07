using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandıraOtomasyonu
{
    public partial class SatinAlEkrani : Form
    {
        public SatinAlEkrani()
        {
            InitializeComponent();
            labelGuvenlikKodu.Text = GuvenlikKoduUret(5);
          
        }
        private static Random random = new Random();
        private string GuvenlikKoduUret(int v)
        {
            string strarray = "0123456789ABCDEFGHIJKLMNOPRSXVYZW0123456789";
            return new string(Enumerable.Repeat(strarray, v).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void buttonAlisverisiTamamla_Click(object sender, EventArgs e)
        {
            AlisverisEkrani ae = new AlisverisEkrani();
            if (checkBoxKrediKarti.Checked)
            {
                if (labelGuvenlikKodu.Text == textBoxGuvenlikKodu.Text)
                {
                    MessageBox.Show("ALIŞVERİŞİNİZ BAŞARIYLA TAMAMLANDI");
                    ae.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("GÜVENLİK KODUNU YANLIŞ GİRDİNİZ...");
                }
            }
            else if(checkBoxKapidaOdeme.Checked)
            {
                MessageBox.Show("ALIŞVERİŞİNİZ BAŞARIYLA TAMAMLANDI");
                ae.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("ALIŞVERİŞİNİZİ TAMAMLAMAK İÇİN LÜTFEN BİR ÖDEME YÖNTEMİ SEÇİNİZ...");
            }
        }
    }
}
