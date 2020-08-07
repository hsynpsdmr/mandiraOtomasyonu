namespace MandıraOtomasyonu
{
    partial class MusterilerEkrani
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
            this.dataGridViewMusteriler = new System.Windows.Forms.DataGridView();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMusteriler
            // 
            this.dataGridViewMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ad,
            this.soyad,
            this.email,
            this.telefon,
            this.adres,
            this.sifre});
            this.dataGridViewMusteriler.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewMusteriler.Name = "dataGridViewMusteriler";
            this.dataGridViewMusteriler.Size = new System.Drawing.Size(776, 396);
            this.dataGridViewMusteriler.TabIndex = 0;
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(13, 13);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(75, 23);
            this.buttonGeri.TabIndex = 1;
            this.buttonGeri.Text = "GERİ";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // ad
            // 
            this.ad.DataPropertyName = "ad";
            this.ad.HeaderText = "AD";
            this.ad.Name = "ad";
            // 
            // soyad
            // 
            this.soyad.DataPropertyName = "soyad";
            this.soyad.HeaderText = "SOYAD";
            this.soyad.Name = "soyad";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-MAİL";
            this.email.Name = "email";
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "TELEFON";
            this.telefon.Name = "telefon";
            // 
            // adres
            // 
            this.adres.DataPropertyName = "adres";
            this.adres.HeaderText = "ADRES";
            this.adres.Name = "adres";
            // 
            // sifre
            // 
            this.sifre.DataPropertyName = "sifre";
            this.sifre.HeaderText = "ŞİFRE";
            this.sifre.Name = "sifre";
            // 
            // MusterilerEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.dataGridViewMusteriler);
            this.Name = "MusterilerEkrani";
            this.Text = "MusterilerEkranı";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMusteriler;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifre;
    }
}