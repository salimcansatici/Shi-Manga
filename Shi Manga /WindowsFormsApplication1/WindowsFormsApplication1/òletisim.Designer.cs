namespace WindowsFormsApplication1
{
    partial class İletisim
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
            this.ArkaKartvizit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArkaKartvizit)).BeginInit();
            this.SuspendLayout();
            // 
            // ArkaKartvizit
            // 
            this.ArkaKartvizit.Location = new System.Drawing.Point(23, 33);
            this.ArkaKartvizit.Name = "ArkaKartvizit";
            this.ArkaKartvizit.Size = new System.Drawing.Size(547, 291);
            this.ArkaKartvizit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArkaKartvizit.TabIndex = 0;
            this.ArkaKartvizit.TabStop = false;
            // 
            // İletisim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 357);
            this.Controls.Add(this.ArkaKartvizit);
            this.Name = "İletisim";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            //this.Load += new System.EventHandler(this.Hakkinda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArkaKartvizit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ArkaKartvizit;
    }
}