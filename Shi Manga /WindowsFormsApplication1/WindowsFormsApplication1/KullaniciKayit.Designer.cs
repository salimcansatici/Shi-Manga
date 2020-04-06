namespace WindowsFormsApplication1
{
    partial class KullaniciKayit
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_Kullaniciadi = new System.Windows.Forms.TextBox();
            this.Txt_sifre = new System.Windows.Forms.TextBox();
            this.Txt_Eposta = new System.Windows.Forms.TextBox();
            this.Txt_sifreonay = new System.Windows.Forms.TextBox();
            this.Btn_HesapOlustur = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_HesapOlustur)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.HesapOlustur;
            this.pictureBox1.Location = new System.Drawing.Point(20, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 598);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_Kullaniciadi
            // 
            this.Txt_Kullaniciadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Kullaniciadi.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Txt_Kullaniciadi.Location = new System.Drawing.Point(182, 132);
            this.Txt_Kullaniciadi.Multiline = true;
            this.Txt_Kullaniciadi.Name = "Txt_Kullaniciadi";
            this.Txt_Kullaniciadi.Size = new System.Drawing.Size(184, 20);
            this.Txt_Kullaniciadi.TabIndex = 1;
            // 
            // Txt_sifre
            // 
            this.Txt_sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_sifre.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Txt_sifre.Location = new System.Drawing.Point(143, 237);
            this.Txt_sifre.Multiline = true;
            this.Txt_sifre.Name = "Txt_sifre";
            this.Txt_sifre.PasswordChar = '*';
            this.Txt_sifre.Size = new System.Drawing.Size(211, 20);
            this.Txt_sifre.TabIndex = 2;
            // 
            // Txt_Eposta
            // 
            this.Txt_Eposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Eposta.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Txt_Eposta.Location = new System.Drawing.Point(156, 194);
            this.Txt_Eposta.Multiline = true;
            this.Txt_Eposta.Name = "Txt_Eposta";
            this.Txt_Eposta.Size = new System.Drawing.Size(213, 20);
            this.Txt_Eposta.TabIndex = 2;
            // 
            // Txt_sifreonay
            // 
            this.Txt_sifreonay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_sifreonay.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Txt_sifreonay.Location = new System.Drawing.Point(223, 279);
            this.Txt_sifreonay.Multiline = true;
            this.Txt_sifreonay.Name = "Txt_sifreonay";
            this.Txt_sifreonay.PasswordChar = '*';
            this.Txt_sifreonay.Size = new System.Drawing.Size(146, 20);
            this.Txt_sifreonay.TabIndex = 3;
            // 
            // Btn_HesapOlustur
            // 
            this.Btn_HesapOlustur.Location = new System.Drawing.Point(94, 549);
            this.Btn_HesapOlustur.Name = "Btn_HesapOlustur";
            this.Btn_HesapOlustur.Size = new System.Drawing.Size(260, 50);
            this.Btn_HesapOlustur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_HesapOlustur.TabIndex = 4;
            this.Btn_HesapOlustur.TabStop = false;
            this.Btn_HesapOlustur.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // KullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 644);
            this.Controls.Add(this.Btn_HesapOlustur);
            this.Controls.Add(this.Txt_sifreonay);
            this.Controls.Add(this.Txt_Eposta);
            this.Controls.Add(this.Txt_sifre);
            this.Controls.Add(this.Txt_Kullaniciadi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KullaniciKayit";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.KullaniciKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_HesapOlustur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_Kullaniciadi;
        private System.Windows.Forms.TextBox Txt_sifre;
        private System.Windows.Forms.TextBox Txt_Eposta;
        private System.Windows.Forms.TextBox Txt_sifreonay;
        private System.Windows.Forms.PictureBox Btn_HesapOlustur;
    }
}