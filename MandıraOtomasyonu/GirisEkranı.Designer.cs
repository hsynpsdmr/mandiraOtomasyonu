namespace MandıraOtomasyonu
{
    partial class GirisEkranı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MtextBoxEmail = new System.Windows.Forms.TextBox();
            this.MtextBoxSifre = new System.Windows.Forms.TextBox();
            this.KtextBoxEmail = new System.Windows.Forms.TextBox();
            this.KtextBoxSifre = new System.Windows.Forms.TextBox();
            this.MbuttonKayıtOl = new System.Windows.Forms.Button();
            this.MbuttonGirisYap = new System.Windows.Forms.Button();
            this.KbuttonGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(296, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖZDEMİR MANDIRA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MÜŞTERİ GİRİŞİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KULLANICI GİRİŞİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-MAİL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ŞİFRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-MAİL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ŞİFRE";
            // 
            // MtextBoxEmail
            // 
            this.MtextBoxEmail.Location = new System.Drawing.Point(151, 202);
            this.MtextBoxEmail.Name = "MtextBoxEmail";
            this.MtextBoxEmail.Size = new System.Drawing.Size(186, 20);
            this.MtextBoxEmail.TabIndex = 7;
            // 
            // MtextBoxSifre
            // 
            this.MtextBoxSifre.Location = new System.Drawing.Point(151, 239);
            this.MtextBoxSifre.Name = "MtextBoxSifre";
            this.MtextBoxSifre.Size = new System.Drawing.Size(186, 20);
            this.MtextBoxSifre.TabIndex = 8;
            // 
            // KtextBoxEmail
            // 
            this.KtextBoxEmail.Location = new System.Drawing.Point(587, 207);
            this.KtextBoxEmail.Name = "KtextBoxEmail";
            this.KtextBoxEmail.Size = new System.Drawing.Size(161, 20);
            this.KtextBoxEmail.TabIndex = 9;
            // 
            // KtextBoxSifre
            // 
            this.KtextBoxSifre.Location = new System.Drawing.Point(587, 236);
            this.KtextBoxSifre.Name = "KtextBoxSifre";
            this.KtextBoxSifre.Size = new System.Drawing.Size(161, 20);
            this.KtextBoxSifre.TabIndex = 10;
            // 
            // MbuttonKayıtOl
            // 
            this.MbuttonKayıtOl.Location = new System.Drawing.Point(151, 284);
            this.MbuttonKayıtOl.Name = "MbuttonKayıtOl";
            this.MbuttonKayıtOl.Size = new System.Drawing.Size(75, 23);
            this.MbuttonKayıtOl.TabIndex = 11;
            this.MbuttonKayıtOl.Text = "KAYIT OL";
            this.MbuttonKayıtOl.UseVisualStyleBackColor = true;
            this.MbuttonKayıtOl.Click += new System.EventHandler(this.MbuttonKayıtOl_Click);
            // 
            // MbuttonGirisYap
            // 
            this.MbuttonGirisYap.Location = new System.Drawing.Point(262, 284);
            this.MbuttonGirisYap.Name = "MbuttonGirisYap";
            this.MbuttonGirisYap.Size = new System.Drawing.Size(75, 23);
            this.MbuttonGirisYap.TabIndex = 12;
            this.MbuttonGirisYap.Text = "GİRİŞ YAP";
            this.MbuttonGirisYap.UseVisualStyleBackColor = true;
            this.MbuttonGirisYap.Click += new System.EventHandler(this.MbuttonGirisYap_Click);
            // 
            // KbuttonGirisYap
            // 
            this.KbuttonGirisYap.Location = new System.Drawing.Point(627, 284);
            this.KbuttonGirisYap.Name = "KbuttonGirisYap";
            this.KbuttonGirisYap.Size = new System.Drawing.Size(75, 23);
            this.KbuttonGirisYap.TabIndex = 13;
            this.KbuttonGirisYap.Text = "GİRİŞ  YAP";
            this.KbuttonGirisYap.UseVisualStyleBackColor = true;
            this.KbuttonGirisYap.Click += new System.EventHandler(this.KbuttonGirisYap_Click);
            // 
            // GirisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KbuttonGirisYap);
            this.Controls.Add(this.MbuttonGirisYap);
            this.Controls.Add(this.MbuttonKayıtOl);
            this.Controls.Add(this.KtextBoxSifre);
            this.Controls.Add(this.KtextBoxEmail);
            this.Controls.Add(this.MtextBoxSifre);
            this.Controls.Add(this.MtextBoxEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GirisEkranı";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MtextBoxEmail;
        private System.Windows.Forms.TextBox MtextBoxSifre;
        private System.Windows.Forms.TextBox KtextBoxEmail;
        private System.Windows.Forms.TextBox KtextBoxSifre;
        private System.Windows.Forms.Button MbuttonKayıtOl;
        private System.Windows.Forms.Button MbuttonGirisYap;
        private System.Windows.Forms.Button KbuttonGirisYap;
    }
}

