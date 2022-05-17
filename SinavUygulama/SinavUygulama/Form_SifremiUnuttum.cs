using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace SinavUygulama
{
    public partial class Form_SifremiUnuttum : Form
    {
        public Form_SifremiUnuttum()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N3S1O7R\\SQLEXPRESS;Initial Catalog=SinavUygulama;Integrated Security=True");
        SqlDataReader reader;


        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "select *from kullanici where kullaniciadi=@KA";
            SqlCommand komut = new SqlCommand(kayit,baglanti);
            komut.Parameters.AddWithValue("@KA", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) label2.Text =(dr["guvenlikSoru"].ToString());
            baglanti.Close();
            button1.Enabled = false;
            textBox1.Enabled = false;    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("select *from kullanici where kullaniciadi = @KA and guvenlikCevap = @PW", baglanti);
            command.Parameters.AddWithValue("@KA", textBox1.Text);
            command.Parameters.AddWithValue("@PW", textBox2.Text);

            reader = command.ExecuteReader();

            if (reader.Read())
            {
                
                MessageBox.Show("Parolanız: " + reader["parola"].ToString() + "");
            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.");
            }

            baglanti.Close();
        }

        private void Form_SifremiUnuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
