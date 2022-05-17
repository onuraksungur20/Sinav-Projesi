using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SinavUygulama
{
    public partial class Form_SinavTuru : Form
    {
        public Form_SinavTuru()
        {
            InitializeComponent();
        }

        private void Form_SinavTuru_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            Form_SureliSinav Sureli = new Form_SureliSinav();
            Sureli.ShowDialog();
            this.Hide();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Form_SuresizSinav Suresiz = new Form_SuresizSinav();
            Suresiz.ShowDialog();
            this.Hide();
        }
    }
}
