namespace MandıraOtomasyonu
{
    partial class SatinAlEkrani
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
            this.checkBoxKrediKarti = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxGuvenlikKodu = new System.Windows.Forms.TextBox();
            this.checkBoxKapidaOdeme = new System.Windows.Forms.CheckBox();
            this.labelGuvenlikKodu = new System.Windows.Forms.Label();
            this.buttonAlisverisiTamamla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(286, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SATIN AL";
            // 
            // checkBoxKrediKarti
            // 
            this.checkBoxKrediKarti.AutoSize = true;
            this.checkBoxKrediKarti.Location = new System.Drawing.Point(86, 152);
            this.checkBoxKrediKarti.Name = "checkBoxKrediKarti";
            this.checkBoxKrediKarti.Size = new System.Drawing.Size(94, 17);
            this.checkBoxKrediKarti.TabIndex = 1;
            this.checkBoxKrediKarti.Text = "KREDİ KARTI";
            this.checkBoxKrediKarti.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kredi Kartı Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Güvenlik Kodu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBoxGuvenlikKodu
            // 
            this.textBoxGuvenlikKodu.Location = new System.Drawing.Point(238, 300);
            this.textBoxGuvenlikKodu.Name = "textBoxGuvenlikKodu";
            this.textBoxGuvenlikKodu.Size = new System.Drawing.Size(100, 20);
            this.textBoxGuvenlikKodu.TabIndex = 5;
            // 
            // checkBoxKapidaOdeme
            // 
            this.checkBoxKapidaOdeme.AutoSize = true;
            this.checkBoxKapidaOdeme.Location = new System.Drawing.Point(459, 152);
            this.checkBoxKapidaOdeme.Name = "checkBoxKapidaOdeme";
            this.checkBoxKapidaOdeme.Size = new System.Drawing.Size(107, 17);
            this.checkBoxKapidaOdeme.TabIndex = 6;
            this.checkBoxKapidaOdeme.Text = "KAPIDA ÖDEME";
            this.checkBoxKapidaOdeme.UseVisualStyleBackColor = true;
            // 
            // labelGuvenlikKodu
            // 
            this.labelGuvenlikKodu.AutoSize = true;
            this.labelGuvenlikKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGuvenlikKodu.Location = new System.Drawing.Point(243, 262);
            this.labelGuvenlikKodu.Name = "labelGuvenlikKodu";
            this.labelGuvenlikKodu.Size = new System.Drawing.Size(153, 25);
            this.labelGuvenlikKodu.TabIndex = 7;
            this.labelGuvenlikKodu.Text = "Güvenlik Kodu";
            // 
            // buttonAlisverisiTamamla
            // 
            this.buttonAlisverisiTamamla.Location = new System.Drawing.Point(265, 361);
            this.buttonAlisverisiTamamla.Name = "buttonAlisverisiTamamla";
            this.buttonAlisverisiTamamla.Size = new System.Drawing.Size(171, 23);
            this.buttonAlisverisiTamamla.TabIndex = 8;
            this.buttonAlisverisiTamamla.Text = "ALIŞVERİŞİ TAMAMLA";
            this.buttonAlisverisiTamamla.UseVisualStyleBackColor = true;
            this.buttonAlisverisiTamamla.Click += new System.EventHandler(this.buttonAlisverisiTamamla_Click);
            // 
            // SatinAlEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAlisverisiTamamla);
            this.Controls.Add(this.labelGuvenlikKodu);
            this.Controls.Add(this.checkBoxKapidaOdeme);
            this.Controls.Add(this.textBoxGuvenlikKodu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxKrediKarti);
            this.Controls.Add(this.label1);
            this.Name = "SatinAlEkrani";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxKrediKarti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxGuvenlikKodu;
        private System.Windows.Forms.CheckBox checkBoxKapidaOdeme;
        private System.Windows.Forms.Label labelGuvenlikKodu;
        private System.Windows.Forms.Button buttonAlisverisiTamamla;
    }
}