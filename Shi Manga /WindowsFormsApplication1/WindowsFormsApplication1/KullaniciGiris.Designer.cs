namespace WindowsFormsApplication1
{
    partial class KullaniciGiris
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.Txt_Sifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(100, 531);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(245, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(71, 434);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // halbuki resources'de var
            //bir şey silmişsin bu oyüzden olmuş şey sildim yand resources vardı onu sildim ama onu silmeden önce de hata veriyordu
            //this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Kullanici;
            this.pictureBox1.Location = new System.Drawing.Point(23, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_KullaniciAdi
            // 
            this.Txt_KullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_KullaniciAdi.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Txt_KullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.Txt_KullaniciAdi.Location = new System.Drawing.Point(180, 351);
            this.Txt_KullaniciAdi.Multiline = true;
            this.Txt_KullaniciAdi.Name = "Txt_KullaniciAdi";
            this.Txt_KullaniciAdi.Size = new System.Drawing.Size(180, 20);
            this.Txt_KullaniciAdi.TabIndex = 1;
            this.Txt_KullaniciAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Sifre.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Txt_Sifre.Location = new System.Drawing.Point(143, 394);
            this.Txt_Sifre.Multiline = true;
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.PasswordChar = '*';
            this.Txt_Sifre.Size = new System.Drawing.Size(218, 20);
            this.Txt_Sifre.TabIndex = 2;
            this.Txt_Sifre.Tag = "";
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 634);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Txt_Sifre);
            this.Controls.Add(this.Txt_KullaniciAdi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KullaniciGiris";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.KullaniciGiris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KullaniciGiris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox Txt_KullaniciAdi;
        private System.Windows.Forms.TextBox Txt_Sifre;
    }
}