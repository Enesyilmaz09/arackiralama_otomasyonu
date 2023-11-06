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
    public partial class Sozlesme : Form
    {
        public Sozlesme()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=WIN-97U941GM3L8\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True";

        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From Araclar where Durumu = 'Bos'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cbxAraclar.Items.Add(read["Plaka"]);
            }

        }
        public void Sozlesme_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            String komutCumlesi = "Select * From Sozlesme";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void cbxKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçilen kira şekline göre fiyatlandırma
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select Kira_Ucreti From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (cbxKiraSekli.SelectedIndex == 0)
                {
                    txtKiraÜcreti.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 1).ToString();
                }
                else if (cbxKiraSekli.SelectedIndex == 1)
                {
                    txtKiraÜcreti.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.80).ToString();
                }
                else if (cbxKiraSekli.SelectedIndex == 2)
                {
                    txtKiraÜcreti.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.70).ToString();
                }

            }

        }

        private void Sozlesme_Load(object sender, EventArgs e)
        {
            Arac_Listele();
            Sozlesme_Listele();
            Style();
        }
        private void Style()
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

            cks.FlatStyle = FlatStyle.Flat;
            cks.BackColor = Color.Red;
            cks.ForeColor = Color.White;
            cks.Font = new Font("Segoe UI", 12);
            cks.FlatAppearance.BorderSize = 0;

            btnAracTeslim.FlatStyle = FlatStyle.Flat;
            btnAracTeslim.BackColor = Color.Green;
            btnAracTeslim.ForeColor = Color.White;
            btnAracTeslim.Font = new Font("Segoe UI", 12);
            btnAracTeslim.FlatAppearance.BorderSize = 0;

            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.BackColor = Color.BlueViolet;
            btnEkle.ForeColor = Color.White;
            btnEkle.Font = new Font("Segoe UI", 12);
            btnEkle.FlatAppearance.BorderSize = 0;
        }
        private void cbxAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From Araclar where Plaka like '" + cbxAraclar.SelectedItem + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtMarka.Text = read["Marka"].ToString();
                txtSeri.Text = read["Seri"].ToString();
                txtModel.Text = read["Model"].ToString();
                txtRenk.Text = read["Renk"].ToString();
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Toplam tutar hesap
            TimeSpan gunfarki = DateTime.Parse(datetimeDönüs.Text) - DateTime.Parse(datetimeCikis.Text);
            int gunhesap = gunfarki.Days;
            txtGün.Text = gunhesap.ToString();

            txtTutar.Text = (gunhesap * int.Parse(txtKiraÜcreti.Text)).ToString();
        }

        private bool EhliyetTarihKontrol(DateTime ehliyetTarih)
        {

            TimeSpan timeSinceLicense = DateTime.Now - ehliyetTarih;
            if (timeSinceLicense.TotalDays < 365)
            {
                return false;
            }
            return true;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            DateTime ehliyetTarih = Convert.ToDateTime(txtEhliyetTarih.Text);
            if (!EhliyetTarihKontrol(ehliyetTarih))
            {
                MessageBox.Show("Ehliyet tarihi 1 yıldan önce alınmış Olmalı. Lütfen geçerli bir ehliyet tarihi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else { 
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Insert Into Sozlesme Values (@tcno,@AdSoyad,@Telefon,@ehliyettarih,@plaka,@Marka,@Seri,@Model,@Renk,@kirasekli,@kiraücreti,@kiralanangünsayisi,@tutar,@cikistarih,@donustarih)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@tcno", txtTc1.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@ehliyettarih", txtEhliyetTarih.Text);
            komut.Parameters.AddWithValue("@plaka", cbxAraclar.Text);
            komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
            komut.Parameters.AddWithValue("@Seri", txtSeri.Text);
            komut.Parameters.AddWithValue("@Model", txtModel.Text);
            komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@kirasekli", cbxKiraSekli.SelectedItem);
            komut.Parameters.AddWithValue("@kiraücreti", txtKiraÜcreti.Text);
            komut.Parameters.AddWithValue("@kiralanangünsayisi", txtGün.Text);
            komut.Parameters.AddWithValue("@tutar", txtTutar.Text);
            komut.Parameters.AddWithValue("@cikistarih", datetimeCikis.Value);
            komut.Parameters.AddWithValue("@donustarih", datetimeDönüs.Value);

            string komutCumlesiUp = "update Araclar set Durumu = 'Dolu' where Plaka ='" + cbxAraclar.SelectedItem + "'";
            SqlCommand komutUp = new SqlCommand(komutCumlesiUp, baglanti);
            komutUp.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Sozlesme_Listele();
            Arac_Listele();
            
            MessageBox.Show("Kayıt Başarılı");
            }
        }

        private void btnAracTeslim_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            
            int ucret = int.Parse(satir.Cells["Kira_Ucreti"].Value.ToString());
            int tutar = int.Parse(satir.Cells["Tutar"].Value.ToString());
            
         
          

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Delete from Sozlesme where Plaka = '" + satir.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.ExecuteNonQuery();


           

            string komutCumlesiSatis = "Insert Into Satis (Tc_No, Ad_Soyad, Plaka, Kira_Sekli, Kira_Ucret, Tutar, Cikis_Tarih, Donus_Tarih) Values (@tc_no, @AdSoyad, @Plaka, @kirasekli, @kiraücreti, @tutar, @cikistarih, @donustarih)";
            SqlCommand komutSatis = new SqlCommand(komutCumlesiSatis, baglanti);
            komutSatis.Parameters.AddWithValue("@tc_no", satir.Cells["Tc_No"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@AdSoyad", satir.Cells["Ad_Soyad"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Plaka", satir.Cells["Plaka"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@kirasekli", satir.Cells["Kira_Sekli"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@kiraücreti", ucret);
            komutSatis.Parameters.AddWithValue("@tutar", tutar);
            komutSatis.Parameters.AddWithValue("@cikistarih", satir.Cells["Cikis_Tarihi"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@donustarih", satir.Cells["Donus_Tarihi"].Value.ToString());
            komutSatis.ExecuteNonQuery();

            string komutCumlesiUp = "update Araclar set Durumu = 'Bos' where Plaka ='" + satir.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komutUp = new SqlCommand(komutCumlesiUp, baglanti);
            komutUp.ExecuteNonQuery();
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            MessageBox.Show("Araç Teslim Edildi");

        }

       

        private void txtTc_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From Musteriler where Tc_No like '" + txtTc.Text + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtTc1.Text = read["Tc_No"].ToString();
                txtAdSoyad.Text = read["Ad_Soyad"].ToString();
                txtTel.Text = read["Telefon_No"].ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cks_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
