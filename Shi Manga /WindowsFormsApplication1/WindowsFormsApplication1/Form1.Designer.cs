namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.ContextButton contextButton2 = new DevExpress.Utils.ContextButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.BTN_Sifirla = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.BTN_AnimeIzle = new MetroFramework.Controls.MetroTile();
            this.BTN_AnimeMuzik = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ımageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(686, 522);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(148, 43);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "İletişim";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseStyleColors = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "İleri";
            this.button1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Geri";
            this.button2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button2.UseSelectable = true;
            this.button2.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(246, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 6;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "DizinBrand",
            "DizinHibi",
            "DizinLove",
            "DizinFma",
            "DizinDie"});
            this.metroComboBox1.Location = new System.Drawing.Point(685, 30);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 8;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // BTN_Sifirla
            // 
            this.BTN_Sifirla.ActiveControl = null;
            this.BTN_Sifirla.Location = new System.Drawing.Point(686, 473);
            this.BTN_Sifirla.Name = "BTN_Sifirla";
            this.BTN_Sifirla.Size = new System.Drawing.Size(148, 43);
            this.BTN_Sifirla.Style = MetroFramework.MetroColorStyle.Silver;
            this.BTN_Sifirla.TabIndex = 9;
            this.BTN_Sifirla.Text = "Sıfırla";
            this.BTN_Sifirla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Sifirla.UseSelectable = true;
            this.BTN_Sifirla.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // BTN_AnimeIzle
            // 
            this.BTN_AnimeIzle.ActiveControl = null;
            this.BTN_AnimeIzle.Location = new System.Drawing.Point(686, 416);
            this.BTN_AnimeIzle.Name = "BTN_AnimeIzle";
            this.BTN_AnimeIzle.Size = new System.Drawing.Size(148, 51);
            this.BTN_AnimeIzle.Style = MetroFramework.MetroColorStyle.Lime;
            this.BTN_AnimeIzle.TabIndex = 21;
            this.BTN_AnimeIzle.Text = "Anime İzle";
            this.BTN_AnimeIzle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_AnimeIzle.UseSelectable = true;
          
            // 
            // BTN_AnimeMuzik
            // 
            this.BTN_AnimeMuzik.ActiveControl = null;
            this.BTN_AnimeMuzik.Location = new System.Drawing.Point(684, 361);
            this.BTN_AnimeMuzik.Name = "BTN_AnimeMuzik";
            this.BTN_AnimeMuzik.Size = new System.Drawing.Size(150, 49);
            this.BTN_AnimeMuzik.Style = MetroFramework.MetroColorStyle.Teal;
            this.BTN_AnimeMuzik.TabIndex = 22;
            this.BTN_AnimeMuzik.Text = "Anime Müzikleri İndir";
            this.BTN_AnimeMuzik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_AnimeMuzik.UseSelectable = true;
           
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(23, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // ımageSlider1
            // 
            this.ımageSlider1.AnimationTime = 1000;
            this.ımageSlider1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            contextButton2.Id = new System.Guid("f8a7b57b-7ad1-4b4b-bf27-1bbc5cf3ae3f");
            contextButton2.Name = "ContextButton";
            this.ımageSlider1.ContextButtons.Add(contextButton2);
            this.ımageSlider1.CurrentImageIndex = 0;
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images1"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images2"))));
            this.ımageSlider1.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ımageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.ımageSlider1.Location = new System.Drawing.Point(23, 210);
            this.ımageSlider1.Name = "ımageSlider1";
            this.ımageSlider1.Size = new System.Drawing.Size(239, 355);
            this.ımageSlider1.TabIndex = 12;
            this.ımageSlider1.Text = "ımageSlider1";
            this.ımageSlider1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.ımageSlider1.UseDisabledStatePainter = true;
            this.ımageSlider1.Click += new System.EventHandler(this.ımageSlider1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(286, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 621);
            this.Controls.Add(this.BTN_AnimeMuzik);
            this.Controls.Add(this.BTN_AnimeIzle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ımageSlider1);
            this.Controls.Add(this.BTN_Sifirla);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroButton button2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTile BTN_Sifirla;
        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile BTN_AnimeIzle;
        private MetroFramework.Controls.MetroTile BTN_AnimeMuzik;
    }
}

