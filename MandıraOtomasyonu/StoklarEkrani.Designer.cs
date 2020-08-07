namespace MandıraOtomasyonu
{
    partial class StoklarEkrani
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
            this.dataGridViewStoklar = new System.Windows.Forms.DataGridView();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStoklar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStoklar
            // 
            this.dataGridViewStoklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStoklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.urunadi,
            this.fiyat,
            this.stok});
            this.dataGridViewStoklar.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewStoklar.Name = "dataGridViewStoklar";
            this.dataGridViewStoklar.Size = new System.Drawing.Size(776, 390);
            this.dataGridViewStoklar.TabIndex = 7;
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(12, 12);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(75, 23);
            this.buttonGeri.TabIndex = 8;
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
            // urunadi
            // 
            this.urunadi.DataPropertyName = "urunadi";
            this.urunadi.HeaderText = "ÜRÜN";
            this.urunadi.Name = "urunadi";
            // 
            // fiyat
            // 
            this.fiyat.DataPropertyName = "fiyat";
            this.fiyat.HeaderText = "FİYAT";
            this.fiyat.Name = "fiyat";
            // 
            // stok
            // 
            this.stok.DataPropertyName = "stok";
            this.stok.HeaderText = "STOK";
            this.stok.Name = "stok";
            // 
            // StoklarEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.dataGridViewStoklar);
            this.Name = "StoklarEkrani";
            this.Text = "StoklarEkranı";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStoklar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStoklar;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok;
    }
}