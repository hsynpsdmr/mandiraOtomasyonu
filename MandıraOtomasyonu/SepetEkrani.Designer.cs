namespace MandıraOtomasyonu
{
    partial class SepetEkrani
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
            this.listBoxSepetim = new System.Windows.Forms.ListBox();
            this.buttonSatinAl = new System.Windows.Forms.Button();
            this.buttonSecilenUrunuSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOdenecekTutar = new System.Windows.Forms.Label();
            this.buttonAlisveriseDevamEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEPETİNİZ";
            // 
            // listBoxSepetim
            // 
            this.listBoxSepetim.FormattingEnabled = true;
            this.listBoxSepetim.Location = new System.Drawing.Point(69, 101);
            this.listBoxSepetim.Name = "listBoxSepetim";
            this.listBoxSepetim.Size = new System.Drawing.Size(111, 264);
            this.listBoxSepetim.TabIndex = 1;
            // 
            // buttonSatinAl
            // 
            this.buttonSatinAl.Location = new System.Drawing.Point(283, 292);
            this.buttonSatinAl.Name = "buttonSatinAl";
            this.buttonSatinAl.Size = new System.Drawing.Size(75, 23);
            this.buttonSatinAl.TabIndex = 2;
            this.buttonSatinAl.Text = "SATIN AL";
            this.buttonSatinAl.UseVisualStyleBackColor = true;
            this.buttonSatinAl.Click += new System.EventHandler(this.buttonSatinAl_Click);
            // 
            // buttonSecilenUrunuSil
            // 
            this.buttonSecilenUrunuSil.Location = new System.Drawing.Point(236, 128);
            this.buttonSecilenUrunuSil.Name = "buttonSecilenUrunuSil";
            this.buttonSecilenUrunuSil.Size = new System.Drawing.Size(172, 23);
            this.buttonSecilenUrunuSil.TabIndex = 3;
            this.buttonSecilenUrunuSil.Text = "SEÇİLEN ÜRÜNÜ SİL";
            this.buttonSecilenUrunuSil.UseVisualStyleBackColor = true;
            this.buttonSecilenUrunuSil.Click += new System.EventHandler(this.buttonSecilenUrunuSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ÖDEYECEĞİNİZ TOPLAM TUTAR";
            // 
            // labelOdenecekTutar
            // 
            this.labelOdenecekTutar.AutoSize = true;
            this.labelOdenecekTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOdenecekTutar.Location = new System.Drawing.Point(308, 240);
            this.labelOdenecekTutar.Name = "labelOdenecekTutar";
            this.labelOdenecekTutar.Size = new System.Drawing.Size(30, 31);
            this.labelOdenecekTutar.TabIndex = 5;
            this.labelOdenecekTutar.Text = "0";
            // 
            // buttonAlisveriseDevamEt
            // 
            this.buttonAlisveriseDevamEt.Location = new System.Drawing.Point(237, 157);
            this.buttonAlisveriseDevamEt.Name = "buttonAlisveriseDevamEt";
            this.buttonAlisveriseDevamEt.Size = new System.Drawing.Size(171, 23);
            this.buttonAlisveriseDevamEt.TabIndex = 6;
            this.buttonAlisveriseDevamEt.Text = "ALIŞVERİŞE DEVAM ET";
            this.buttonAlisveriseDevamEt.UseVisualStyleBackColor = true;
            this.buttonAlisveriseDevamEt.Click += new System.EventHandler(this.buttonAlisveriseDevamEt_Click);
            // 
            // SepetEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.buttonAlisveriseDevamEt);
            this.Controls.Add(this.labelOdenecekTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSecilenUrunuSil);
            this.Controls.Add(this.buttonSatinAl);
            this.Controls.Add(this.listBoxSepetim);
            this.Controls.Add(this.label1);
            this.Name = "SepetEkrani";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSatinAl;
        public System.Windows.Forms.ListBox listBoxSepetim;
        private System.Windows.Forms.Button buttonSecilenUrunuSil;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelOdenecekTutar;
        private System.Windows.Forms.Button buttonAlisveriseDevamEt;
    }
}