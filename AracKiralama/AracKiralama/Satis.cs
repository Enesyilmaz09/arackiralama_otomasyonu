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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=WIN-97U941GM3L8\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True";
        private void Satis_Load(object sender, EventArgs e)
        {
            DataGridViewStyle();
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            String komutCumlesi = "Select * From Satis";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
