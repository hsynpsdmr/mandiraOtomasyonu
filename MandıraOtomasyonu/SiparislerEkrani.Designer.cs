namespace MandıraOtomasyonu
{
    partial class SiparislerEkrani
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
            this.buttonGeri = new System.Windows.Forms.Button();
            this.dataGridViewSiparisler = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamücret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(13, 13);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(75, 23);
            this.buttonGeri.TabIndex = 0;
            this.buttonGeri.Text = "GERİ";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // dataGridViewSiparisler
            // 
            this.dataGridViewSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparisler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.musteriid,
            this.toplamücret});
            this.dataGridViewSiparisler.Location = new System.Drawing.Point(13, 42);
            this.dataGridViewSiparisler.Name = "dataGridViewSiparisler";
            this.dataGridViewSiparisler.Size = new System.Drawing.Size(775, 396);
            this.dataGridViewSiparisler.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // musteriid
            // 
            this.musteriid.DataPropertyName = "musteriid";
            this.musteriid.HeaderText = "MÜŞTERİ ID";
            this.musteriid.Name = "musteriid";
            // 
            // toplamücret
            // 
            this.toplamücret.DataPropertyName = "toplamücret";
            this.toplamücret.HeaderText = "ÖDEDİĞİ ÜCRET";
            this.toplamücret.Name = "toplamücret";
            // 
            // SiparislerEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSiparisler);
            this.Controls.Add(this.buttonGeri);
            this.Name = "SiparislerEkrani";
            this.Text = "SiparislerEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.DataGridView dataGridViewSiparisler;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriid;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamücret;
    }
}