namespace MandıraOtomasyonu
{
    partial class KullaniciAnasayfaEkrani
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
            this.buttonUrunGir = new System.Windows.Forms.Button();
            this.buttonStoklar = new System.Windows.Forms.Button();
            this.buttonMusteriler = new System.Windows.Forms.Button();
            this.buttonSiparisler = new System.Windows.Forms.Button();
            this.buttonCikisYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelKasa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ANASAYFASI";
            // 
            // buttonUrunGir
            // 
            this.buttonUrunGir.Location = new System.Drawing.Point(63, 144);
            this.buttonUrunGir.Name = "buttonUrunGir";
            this.buttonUrunGir.Size = new System.Drawing.Size(87, 23);
            this.buttonUrunGir.TabIndex = 1;
            this.buttonUrunGir.Text = "ÜRÜN GİR";
            this.buttonUrunGir.UseVisualStyleBackColor = true;
            this.buttonUrunGir.Click += new System.EventHandler(this.buttonUrunGir_Click);
            // 
            // buttonStoklar
            // 
            this.buttonStoklar.Location = new System.Drawing.Point(63, 197);
            this.buttonStoklar.Name = "buttonStoklar";
            this.buttonStoklar.Size = new System.Drawing.Size(87, 23);
            this.buttonStoklar.TabIndex = 3;
            this.buttonStoklar.Text = "STOKLAR";
            this.buttonStoklar.UseVisualStyleBackColor = true;
            this.buttonStoklar.Click += new System.EventHandler(this.buttonStoklar_Click);
            // 
            // buttonMusteriler
            // 
            this.buttonMusteriler.Location = new System.Drawing.Point(63, 253);
            this.buttonMusteriler.Name = "buttonMusteriler";
            this.buttonMusteriler.Size = new System.Drawing.Size(87, 23);
            this.buttonMusteriler.TabIndex = 4;
            this.buttonMusteriler.Text = "MÜŞTERİLER";
            this.buttonMusteriler.UseVisualStyleBackColor = true;
            this.buttonMusteriler.Click += new System.EventHandler(this.buttonMusteriler_Click);
            // 
            // buttonSiparisler
            // 
            this.buttonSiparisler.Location = new System.Drawing.Point(63, 308);
            this.buttonSiparisler.Name = "buttonSiparisler";
            this.buttonSiparisler.Size = new System.Drawing.Size(87, 23);
            this.buttonSiparisler.TabIndex = 5;
            this.buttonSiparisler.Text = "SİPARİŞLER";
            this.buttonSiparisler.UseVisualStyleBackColor = true;
            this.buttonSiparisler.Click += new System.EventHandler(this.buttonSiparisler_Click);
            // 
            // buttonCikisYap
            // 
            this.buttonCikisYap.Location = new System.Drawing.Point(311, 366);
            this.buttonCikisYap.Name = "buttonCikisYap";
            this.buttonCikisYap.Size = new System.Drawing.Size(75, 23);
            this.buttonCikisYap.TabIndex = 6;
            this.buttonCikisYap.Text = "ÇIKIŞ YAP";
            this.buttonCikisYap.UseVisualStyleBackColor = true;
            this.buttonCikisYap.Click += new System.EventHandler(this.buttonCikisYap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(336, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "KASA : ";
            // 
            // labelKasa
            // 
            this.labelKasa.AutoSize = true;
            this.labelKasa.Location = new System.Drawing.Point(393, 144);
            this.labelKasa.Name = "labelKasa";
            this.labelKasa.Size = new System.Drawing.Size(30, 13);
            this.labelKasa.TabIndex = 8;
            this.labelKasa.Text = "kasa";
            // 
            // KullaniciAnasayfaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.labelKasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCikisYap);
            this.Controls.Add(this.buttonSiparisler);
            this.Controls.Add(this.buttonMusteriler);
            this.Controls.Add(this.buttonStoklar);
            this.Controls.Add(this.buttonUrunGir);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciAnasayfaEkrani";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUrunGir;
        private System.Windows.Forms.Button buttonStoklar;
        private System.Windows.Forms.Button buttonMusteriler;
        private System.Windows.Forms.Button buttonSiparisler;
        private System.Windows.Forms.Button buttonCikisYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelKasa;
    }
}