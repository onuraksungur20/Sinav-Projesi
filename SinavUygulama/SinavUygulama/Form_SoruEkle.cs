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
    public partial class Form_SoruEkle : Form
    {
        public Form_SoruEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N3S1O7R\\SQLEXPRESS;Initial Catalog=SinavUygulama;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sorular(soru, secenek1, secenek2, secenek3, secenek4) values(@soru, @secenek1, @secenek2, @secenek3, @secenek4)", baglanti);
            komut.Parameters.AddWithValue("@soru", txtsoru.Text);
            komut.Parameters.AddWithValue("@secenek1", txta.Text);
            komut.Parameters.AddWithValue("@secenek2", txtb.Text);
            komut.Parameters.AddWithValue("@secenek3", txtc.Text);
            komut.Parameters.AddWithValue("@secenek4", txtd.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("gfhjbk");
            baglanti.Close();
        }

        private void Form_SoruEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
