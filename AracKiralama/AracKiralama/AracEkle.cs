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
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=WIN-97U941GM3L8\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add("Corsa");
                comboBox2.Items.Add("Astra");
                comboBox2.Items.Add("İnsignia");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Add("Passat");
                comboBox2.Items.Add("Golf");
                comboBox2.Items.Add("Tiguan");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Add("i20");
                comboBox2.Items.Add("Tucson");
                comboBox2.Items.Add("Elentra");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Items.Add("Megane 6");
                comboBox2.Items.Add("Clio");
                comboBox2.Items.Add("Fluence");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                comboBox2.Items.Add("Focus");
                comboBox2.Items.Add("GT-500");
                comboBox2.Items.Add("Mustang");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Araclar Values (@plaka,@Marka,@Seri,@Model,@Renk,@Km,@Yakit,@Ücret,@Durumu)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@plaka", textBox1.Text);
            komut.Parameters.AddWithValue("@Marka", comboBox1.SelectedItem);
            komut.Parameters.AddWithValue("@Seri", comboBox2.SelectedItem);
            komut.Parameters.AddWithValue("@Model", textBox2.Text);
            komut.Parameters.AddWithValue("@Renk", textBox3.Text);
            komut.Parameters.AddWithValue("@Km", textBox4.Text);
            komut.Parameters.AddWithValue("@Yakit", comboBox3.SelectedItem);
            komut.Parameters.AddWithValue("@Ücret", textBox5.Text);
            komut.Parameters.AddWithValue("@Durumu", cbxDurum.SelectedItem);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");

            this.Close();

        }

       
            private void AracEkle_Load(object sender, EventArgs e)
            {
                // TextBox nesneleri için tasarım ayarları
                textBox1.BorderStyle = BorderStyle.None;
                textBox1.BackColor = Color.FromArgb(240, 240, 240);
                textBox1.Font = new Font("Segoe UI", 12);
                textBox1.ForeColor = Color.FromArgb(64, 64, 64);

                textBox2.BorderStyle = BorderStyle.None;
                textBox2.BackColor = Color.FromArgb(240, 240, 240);
                textBox2.Font = new Font("Segoe UI", 12);
                textBox2.ForeColor = Color.FromArgb(64, 64, 64);

                textBox3.BorderStyle = BorderStyle.None;
                textBox3.BackColor = Color.FromArgb(240, 240, 240);
                textBox3.Font = new Font("Segoe UI", 12);
                textBox3.ForeColor = Color.FromArgb(64, 64, 64);

                textBox4.BorderStyle = BorderStyle.None;
                textBox4.BackColor = Color.FromArgb(240, 240, 240);
                textBox4.Font = new Font("Segoe UI", 12);
                textBox4.ForeColor = Color.FromArgb(64, 64, 64);

                textBox5.BorderStyle = BorderStyle.None;
                textBox5.BackColor = Color.FromArgb(240, 240, 240);
                textBox5.Font = new Font("Segoe UI", 12);
                textBox5.ForeColor = Color.FromArgb(64, 64, 64);


           
                // Button nesneleri için tasarım ayarları
                button1.FlatStyle = FlatStyle.Flat;
                button1.BackColor = Color.FromArgb(64, 64, 64);
                button1.ForeColor = Color.White;
                button1.Font = new Font("Segoe UI", 12);
                button1.FlatAppearance.BorderSize = 0;

                button2.FlatStyle = FlatStyle.Flat;
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.White;
                button2.Font = new Font("Segoe UI", 12);
                button2.FlatAppearance.BorderSize = 0;
            
        }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
