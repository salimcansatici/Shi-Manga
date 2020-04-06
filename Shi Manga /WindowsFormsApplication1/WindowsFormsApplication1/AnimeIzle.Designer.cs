namespace WindowsFormsApplication1
{
    partial class AnimeIzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimeIzle));
            this.Combo_AnimeAd = new System.Windows.Forms.ComboBox();
            this.Combo_AnimeBolum = new System.Windows.Forms.ComboBox();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.ımageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Combo_AnimeAd
            // 
            this.Combo_AnimeAd.FormattingEnabled = true;
            this.Combo_AnimeAd.Items.AddRange(new object[] {
            "Death Note"});
            this.Combo_AnimeAd.Location = new System.Drawing.Point(569, 254);
            this.Combo_AnimeAd.Name = "Combo_AnimeAd";
            this.Combo_AnimeAd.Size = new System.Drawing.Size(156, 21);
            this.Combo_AnimeAd.TabIndex = 1;
            this.Combo_AnimeAd.SelectedIndexChanged += new System.EventHandler(this.Combo_AnimeAd_SelectedIndexChanged);
            // 
            // Combo_AnimeBolum
            // 
            this.Combo_AnimeBolum.FormattingEnabled = true;
            this.Combo_AnimeBolum.Location = new System.Drawing.Point(569, 281);
            this.Combo_AnimeBolum.Name = "Combo_AnimeBolum";
            this.Combo_AnimeBolum.Size = new System.Drawing.Size(156, 21);
            this.Combo_AnimeBolum.TabIndex = 1;
            this.Combo_AnimeBolum.SelectedIndexChanged += new System.EventHandler(this.Combo_AnimeBolum_SelectedIndexChanged);
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(23, 241);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(540, 338);
            this.axShockwaveFlash1.TabIndex = 2;
            // 
            // ımageSlider1
            // 
            this.ımageSlider1.AnimationTime = 1500;
            this.ımageSlider1.CurrentImageIndex = 0;
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images1"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images2"))));
            this.ımageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.ımageSlider1.Location = new System.Drawing.Point(23, 21);
            this.ımageSlider1.Name = "ımageSlider1";
            this.ımageSlider1.Size = new System.Drawing.Size(702, 214);
            this.ımageSlider1.TabIndex = 0;
            this.ımageSlider1.Text = "ımageSlider1";
            this.ımageSlider1.UseDisabledStatePainter = true;
            // 
            // pictureBox1
            // 
           
            this.pictureBox1.Location = new System.Drawing.Point(23, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AnimeIzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 604);
            this.Controls.Add(this.Combo_AnimeBolum);
            this.Controls.Add(this.Combo_AnimeAd);
            this.Controls.Add(this.ımageSlider1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Name = "AnimeIzle";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.AnimeIzle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider1;
        private System.Windows.Forms.ComboBox Combo_AnimeAd;
        private System.Windows.Forms.ComboBox Combo_AnimeBolum;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}