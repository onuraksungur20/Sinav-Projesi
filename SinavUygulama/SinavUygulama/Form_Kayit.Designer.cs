namespace SinavUygulama
{
    partial class Form_Kayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.txtparola = new System.Windows.Forms.TextBox();
            this.txteposta = new System.Windows.Forms.TextBox();
            this.radioort = new System.Windows.Forms.RadioButton();
            this.radioogr = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSoru = new System.Windows.Forms.ComboBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Parola :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "E-posta :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Durum :";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(312, 106);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(100, 22);
            this.txtisim.TabIndex = 1;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(312, 152);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(100, 22);
            this.txtsoyisim.TabIndex = 1;
            // 
            // txtkullanici
            // 
            this.txtkullanici.Location = new System.Drawing.Point(312, 198);
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(100, 22);
            this.txtkullanici.TabIndex = 1;
            // 
            // txtparola
            // 
            this.txtparola.Location = new System.Drawing.Point(312, 244);
            this.txtparola.Name = "txtparola";
            this.txtparola.Size = new System.Drawing.Size(100, 22);
            this.txtparola.TabIndex = 1;
            // 
            // txteposta
            // 
            this.txteposta.Location = new System.Drawing.Point(312, 290);
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(100, 22);
            this.txteposta.TabIndex = 1;
            // 
            // radioort
            // 
            this.radioort.AutoSize = true;
            this.radioort.Location = new System.Drawing.Point(291, 393);
            this.radioort.Name = "radioort";
            this.radioort.Size = new System.Drawing.Size(92, 21);
            this.radioort.TabIndex = 2;
            this.radioort.TabStop = true;
            this.radioort.Text = "Öğretmen";
            this.radioort.UseVisualStyleBackColor = true;
            // 
            // radioogr
            // 
            this.radioogr.AutoSize = true;
            this.radioogr.Location = new System.Drawing.Point(389, 393);
            this.radioogr.Name = "radioogr";
            this.radioogr.Size = new System.Drawing.Size(79, 21);
            this.radioogr.TabIndex = 3;
            this.radioogr.TabStop = true;
            this.radioogr.Text = "Öğrenci";
            this.radioogr.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSoru
            // 
            this.txtSoru.FormattingEnabled = true;
            this.txtSoru.Items.AddRange(new object[] {
            "En Sevdiğiniz Yemek",
            "Evcil Hayvanınızın İsmi",
            "En Sevdiğiniz Film"});
            this.txtSoru.Location = new System.Drawing.Point(221, 334);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(121, 24);
            this.txtSoru.TabIndex = 5;
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(348, 334);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(100, 22);
            this.txtCevap.TabIndex = 6;
            // 
            // Form_Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(652, 597);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioogr);
            this.Controls.Add(this.radioort);
            this.Controls.Add(this.txteposta);
            this.Controls.Add(this.txtparola);
            this.Controls.Add(this.txtkullanici);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Kayit";
            this.Text = "Form_kayit";
            this.Load += new System.EventHandler(this.Form_Kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.TextBox txtparola;
        private System.Windows.Forms.TextBox txteposta;
        private System.Windows.Forms.RadioButton radioort;
        private System.Windows.Forms.RadioButton radioogr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtSoru;
        private System.Windows.Forms.TextBox txtCevap;
    }
}