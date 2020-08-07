namespace MandıraOtomasyonu
{
    partial class UrunGirEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.textBoxUrunFiyati = new System.Windows.Forms.TextBox();
            this.textBoxUrunAdeti = new System.Windows.Forms.TextBox();
            this.buttonYeniUrunEkle = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "YENİ ÜRÜN GİRME EKRANI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÜRÜN ADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ÜRÜN FİYATI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ÜRÜN ADETİ";
            // 
            // textBoxUrunAdi
            // 
            this.textBoxUrunAdi.Location = new System.Drawing.Point(246, 121);
            this.textBoxUrunAdi.Name = "textBoxUrunAdi";
            this.textBoxUrunAdi.Size = new System.Drawing.Size(150, 20);
            this.textBoxUrunAdi.TabIndex = 4;
            // 
            // textBoxUrunFiyati
            // 
            this.textBoxUrunFiyati.Location = new System.Drawing.Point(246, 172);
            this.textBoxUrunFiyati.Name = "textBoxUrunFiyati";
            this.textBoxUrunFiyati.Size = new System.Drawing.Size(150, 20);
            this.textBoxUrunFiyati.TabIndex = 5;
            // 
            // textBoxUrunAdeti
            // 
            this.textBoxUrunAdeti.Location = new System.Drawing.Point(246, 228);
            this.textBoxUrunAdeti.Name = "textBoxUrunAdeti";
            this.textBoxUrunAdeti.Size = new System.Drawing.Size(150, 20);
            this.textBoxUrunAdeti.TabIndex = 6;
            // 
            // buttonYeniUrunEkle
            // 
            this.buttonYeniUrunEkle.Location = new System.Drawing.Point(152, 300);
            this.buttonYeniUrunEkle.Name = "buttonYeniUrunEkle";
            this.buttonYeniUrunEkle.Size = new System.Drawing.Size(123, 23);
            this.buttonYeniUrunEkle.TabIndex = 7;
            this.buttonYeniUrunEkle.Text = "YENİ ÜRÜNÜ EKLE";
            this.buttonYeniUrunEkle.UseVisualStyleBackColor = true;
            this.buttonYeniUrunEkle.Click += new System.EventHandler(this.buttonYeniUrunEkle_Click);
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(13, 13);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(75, 23);
            this.buttonGeri.TabIndex = 8;
            this.buttonGeri.Text = "GERİ";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // UrunGirEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 354);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.buttonYeniUrunEkle);
            this.Controls.Add(this.textBoxUrunAdeti);
            this.Controls.Add(this.textBoxUrunFiyati);
            this.Controls.Add(this.textBoxUrunAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UrunGirEkrani";
            this.Text = "UrunGirEkranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUrunAdi;
        private System.Windows.Forms.TextBox textBoxUrunFiyati;
        private System.Windows.Forms.TextBox textBoxUrunAdeti;
        private System.Windows.Forms.Button buttonYeniUrunEkle;
        private System.Windows.Forms.Button buttonGeri;
    }
}