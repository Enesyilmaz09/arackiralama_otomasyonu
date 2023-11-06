using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AracKiralama
{
    public partial class MusteriEkle : Form
    {
        

       

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.ForeColor = Color.White;
            button3.Font = new Font("Segoe UI", 12);
            button3.FlatAppearance.BorderSize = 0;

            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.BackColor = Color.Green;
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Font = new Font("Segoe UI", 12);
            btnKaydet.FlatAppearance.BorderSize = 0;
        }
        public MusteriEkle()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=WIN-97U941GM3L8\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True";
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Musteriler Values (@tcno,@AdSoyad,@Telefon,@Mail,@Adres)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@tcno", txtTc.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@Mail", txtMail.Text);
            komut.Parameters.AddWithValue("@Telefon", maskedtxtTel.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");

            this.Close();
        }

        private void maskedtxtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

       
    }
}
