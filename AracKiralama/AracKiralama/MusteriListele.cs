using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class MusteriListele : Form
    {
        private string baglantiCumlesi = @"Data Source=WIN-97U941GM3L8\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True";

        public MusteriListele()
        {
            InitializeComponent();
        }

        private void DataGridViewStyle()//datagridview style
        {

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.FromArgb(240, 240, 240);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 200, 200);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(10, 10, 10);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.RowHeadersVisible = false;
        }
        private void Musteri_Listele()//Müşeteri Listeleme 
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();

                string komutCumlesi = "SELECT Tc_No, Ad_Soyad, Mail, Telefon_No, Adres FROM Musteriler";
                using (SqlCommand komut = new SqlCommand(komutCumlesi, baglanti))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(komut))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }


        public void Musteri_Guncelle()//Güncelleme
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Update Musteriler set Ad_Soyad=@adsoyad,Mail=@mail,Telefon_No=@telefon,Adres=@adres where Tc_No=@tc";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@Mail", txtMail.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Musteri_Listele();

        }


        private void Musteri_Sil()//Silme
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "DELETE FROM Musteriler WHERE Tc_No='" + dataGridView1.CurrentRow.Cells["Tc_No"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            Musteri_Listele();
        }


        private void MusteriListele_Load(object sender, EventArgs e)
        {
            Musteri_Listele();
            DataGridViewStyle();
        }
        // Tıklanan Kişinin Bilgileri Texboxlara Aktarılır
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtTc.Text = row.Cells["Tc_No"].Value.ToString();
                txtAdSoyad.Text = row.Cells["Ad_Soyad"].Value.ToString();
                txtMail.Text = row.Cells["Mail"].Value.ToString();
                txtTel.Text = row.Cells["Telefon_No"].Value.ToString();
                txtAdres.Text = row.Cells["Adres"].Value.ToString();
            }
        }
        private void btnSil_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçili müşteriyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Musteri_Sil();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Musteri_Guncelle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();

                    string komutCumlesi = "SELECT Tc_No, Ad_Soyad, Mail, Telefon_No, Adres FROM Musteriler WHERE Tc_No LIKE @searchText";
                    using (SqlCommand komut = new SqlCommand(komutCumlesi, baglanti))
                    {
                        komut.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(komut))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            else
            {
                Musteri_Listele();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
