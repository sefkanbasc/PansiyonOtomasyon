namespace Pansiyon1
{
    partial class FrmYeniMusteri
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
            this.GbCinsiyet = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.TxtOdaNumarasi = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTcNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDoluOda = new System.Windows.Forms.Button();
            this.BtnBosOda = new System.Windows.Forms.Button();
            this.BtnOda109 = new System.Windows.Forms.Button();
            this.BtnOda108 = new System.Windows.Forms.Button();
            this.BtnOda107 = new System.Windows.Forms.Button();
            this.BtnOda106 = new System.Windows.Forms.Button();
            this.BtnOda105 = new System.Windows.Forms.Button();
            this.BtnOda104 = new System.Windows.Forms.Button();
            this.BtnOda103 = new System.Windows.Forms.Button();
            this.BtnOda102 = new System.Windows.Forms.Button();
            this.BtnOda101 = new System.Windows.Forms.Button();
            this.GbCinsiyet.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbCinsiyet
            // 
            this.GbCinsiyet.Controls.Add(this.label11);
            this.GbCinsiyet.Controls.Add(this.BtnKaydet);
            this.GbCinsiyet.Controls.Add(this.DtpCikisTarihi);
            this.GbCinsiyet.Controls.Add(this.DtpGirisTarihi);
            this.GbCinsiyet.Controls.Add(this.TxtUcret);
            this.GbCinsiyet.Controls.Add(this.TxtOdaNumarasi);
            this.GbCinsiyet.Controls.Add(this.TxtMail);
            this.GbCinsiyet.Controls.Add(this.CmbCinsiyet);
            this.GbCinsiyet.Controls.Add(this.MskTelefon);
            this.GbCinsiyet.Controls.Add(this.label10);
            this.GbCinsiyet.Controls.Add(this.TxtTcNo);
            this.GbCinsiyet.Controls.Add(this.label9);
            this.GbCinsiyet.Controls.Add(this.TxtSoyad);
            this.GbCinsiyet.Controls.Add(this.TxtAdi);
            this.GbCinsiyet.Controls.Add(this.label8);
            this.GbCinsiyet.Controls.Add(this.label7);
            this.GbCinsiyet.Controls.Add(this.label6);
            this.GbCinsiyet.Controls.Add(this.label5);
            this.GbCinsiyet.Controls.Add(this.label4);
            this.GbCinsiyet.Controls.Add(this.label3);
            this.GbCinsiyet.Controls.Add(this.label2);
            this.GbCinsiyet.Controls.Add(this.label1);
            this.GbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GbCinsiyet.Location = new System.Drawing.Point(12, 12);
            this.GbCinsiyet.Name = "GbCinsiyet";
            this.GbCinsiyet.Size = new System.Drawing.Size(644, 766);
            this.GbCinsiyet.TabIndex = 0;
            this.GbCinsiyet.TabStop = false;
            this.GbCinsiyet.Text = "Müşteri Bilgileri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(550, 709);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "0";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnKaydet.Location = new System.Drawing.Point(224, 663);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(243, 44);
            this.BtnKaydet.TabIndex = 21;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCikisTarihi.Location = new System.Drawing.Point(213, 602);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(264, 28);
            this.DtpCikisTarihi.TabIndex = 20;
            this.DtpCikisTarihi.ValueChanged += new System.EventHandler(this.DtpCikisTarihi_ValueChanged);
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpGirisTarihi.Location = new System.Drawing.Point(213, 553);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(264, 28);
            this.DtpGirisTarihi.TabIndex = 19;
            // 
            // TxtUcret
            // 
            this.TxtUcret.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUcret.Location = new System.Drawing.Point(213, 491);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(264, 27);
            this.TxtUcret.TabIndex = 18;
            // 
            // TxtOdaNumarasi
            // 
            this.TxtOdaNumarasi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOdaNumarasi.Location = new System.Drawing.Point(213, 429);
            this.TxtOdaNumarasi.Name = "TxtOdaNumarasi";
            this.TxtOdaNumarasi.Size = new System.Drawing.Size(264, 27);
            this.TxtOdaNumarasi.TabIndex = 17;
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(213, 363);
            this.TxtMail.MaxLength = 100;
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(264, 27);
            this.TxtMail.TabIndex = 16;
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(213, 170);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(264, 30);
            this.CmbCinsiyet.TabIndex = 15;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTelefon.Location = new System.Drawing.Point(213, 287);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(264, 30);
            this.MskTelefon.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(51, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 30);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cinsiyet :";
            // 
            // TxtTcNo
            // 
            this.TxtTcNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTcNo.Location = new System.Drawing.Point(213, 224);
            this.TxtTcNo.MaxLength = 11;
            this.TxtTcNo.Name = "TxtTcNo";
            this.TxtTcNo.Size = new System.Drawing.Size(264, 27);
            this.TxtTcNo.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(25, 599);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 30);
            this.label9.TabIndex = 10;
            this.label9.Text = "Giriş Tarihi  :";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(213, 106);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(264, 27);
            this.TxtSoyad.TabIndex = 9;
            // 
            // TxtAdi
            // 
            this.TxtAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdi.Location = new System.Drawing.Point(213, 52);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(264, 27);
            this.TxtAdi.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(25, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Giriş Tarihi  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(68, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ücret  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(68, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Oda No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(68, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "T.C Kimlik No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(68, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDoluOda);
            this.groupBox2.Controls.Add(this.BtnBosOda);
            this.groupBox2.Controls.Add(this.BtnOda109);
            this.groupBox2.Controls.Add(this.BtnOda108);
            this.groupBox2.Controls.Add(this.BtnOda107);
            this.groupBox2.Controls.Add(this.BtnOda106);
            this.groupBox2.Controls.Add(this.BtnOda105);
            this.groupBox2.Controls.Add(this.BtnOda104);
            this.groupBox2.Controls.Add(this.BtnOda103);
            this.groupBox2.Controls.Add(this.BtnOda102);
            this.groupBox2.Controls.Add(this.BtnOda101);
            this.groupBox2.Location = new System.Drawing.Point(701, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 776);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // BtnDoluOda
            // 
            this.BtnDoluOda.BackColor = System.Drawing.Color.Red;
            this.BtnDoluOda.Location = new System.Drawing.Point(417, 686);
            this.BtnDoluOda.Name = "BtnDoluOda";
            this.BtnDoluOda.Size = new System.Drawing.Size(98, 66);
            this.BtnDoluOda.TabIndex = 10;
            this.BtnDoluOda.Text = "Dolu";
            this.BtnDoluOda.UseVisualStyleBackColor = false;
            this.BtnDoluOda.Click += new System.EventHandler(this.BtnDoluOda_Click);
            // 
            // BtnBosOda
            // 
            this.BtnBosOda.BackColor = System.Drawing.Color.LightGreen;
            this.BtnBosOda.Location = new System.Drawing.Point(417, 595);
            this.BtnBosOda.Name = "BtnBosOda";
            this.BtnBosOda.Size = new System.Drawing.Size(98, 66);
            this.BtnBosOda.TabIndex = 9;
            this.BtnBosOda.Text = "Boş ";
            this.BtnBosOda.UseVisualStyleBackColor = false;
            this.BtnBosOda.Click += new System.EventHandler(this.BtnBosOda_Click);
            // 
            // BtnOda109
            // 
            this.BtnOda109.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnOda109.Location = new System.Drawing.Point(362, 410);
            this.BtnOda109.Name = "BtnOda109";
            this.BtnOda109.Size = new System.Drawing.Size(98, 66);
            this.BtnOda109.TabIndex = 8;
            this.BtnOda109.Text = "109";
            this.BtnOda109.UseVisualStyleBackColor = false;
            this.BtnOda109.Click += new System.EventHandler(this.BtnOda109_Click);
            // 
            // BtnOda108
            // 
            this.BtnOda108.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnOda108.Location = new System.Drawing.Point(192, 410);
            this.BtnOda108.Name = "BtnOda108";
            this.BtnOda108.Size = new System.Drawing.Size(98, 66);
            this.BtnOda108.TabIndex = 7;
            this.BtnOda108.Text = "108";
            this.BtnOda108.UseVisualStyleBackColor = false;
            this.BtnOda108.Click += new System.EventHandler(this.BtnOda108_Click);
            // 
            // BtnOda107
            // 
            this.BtnOda107.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnOda107.Location = new System.Drawing.Point(44, 410);
            this.BtnOda107.Name = "BtnOda107";
            this.BtnOda107.Size = new System.Drawing.Size(98, 66);
            this.BtnOda107.TabIndex = 6;
            this.BtnOda107.Text = "107";
            this.BtnOda107.UseVisualStyleBackColor = false;
            this.BtnOda107.Click += new System.EventHandler(this.BtnOda107_Click);
            // 
            // BtnOda106
            // 
            this.BtnOda106.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnOda106.Location = new System.Drawing.Point(362, 251);
            this.BtnOda106.Name = "BtnOda106";
            this.BtnOda106.Size = new System.Drawing.Size(98, 66);
            this.BtnOda106.TabIndex = 5;
            this.BtnOda106.Text = "106";
            this.BtnOda106.UseVisualStyleBackColor = false;
            this.BtnOda106.Click += new System.EventHandler(this.BtnOda106_Click);
            // 
            // BtnOda105
            // 
            this.BtnOda105.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnOda105.Location = new System.Drawing.Point(192, 251);
            this.BtnOda105.Name = "BtnOda105";
            this.BtnOda105.Size = new System.Drawing.Size(98, 66);
            this.BtnOda105.TabIndex = 4;
            this.BtnOda105.Text = "105";
            this.BtnOda105.UseVisualStyleBackColor = false;
            this.BtnOda105.Click += new System.EventHandler(this.BtnOda105_Click);
            // 
            // BtnOda104
            // 
            this.BtnOda104.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnOda104.Location = new System.Drawing.Point(44, 251);
            this.BtnOda104.Name = "BtnOda104";
            this.BtnOda104.Size = new System.Drawing.Size(98, 66);
            this.BtnOda104.TabIndex = 3;
            this.BtnOda104.Text = "104";
            this.BtnOda104.UseVisualStyleBackColor = false;
            this.BtnOda104.Click += new System.EventHandler(this.BtnOda104_Click);
            // 
            // BtnOda103
            // 
            this.BtnOda103.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnOda103.Location = new System.Drawing.Point(362, 80);
            this.BtnOda103.Name = "BtnOda103";
            this.BtnOda103.Size = new System.Drawing.Size(98, 66);
            this.BtnOda103.TabIndex = 2;
            this.BtnOda103.Text = "103";
            this.BtnOda103.UseVisualStyleBackColor = false;
            this.BtnOda103.Click += new System.EventHandler(this.BtnOda103_Click);
            // 
            // BtnOda102
            // 
            this.BtnOda102.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnOda102.Location = new System.Drawing.Point(192, 80);
            this.BtnOda102.Name = "BtnOda102";
            this.BtnOda102.Size = new System.Drawing.Size(98, 66);
            this.BtnOda102.TabIndex = 1;
            this.BtnOda102.Text = "102";
            this.BtnOda102.UseVisualStyleBackColor = false;
            this.BtnOda102.Click += new System.EventHandler(this.BtnOda102_Click);
            // 
            // BtnOda101
            // 
            this.BtnOda101.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnOda101.Location = new System.Drawing.Point(44, 80);
            this.BtnOda101.Name = "BtnOda101";
            this.BtnOda101.Size = new System.Drawing.Size(98, 66);
            this.BtnOda101.TabIndex = 0;
            this.BtnOda101.Text = "101";
            this.BtnOda101.UseVisualStyleBackColor = false;
            this.BtnOda101.Click += new System.EventHandler(this.BtnOda101_Click);
            // 
            // FrmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1382, 776);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbCinsiyet);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYeniMusteri";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmYeniMusteri_Load);
            this.GbCinsiyet.ResumeLayout(false);
            this.GbCinsiyet.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbCinsiyet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtTcNo;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.TextBox TxtOdaNumarasi;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.Button BtnDoluOda;
        private System.Windows.Forms.Button BtnBosOda;
        private System.Windows.Forms.Button BtnOda109;
        private System.Windows.Forms.Button BtnOda108;
        private System.Windows.Forms.Button BtnOda107;
        private System.Windows.Forms.Button BtnOda106;
        private System.Windows.Forms.Button BtnOda105;
        private System.Windows.Forms.Button BtnOda104;
        private System.Windows.Forms.Button BtnOda103;
        private System.Windows.Forms.Button BtnOda102;
        private System.Windows.Forms.Button BtnOda101;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label11;
    }
}

