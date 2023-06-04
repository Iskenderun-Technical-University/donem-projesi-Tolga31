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
using System.Data.SqlTypes;

namespace AracKiralama
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=DESKTOP-F562SE6;Initial Catalog=ARACKİRALAMAPROJE;Integrated Security=True";
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
            komut.Parameters.AddWithValue("@Telefon", maskedtxtTel.Text);
            komut.Parameters.AddWithValue("@Mail", txtMail.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
