namespace Launcher
{
    partial class Hakkinda
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
            this.sdaad = new MetroFramework.Controls.MetroTabControl();
            this.ssadad = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.sdaad.SuspendLayout();
            this.ssadad.SuspendLayout();
            this.SuspendLayout();
            // 
            // sdaad
            // 
            this.sdaad.Controls.Add(this.ssadad);
            this.sdaad.Location = new System.Drawing.Point(23, 17);
            this.sdaad.Multiline = true;
            this.sdaad.Name = "sdaad";
            this.sdaad.SelectedIndex = 0;
            this.sdaad.Size = new System.Drawing.Size(515, 342);
            this.sdaad.TabIndex = 2;
            this.sdaad.UseSelectable = true;
            // 
            // ssadad
            // 
            this.ssadad.Controls.Add(this.metroLabel1);
            this.ssadad.HorizontalScrollbarBarColor = true;
            this.ssadad.HorizontalScrollbarHighlightOnWheel = false;
            this.ssadad.HorizontalScrollbarSize = 10;
            this.ssadad.Location = new System.Drawing.Point(4, 38);
            this.ssadad.Name = "ssadad";
            this.ssadad.Size = new System.Drawing.Size(507, 300);
            this.ssadad.TabIndex = 0;
            this.ssadad.Text = "Program Hakkında";
            this.ssadad.VerticalScrollbarBarColor = true;
            this.ssadad.VerticalScrollbarHighlightOnWheel = false;
            this.ssadad.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // Hakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 382);
            this.Controls.Add(this.sdaad);
            this.Name = "Hakkinda";
            this.Load += new System.EventHandler(this.Context_Hakkinda_Load);
            this.sdaad.ResumeLayout(false);
            this.ssadad.ResumeLayout(false);
            this.ssadad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl sdaad;
        private MetroFramework.Controls.MetroTabPage ssadad;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}