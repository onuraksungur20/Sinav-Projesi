namespace SinavUygulama
{
    partial class Form_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Giris));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxKullanici = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtBoxSifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(302, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifremi Unuttum";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxKullanici
            // 
            this.txtBoxKullanici.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtBoxKullanici.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxKullanici.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtBoxKullanici.BorderThickness = 3;
            this.txtBoxKullanici.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxKullanici.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxKullanici.ForeColor = System.Drawing.Color.Black;
            this.txtBoxKullanici.isPassword = false;
            this.txtBoxKullanici.Location = new System.Drawing.Point(234, 190);
            this.txtBoxKullanici.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxKullanici.Name = "txtBoxKullanici";
            this.txtBoxKullanici.Size = new System.Drawing.Size(234, 31);
            this.txtBoxKullanici.TabIndex = 7;
            this.txtBoxKullanici.Text = "fuyor";
            this.txtBoxKullanici.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtBoxSifre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxSifre.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtBoxSifre.BorderThickness = 3;
            this.txtBoxSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxSifre.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSifre.isPassword = false;
            this.txtBoxSifre.Location = new System.Drawing.Point(234, 229);
            this.txtBoxSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(234, 31);
            this.txtBoxSifre.TabIndex = 8;
            this.txtBoxSifre.Text = "3131";
            this.txtBoxSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.ActiveBorderThickness = 1;
            this.button1.ActiveCornerRadius = 20;
            this.button1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button1.ActiveForecolor = System.Drawing.Color.White;
            this.button1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ButtonText = "Giris";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.IdleBorderThickness = 1;
            this.button1.IdleCornerRadius = 20;
            this.button1.IdleFillColor = System.Drawing.Color.White;
            this.button1.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(251, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 48);
            this.button1.TabIndex = 9;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.ActiveBorderThickness = 1;
            this.button2.ActiveCornerRadius = 20;
            this.button2.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button2.ActiveForecolor = System.Drawing.Color.White;
            this.button2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.ButtonText = "Kaydol";
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SeaGreen;
            this.button2.IdleBorderThickness = 1;
            this.button2.IdleCornerRadius = 20;
            this.button2.IdleFillColor = System.Drawing.Color.White;
            this.button2.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button2.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button2.Location = new System.Drawing.Point(302, 368);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 38);
            this.button2.TabIndex = 10;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(305, 85);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(88, 83);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // Form_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(713, 524);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.txtBoxKullanici);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBoxKullanici;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBoxSifre;
        private Bunifu.Framework.UI.BunifuThinButton2 button1;
        private Bunifu.Framework.UI.BunifuThinButton2 button2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;

    }
}

