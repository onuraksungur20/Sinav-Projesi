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
    public partial class Form_SureliSinav : Form
    {
        public Form_SureliSinav()
        {
            InitializeComponent();
        }

        int saniye = 60, dakika = 0, sayi, sira = 0;
        int[] sayilar = new int[10];
        List<int> DogruCevaplar = new List<int>();
        List<string> YanlisCevaplar = new List<string>();
        Random random = new Random();

        void goster(string Cevap)
        {
            if (Cevap == "A")
                button1.BackColor = Color.Green;
            if (Cevap == "B")
                button2.BackColor = Color.Green;
            if (Cevap == "C")
                button3.BackColor = Color.Green;
            if (Cevap == "D")
                button4.BackColor = Color.Green;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false;
            button5.Enabled = true;
        }
        string yanlisGoster()
        {
            if (button1.BackColor == Color.Green)
                return label2.Text;
            if (button2.BackColor == Color.Green)
                return label3.Text;
            if (button3.BackColor == Color.Green)
                return label4.Text;
            if (button4.BackColor == Color.Green)
                return label5.Text;
            return label1.Text;
        }
        void butonIsi(string ans, Button buton)
        {
            goster(ans);
            if (ans == buton.Text)
            {
                buton.BackColor = Color.Green;
                DogruCevaplar.Add(sira);
            }
            else
            {
                buton.BackColor = Color.Red;
                YanlisCevaplar.Add(label1.Text + "\nCevap : " + yanlisGoster());
            }
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N3S1O7R\\SQLEXPRESS;Initial Catalog=SinavUygulama;Integrated Security=True");

        string cevap;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye -=1;
            lblSaniye.Text = Convert.ToString(saniye);
            lblDakika.Text = Convert.ToString(dakika - 1);
            if (saniye == 0)
            {
                dakika = dakika - 1;
                lblDakika.Text = Convert.ToString(dakika);
                saniye = 60;
            }

            if (lblDakika.Text == "-1")
            {
                timer1.Stop();
                lblDakika.Text = "00";
                lblSaniye.Text = "00";
                MessageBox.Show("süreniz bitti");

                DialogResult S1 = MessageBox.Show(DogruCevaplar.Count + "0% başarı oranı!\nYanlış soruların cevaplarını görmek için \"GÖR\" tuşuna basınız.\nDoğru Sayınız: " + DogruCevaplar.Count + "\nYanlış Sayınız: " + YanlisCevaplar.Count + "\nBoş Sayınız: " + (10 - (DogruCevaplar.Count + YanlisCevaplar.Count)), "", MessageBoxButtons.YesNo);
                int yanlisSayisi = YanlisCevaplar.Count;
                YanlisCevaplar.Reverse();
                if (S1 == DialogResult.Yes)
                {
                    do
                    {
                        yanlisSayisi--;
                        MessageBox.Show(YanlisCevaplar[yanlisSayisi], "", MessageBoxButtons.OK);
                    } while (yanlisSayisi > 0);
                }
                MessageBox.Show("Sınav penceresinden ayrılıyorsunuz.");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            butonIsi(cevap, button1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            butonIsi(cevap, button2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            butonIsi(cevap, button3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            butonIsi(cevap, button4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 10)
            {
                sayi = random.Next(1, 100);
                int yoksa = Array.IndexOf(sayilar, sayi);
                if (yoksa == -1)
                    sayilar[i++] = sayi;
            }

            if (sira < 10)
            {
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = Color.White;
                button5.Enabled = button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = true;
                button5.Enabled = false;

                baglanti.Open();
                string kayit = "select * from sorular where sayi = @SS";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@SS", sayilar[sira++].ToString());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    label1.Text = sira.ToString() + ". Soru: " + (dr["soru"].ToString());
                    label2.Text = (dr["secenek1"].ToString());
                    label3.Text = (dr["secenek2"].ToString());
                    label4.Text = (dr["secenek3"].ToString());
                    label5.Text = (dr["secenek4"].ToString());
                    cevap = (dr["dogruCevap"].ToString());
                }
                baglanti.Close();
                button5.Text = ("Sonraki Soru");
            }
            else
            {
                DialogResult S1 = MessageBox.Show(DogruCevaplar.Count + "0% başarı oranı!\nYanlış soruların cevaplarını görmek için \"GÖR\" tuşuna basınız.", "", MessageBoxButtons.YesNo);
                int yanlisSayisi = YanlisCevaplar.Count;
                YanlisCevaplar.Reverse();
                if (S1 == DialogResult.Yes) do MessageBox.Show(YanlisCevaplar[--yanlisSayisi], "", MessageBoxButtons.OK);
                    while (yanlisSayisi > 0);

                MessageBox.Show("Sınav penceresinden ayrılıyorsunuz.");
                this.Close();
            }
        }
        private void Form_SureliSinav_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sınava hoşgeldiniz. 10 dakikalık süreniz başlıyor.");
            timer1.Start();
            dakika = Convert.ToInt32(10);        
        }
    }
}
