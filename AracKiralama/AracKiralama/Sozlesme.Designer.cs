﻿namespace AracKiralama
{
    partial class Sozlesme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sozlesme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEhliyetTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxKiraSekli = new System.Windows.Forms.ComboBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.datetimeDönüs = new System.Windows.Forms.DateTimePicker();
            this.datetimeCikis = new System.Windows.Forms.DateTimePicker();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtGün = new System.Windows.Forms.TextBox();
            this.txtKiraÜcreti = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.cbxAraclar = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAracTeslim = new System.Windows.Forms.Button();
            this.cks = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEhliyetTarih);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtEhliyetTarih
            // 
            this.txtEhliyetTarih.Location = new System.Drawing.Point(111, 127);
            this.txtEhliyetTarih.Name = "txtEhliyetTarih";
            this.txtEhliyetTarih.Size = new System.Drawing.Size(148, 20);
            this.txtEhliyetTarih.TabIndex = 19;
            this.txtEhliyetTarih.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ehliyet Tarihi :";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(112, 86);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(148, 20);
            this.txtTel.TabIndex = 14;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(111, 52);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(148, 20);
            this.txtAdSoyad.TabIndex = 13;
            // 
            // txtTc1
            // 
            this.txtTc1.Location = new System.Drawing.Point(111, 20);
            this.txtTc1.MaxLength = 11;
            this.txtTc1.Name = "txtTc1";
            this.txtTc1.Size = new System.Drawing.Size(148, 20);
            this.txtTc1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tefefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tc :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxKiraSekli);
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.datetimeDönüs);
            this.groupBox2.Controls.Add(this.datetimeCikis);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.txtGün);
            this.groupBox2.Controls.Add(this.txtKiraÜcreti);
            this.groupBox2.Controls.Add(this.txtRenk);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.txtSeri);
            this.groupBox2.Controls.Add(this.txtMarka);
            this.groupBox2.Controls.Add(this.cbxAraclar);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbxKiraSekli
            // 
            this.cbxKiraSekli.FormattingEnabled = true;
            this.cbxKiraSekli.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık",
            "Aylık"});
            this.cbxKiraSekli.Location = new System.Drawing.Point(365, 23);
            this.cbxKiraSekli.Name = "cbxKiraSekli";
            this.cbxKiraSekli.Size = new System.Drawing.Size(153, 21);
            this.cbxKiraSekli.TabIndex = 23;
            this.cbxKiraSekli.SelectedIndexChanged += new System.EventHandler(this.cbxKiraSekli_SelectedIndexChanged);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Image = global::AracKiralama.Properties.Resources.hesap;
            this.btnHesapla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapla.Location = new System.Drawing.Point(222, 199);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(116, 49);
            this.btnHesapla.TabIndex = 20;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // datetimeDönüs
            // 
            this.datetimeDönüs.Location = new System.Drawing.Point(365, 170);
            this.datetimeDönüs.Name = "datetimeDönüs";
            this.datetimeDönüs.Size = new System.Drawing.Size(153, 20);
            this.datetimeDönüs.TabIndex = 19;
            // 
            // datetimeCikis
            // 
            this.datetimeCikis.Location = new System.Drawing.Point(365, 136);
            this.datetimeCikis.Name = "datetimeCikis";
            this.datetimeCikis.Size = new System.Drawing.Size(153, 20);
            this.datetimeCikis.TabIndex = 18;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(365, 107);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(153, 20);
            this.txtTutar.TabIndex = 16;
            // 
            // txtGün
            // 
            this.txtGün.Location = new System.Drawing.Point(365, 79);
            this.txtGün.Name = "txtGün";
            this.txtGün.Size = new System.Drawing.Size(153, 20);
            this.txtGün.TabIndex = 17;
            // 
            // txtKiraÜcreti
            // 
            this.txtKiraÜcreti.Location = new System.Drawing.Point(365, 51);
            this.txtKiraÜcreti.Name = "txtKiraÜcreti";
            this.txtKiraÜcreti.Size = new System.Drawing.Size(153, 20);
            this.txtKiraÜcreti.TabIndex = 14;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(102, 160);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(121, 20);
            this.txtRenk.TabIndex = 13;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(102, 128);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 20);
            this.txtModel.TabIndex = 13;
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(102, 95);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(121, 20);
            this.txtSeri.TabIndex = 13;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(102, 62);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(121, 20);
            this.txtMarka.TabIndex = 12;
            // 
            // cbxAraclar
            // 
            this.cbxAraclar.FormattingEnabled = true;
            this.cbxAraclar.Location = new System.Drawing.Point(102, 29);
            this.cbxAraclar.Name = "cbxAraclar";
            this.cbxAraclar.Size = new System.Drawing.Size(121, 21);
            this.cbxAraclar.TabIndex = 11;
            this.cbxAraclar.SelectedIndexChanged += new System.EventHandler(this.cbxAraclar_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(249, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 18);
            this.label16.TabIndex = 10;
            this.label16.Text = "Dönüş Tarihi :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(249, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 18);
            this.label15.TabIndex = 9;
            this.label15.Text = "Çıkış Tarihi :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(253, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 18);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tutar :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(253, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 18);
            this.label13.TabIndex = 7;
            this.label13.Text = "Gün :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(253, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Kira Ücreti :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(249, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "Kira Şekli :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(18, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Renk :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(18, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Model :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Seri :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(18, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Marka :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Araçlar :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(551, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 592);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(135, 47);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(148, 20);
            this.txtTc.TabIndex = 20;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(42, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 16);
            this.label17.TabIndex = 21;
            this.label17.Text = "TC İle Ara";
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::AracKiralama.Properties.Resources.kirala;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(336, 70);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 59);
            this.btnEkle.TabIndex = 21;
            this.btnEkle.Text = "Kirala";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnAracTeslim
            // 
            this.btnAracTeslim.Image = global::AracKiralama.Properties.Resources.teslim;
            this.btnAracTeslim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracTeslim.Location = new System.Drawing.Point(336, 147);
            this.btnAracTeslim.Name = "btnAracTeslim";
            this.btnAracTeslim.Size = new System.Drawing.Size(100, 59);
            this.btnAracTeslim.TabIndex = 3;
            this.btnAracTeslim.Text = "Teslim Edildi";
            this.btnAracTeslim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAracTeslim.UseVisualStyleBackColor = true;
            this.btnAracTeslim.Click += new System.EventHandler(this.btnAracTeslim_Click);
            // 
            // cks
            // 
            this.cks.Image = global::AracKiralama.Properties.Resources.cikis;
            this.cks.Location = new System.Drawing.Point(336, 235);
            this.cks.Name = "cks";
            this.cks.Size = new System.Drawing.Size(100, 59);
            this.cks.TabIndex = 22;
            this.cks.UseVisualStyleBackColor = true;
            this.cks.Click += new System.EventHandler(this.cks_Click);
            // 
            // Sozlesme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1232, 616);
            this.Controls.Add(this.cks);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.btnAracTeslim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sozlesme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sozlesme";
            this.Load += new System.EventHandler(this.Sozlesme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxAraclar;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.DateTimePicker datetimeDönüs;
        private System.Windows.Forms.DateTimePicker datetimeCikis;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtGün;
        private System.Windows.Forms.TextBox txtKiraÜcreti;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAracTeslim;
        private System.Windows.Forms.ComboBox cbxKiraSekli;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker txtEhliyetTarih;
        private System.Windows.Forms.Button cks;
    }
}