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
    public partial class Form_Giris : Form
    {
        public Form_Giris()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-N3S1O7R\\SQLEXPRESS;Initial Catalog=SinavUygulama;Integrated Security=True");
        SqlDataReader reader;
        public static string user;

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("select *from kullanici where kullaniciadi = @KA and parola = @PW", baglanti);
            command.Parameters.AddWithValue("@KA", txtBoxKullanici.Text);
            command.Parameters.AddWithValue("@PW", txtBoxSifre.Text);

            reader = command.ExecuteReader();

            if (reader.Read())
            {
                user = reader["kullaniciadi"].ToString();
                MessageBox.Show("Giris Basarili "  + user + " Hoş geldiniz ");
                if (reader["tur"].ToString() == "ogr")
                {
                    Form_SinavTuru sinav = new Form_SinavTuru();
                    sinav.Show(); ;
                }

                if (reader["tur"].ToString() == "ort")
                {
                    Form_SoruEkle ekle = new Form_SoruEkle();
                    ekle.Show();
                }
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.");
                txtBoxKullanici.Text = txtBoxSifre.Text = "";
            }

            baglanti.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form_Kayit kayit = new Form_Kayit();
            kayit.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form_SifremiUnuttum unuttum = new Form_SifremiUnuttum();
            unuttum.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
