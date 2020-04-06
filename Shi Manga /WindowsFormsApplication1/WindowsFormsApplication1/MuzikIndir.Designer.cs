namespace WindowsFormsApplication1
{
    partial class MuzikIndir
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
            this.Pb_UstBanner = new System.Windows.Forms.PictureBox();
            this.Combo_AnimeAd = new System.Windows.Forms.ComboBox();
            this.Combo_SarkiAd = new System.Windows.Forms.ComboBox();
            this.BTN_Kontrol = new MetroFramework.Controls.MetroButton();
            this.BTN_Indir = new MetroFramework.Controls.MetroButton();
            this.BTN_Geri = new MetroFramework.Controls.MetroButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_UstBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_UstBanner
            // 
         
            this.Pb_UstBanner.Location = new System.Drawing.Point(23, 21);
            this.Pb_UstBanner.Name = "Pb_UstBanner";
            this.Pb_UstBanner.Size = new System.Drawing.Size(701, 324);
            this.Pb_UstBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_UstBanner.TabIndex = 0;
            this.Pb_UstBanner.TabStop = false;
            // 
            // Combo_AnimeAd
            // 
            this.Combo_AnimeAd.FormattingEnabled = true;
            this.Combo_AnimeAd.Items.AddRange(new object[] {
            "Fullmetal Alchemist"});
            this.Combo_AnimeAd.Location = new System.Drawing.Point(309, 362);
            this.Combo_AnimeAd.Name = "Combo_AnimeAd";
            this.Combo_AnimeAd.Size = new System.Drawing.Size(121, 21);
            this.Combo_AnimeAd.TabIndex = 1;
            this.Combo_AnimeAd.SelectedIndexChanged += new System.EventHandler(this.Combo_AnimeAd_SelectedIndexChanged);
            // 
            // Combo_SarkiAd
            // 
            this.Combo_SarkiAd.FormattingEnabled = true;
            this.Combo_SarkiAd.Location = new System.Drawing.Point(309, 389);
            this.Combo_SarkiAd.Name = "Combo_SarkiAd";
            this.Combo_SarkiAd.Size = new System.Drawing.Size(121, 21);
            this.Combo_SarkiAd.TabIndex = 1;
            this.Combo_SarkiAd.SelectedIndexChanged += new System.EventHandler(this.Combo_SarkiAd_SelectedIndexChanged);
            // 
            // BTN_Kontrol
            // 
            this.BTN_Kontrol.Location = new System.Drawing.Point(309, 428);
            this.BTN_Kontrol.Name = "BTN_Kontrol";
            this.BTN_Kontrol.Size = new System.Drawing.Size(121, 53);
            this.BTN_Kontrol.TabIndex = 2;
            this.BTN_Kontrol.Text = "Şarkıyı Kontrol Et";
            this.BTN_Kontrol.UseSelectable = true;
            this.BTN_Kontrol.Click += new System.EventHandler(this.BTN_Kontrol_Click);
            // 
            // BTN_Indir
            // 
            this.BTN_Indir.Location = new System.Drawing.Point(309, 487);
            this.BTN_Indir.Name = "BTN_Indir";
            this.BTN_Indir.Size = new System.Drawing.Size(121, 43);
            this.BTN_Indir.TabIndex = 3;
            this.BTN_Indir.Text = "Şarkıyı İndir";
            this.BTN_Indir.UseSelectable = true;
            this.BTN_Indir.Click += new System.EventHandler(this.BTN_Indir_Click);
            // 
            // BTN_Geri
            // 
            this.BTN_Geri.Location = new System.Drawing.Point(23, 523);
            this.BTN_Geri.Name = "BTN_Geri";
            this.BTN_Geri.Size = new System.Drawing.Size(49, 41);
            this.BTN_Geri.TabIndex = 4;
            this.BTN_Geri.Text = "Geri";
            this.BTN_Geri.UseSelectable = true;
            this.BTN_Geri.Click += new System.EventHandler(this.BTN_Geri_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(493, 372);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(192, 173);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.Url = new System.Uri("http://2conv.com/tr/", System.UriKind.Absolute);
            // 
            // MuzikIndir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 587);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.BTN_Geri);
            this.Controls.Add(this.BTN_Indir);
            this.Controls.Add(this.BTN_Kontrol);
            this.Controls.Add(this.Combo_SarkiAd);
            this.Controls.Add(this.Combo_AnimeAd);
            this.Controls.Add(this.Pb_UstBanner);
            this.Name = "MuzikIndir";
            this.Load += new System.EventHandler(this.MuzikIndir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_UstBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_UstBanner;
        private System.Windows.Forms.ComboBox Combo_AnimeAd;
        private System.Windows.Forms.ComboBox Combo_SarkiAd;
        private MetroFramework.Controls.MetroButton BTN_Kontrol;
        private MetroFramework.Controls.MetroButton BTN_Indir;
        private MetroFramework.Controls.MetroButton BTN_Geri;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}