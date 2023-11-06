using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AracKiralama
{
    public partial class AracListele : Form
    {
        private string baglantiCumlesi = @"Data Source=WIN-97U941GM3L8\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True";

        public AracListele()
        {
            InitializeComponent();
        }

        private void AracListele_Load(object sender, EventArgs e)
        {
            ButonTasarim();
            
            Arac_Listele();
            Renklendir();
            DataGridViewStyle();
        }
        private void ButonTasarim()
        {
            btnGüncelle.FlatStyle = FlatStyle.Flat;
            btnGüncelle.BackColor = Color.Green;
            btnGüncelle.ForeColor = Color.White;
            btnGüncelle.Font = new Font("Segoe UI", 12);
            btnGüncelle.FlatAppearance.BorderSize = 0;

            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.BackColor = Color.Red;
            btnSil.ForeColor = Color.White;
            btnSil.Font = new Font("Segoe UI", 12);
            btnSil.FlatAppearance.BorderSize = 0;


            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
            button3.Font = new Font("Segoe UI", 12);
            button3.FlatAppearance.BorderSize = 0;
        }

        

        
        private void Arac_Listele()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string komutCumlesi = "SELECT * FROM Araclar";
                SqlDataAdapter da = new SqlDataAdapter(komutCumlesi, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            Renklendir();
        }

        private void Renklendir()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToString(dataGridView1.Rows[i].Cells["Durumu"].Value) == "Bos")
                {
                    renk.BackColor = Color.LightGreen;
                }
                else
                {
                    renk.BackColor = Color.LightCoral;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void DataGridViewStyle()
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

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Arac_Guncelle();
            Renklendir();
        }

        private void Arac_Guncelle()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();

                string komutCumlesi = "UPDATE Araclar SET Marka=@marka, Seri=@seri, Model=@model, Renk=@renk, Kilometre=@km, Yakit=@yakit, Kira_Ucreti=@ucret, Durumu=@durum WHERE Plaka=@plaka";
                SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
                komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                komut.Parameters.AddWithValue("@marka", cbxMarka.Text);
                komut.Parameters.AddWithValue("@seri", cbxSeri.Text);
                komut.Parameters.AddWithValue("@model", txtModel.Text);
                komut.Parameters.AddWithValue("@renk", txtRenk.Text);
                komut.Parameters.AddWithValue("@km", txtKm.Text);
                komut.Parameters.AddWithValue("@yakit", cbxYakit.Text);
                komut.Parameters.AddWithValue("@ucret", txtÜcret.Text);
                komut.Parameters.AddWithValue("@durum", cbxAracDurum.Text);

                komut.ExecuteNonQuery();
            }

            Arac_Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçili Aracı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();

                    string komutCumlesi = "DELETE FROM Araclar WHERE Plaka=@plaka";
                    SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
                    komut.Parameters.AddWithValue("@plaka", dataGridView1.CurrentRow.Cells["Plaka"].Value.ToString());

                    komut.ExecuteNonQuery();
                }

                
            }
            Arac_Listele();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewStyle();

            txtPlaka.Text = dataGridView1.CurrentRow.Cells["Plaka"].Value.ToString();
            cbxMarka.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            cbxSeri.Text = dataGridView1.CurrentRow.Cells["Seri"].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells["Renk"].Value.ToString();
            txtKm.Text = dataGridView1.CurrentRow.Cells["Kilometre"].Value.ToString();
            cbxYakit.Text = dataGridView1.CurrentRow.Cells["Yakit"].Value.ToString();
            txtÜcret.Text = dataGridView1.CurrentRow.Cells["Kira_Ucreti"].Value.ToString();
            cbxAracDurum.Text = dataGridView1.CurrentRow.Cells["Durumu"].Value.ToString();
        }

        private void txtÜcret_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
