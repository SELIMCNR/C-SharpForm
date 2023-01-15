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

namespace Ogrencıtablouygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection bgl = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ogrenci.mdf;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrenciDataSet.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter1.Fill(this.ogrenciDataSet.Ogrenci);
      

        }

        private void Txt_Ekle_Click(object sender, EventArgs e)
        { 
            //ekle
            bgl.Open();
            SqlCommand komut = new SqlCommand("Insert into Ogrenci (Ogrno,Ad,Soyad,Bolum,Sehir) Values(@p1,@p2,@p3,@p4,@p5) ",bgl);
            komut.Parameters.AddWithValue("@p1",maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Ad.Text);
            komut.Parameters.AddWithValue("@p3", Txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p4", comboBoxBolum1.Text);
            komut.Parameters.AddWithValue("@p5", comboBoxSehir2.Text);
            komut.ExecuteNonQuery();
            komut.Dispose();
            bgl.Close();
            this.ogrenciTableAdapter1.Fill(this.ogrenciDataSet.Ogrenci);
        }

        private void Txt_Listele_Click(object sender, EventArgs e)
        {
            //Listeleme
            SqlCommand komut = new SqlCommand("Select * from Ogrenci ", bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);    
            dataGridView1.DataSource = dt;
        }

        private void Txt_Sil_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Delete from ogrenci where  Ogrno=@p1 ", bgl);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.ExecuteNonQuery();
            komut.Dispose();
            bgl.Close();
            this.ogrenciTableAdapter1.Fill(this.ogrenciDataSet.Ogrenci);

        }

        private void Txt_guncelle_Click(object sender, EventArgs e)
        {
            //Güncelleme
            bgl.Open();
            SqlCommand komut = new SqlCommand("Update  ogrenci set Ad=@p1,Soyad=@p2,Bolum=@p3,Sehir=@p4 where Ogrno=@p5", bgl);
            komut.Parameters.AddWithValue("@p1", Txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxBolum1.Text);
            komut.Parameters.AddWithValue("@p4", comboBoxSehir2.Text);
            komut.Parameters.AddWithValue("@p5", maskedTextBox1.Text);
            komut.ExecuteNonQuery();
            komut.Dispose();
            bgl.Close();
            this.ogrenciTableAdapter1.Fill(this.ogrenciDataSet.Ogrenci);
        }

        private void Txt_Ara_Click(object sender, EventArgs e)
        {
            //Arama
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * from ogrenci where Ogrno = @p1", bgl);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            komut.ExecuteNonQuery();
            komut.Dispose();
            bgl.Close();
            this.ogrenciTableAdapter1.Fill(this.ogrenciDataSet.Ogrenci);
        }
    }
}
