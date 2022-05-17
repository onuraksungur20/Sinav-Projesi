using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinavUygulama
{
    public partial class Form_Kayit : Form
    {
        public Form_Kayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N3S1O7R\\SQLEXPRESS;Initial Catalog=SinavUygulama;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kullanici(isim, soyisim, kullaniciadi, parola, eposta, tur, guvenlikSoru, guvenlikCevap) values(@isim, @soyisim, @kullaniciadi, @parola, @eposta, @tur, @guvenlikSoru, @guvenlikCevap)", baglanti);
            komut.Parameters.AddWithValue("@isim", txtisim.Text);
            komut.Parameters.AddWithValue("@soyisim", txtsoyisim.Text);
            komut.Parameters.AddWithValue("@kullaniciadi", txtkullanici.Text);
            komut.Parameters.AddWithValue("@parola", txtparola.Text);
            komut.Parameters.AddWithValue("@eposta", txteposta.Text);
            komut.Parameters.AddWithValue("@guvenlikSoru", txtSoru.Text);
            komut.Parameters.AddWithValue("@guvenlikCevap", txtCevap.Text);
            if (radioogr.Checked)
                komut.Parameters.AddWithValue("@tur", "ogr");
            if (radioort.Checked)
                komut.Parameters.AddWithValue("@tur", "ort");
            komut.ExecuteNonQuery();
            MessageBox.Show("gfhjbk");
            baglanti.Close();
        }

        private void Form_Kayit_Load(object sender, EventArgs e)
        {

        }
    }
}
