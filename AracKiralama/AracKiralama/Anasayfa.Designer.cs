namespace AracKiralama
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.btnSatislar = new System.Windows.Forms.Button();
            this.btnSözlesme = new System.Windows.Forms.Button();
            this.btnAracListele = new System.Windows.Forms.Button();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSatislar
            // 
            resources.ApplyResources(this.btnSatislar, "btnSatislar");
            this.btnSatislar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSatislar.ForeColor = System.Drawing.Color.Black;
            this.btnSatislar.Image = global::AracKiralama.Properties.Resources.satıs;
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.UseVisualStyleBackColor = false;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // btnSözlesme
            // 
            resources.ApplyResources(this.btnSözlesme, "btnSözlesme");
            this.btnSözlesme.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSözlesme.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSözlesme.Image = global::AracKiralama.Properties.Resources.sozlesme;
            this.btnSözlesme.Name = "btnSözlesme";
            this.btnSözlesme.UseVisualStyleBackColor = false;
            this.btnSözlesme.Click += new System.EventHandler(this.btnSözlesme_Click);
            // 
            // btnAracListele
            // 
            resources.ApplyResources(this.btnAracListele, "btnAracListele");
            this.btnAracListele.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAracListele.Image = global::AracKiralama.Properties.Resources.liste;
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.UseVisualStyleBackColor = false;
            this.btnAracListele.Click += new System.EventHandler(this.btnAracListele_Click);
            // 
            // btnAracEkle
            // 
            resources.ApplyResources(this.btnAracEkle, "btnAracEkle");
            this.btnAracEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAracEkle.Image = global::AracKiralama.Properties.Resources.aracekle;
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.UseVisualStyleBackColor = false;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnMusteriListele
            // 
            resources.ApplyResources(this.btnMusteriListele, "btnMusteriListele");
            this.btnMusteriListele.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMusteriListele.Image = global::AracKiralama.Properties.Resources.liste;
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.UseVisualStyleBackColor = false;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // btnCikis
            // 
            resources.ApplyResources(this.btnCikis, "btnCikis");
            this.btnCikis.BackColor = System.Drawing.Color.Maroon;
            this.btnCikis.Image = global::AracKiralama.Properties.Resources.cikis;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnMusteriEkle
            // 
            resources.ApplyResources(this.btnMusteriEkle, "btnMusteriEkle");
            this.btnMusteriEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMusteriEkle.Image = global::AracKiralama.Properties.Resources.kisiekle;
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::AracKiralama.Properties.Resources.anasayfa;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Anasayfa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btnSatislar);
            this.Controls.Add(this.btnSözlesme);
            this.Controls.Add(this.btnAracListele);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnMusteriListele);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Button btnAracListele;
        private System.Windows.Forms.Button btnSözlesme;
        private System.Windows.Forms.Button btnSatislar;
    }
}

