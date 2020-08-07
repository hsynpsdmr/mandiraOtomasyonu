namespace MandıraOtomasyonu
{
    partial class AlisverisEkrani
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
            this.listBoxUrunlerim = new System.Windows.Forms.ListBox();
            this.buttonSepeteGit = new System.Windows.Forms.Button();
            this.buttonCikisYap = new System.Windows.Forms.Button();
            this.dataGridViewUrunler = new System.Windows.Forms.DataGridView();
            this.urunadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.labelToplamTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜNLER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SEPET";
            // 
            // listBoxUrunlerim
            // 
            this.listBoxUrunlerim.FormattingEnabled = true;
            this.listBoxUrunlerim.Location = new System.Drawing.Point(580, 80);
            this.listBoxUrunlerim.Name = "listBoxUrunlerim";
            this.listBoxUrunlerim.Size = new System.Drawing.Size(110, 264);
            this.listBoxUrunlerim.TabIndex = 3;
            // 
            // buttonSepeteGit
            // 
            this.buttonSepeteGit.Location = new System.Drawing.Point(758, 130);
            this.buttonSepeteGit.Name = "buttonSepeteGit";
            this.buttonSepeteGit.Size = new System.Drawing.Size(134, 23);
            this.buttonSepeteGit.TabIndex = 4;
            this.buttonSepeteGit.Text = "SEPETE GİT";
            this.buttonSepeteGit.UseVisualStyleBackColor = true;
            this.buttonSepeteGit.Click += new System.EventHandler(this.buttonSepeteGit_Click);
            // 
            // buttonCikisYap
            // 
            this.buttonCikisYap.Location = new System.Drawing.Point(790, 321);
            this.buttonCikisYap.Name = "buttonCikisYap";
            this.buttonCikisYap.Size = new System.Drawing.Size(75, 23);
            this.buttonCikisYap.TabIndex = 5;
            this.buttonCikisYap.Text = "ÇIKIŞ YAP";
            this.buttonCikisYap.UseVisualStyleBackColor = true;
            this.buttonCikisYap.Click += new System.EventHandler(this.buttonCikisYap_Click);
            // 
            // dataGridViewUrunler
            // 
            this.dataGridViewUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunadi,
            this.fiyat,
            this.stok});
            this.dataGridViewUrunler.Location = new System.Drawing.Point(81, 79);
            this.dataGridViewUrunler.Name = "dataGridViewUrunler";
            this.dataGridViewUrunler.Size = new System.Drawing.Size(462, 265);
            this.dataGridViewUrunler.TabIndex = 6;
            this.dataGridViewUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUrunler_CellClick);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(774, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "TOPLAM TUTAR";
            // 
            // labelToplamTutar
            // 
            this.labelToplamTutar.AutoSize = true;
            this.labelToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamTutar.Location = new System.Drawing.Point(801, 79);
            this.labelToplamTutar.Name = "labelToplamTutar";
            this.labelToplamTutar.Size = new System.Drawing.Size(30, 31);
            this.labelToplamTutar.TabIndex = 8;
            this.labelToplamTutar.Text = "0";
            // 
            // AlisverisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.labelToplamTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewUrunler);
            this.Controls.Add(this.buttonCikisYap);
            this.Controls.Add(this.buttonSepeteGit);
            this.Controls.Add(this.listBoxUrunlerim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlisverisEkrani";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSepeteGit;
        private System.Windows.Forms.Button buttonCikisYap;
        private System.Windows.Forms.DataGridView dataGridViewUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listBoxUrunlerim;
        public System.Windows.Forms.Label labelToplamTutar;
    }
}