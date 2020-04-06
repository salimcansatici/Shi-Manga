using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MuzikIndir : MetroForm
    {
        public MuzikIndir()
        {
            InitializeComponent();
        }

        private void MuzikIndir_Load(object sender, EventArgs e)
        {

        }

        private void Combo_AnimeAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_AnimeAd.Text == "Fullmetal Alchemist")
            {
                Combo_SarkiAd.Items.Add("Yui - Again");
              Combo_SarkiAd.Items.Add("");
            }
        }

        private void Combo_SarkiAd_SelectedIndexChanged(object sender, EventArgs e)
        {
           BTN_Kontrol.Visible = true;
        }

        private void BTN_SarkiKontrol_Click(object sender, EventArgs e)
        {
           
        }

        private void BTN_Geri_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Kontrol_Click(object sender, EventArgs e)
        {
            if (Combo_SarkiAd.Text == "Yui - Again")
            {
                MessageBox.Show("Yui seçtin");

                webBrowser1.Document.GetElementById("convertUrl").InnerText = "https://www.youtube.com/watch?v=2uq34TeWEdQ";
                foreach (HtmlElement item in webBrowser1.Document.All) // "2conv" sitesinde convert butonu için bu kodu buldum
                {
                    if (item.GetAttribute("classname") == "button large convert orange")
                    {

                        item.InvokeMember("click");
                        BTN_Indir.Visible = true;

                    }


                }
            }
        }

        private void BTN_Indir_Click(object sender, EventArgs e)
        {
            foreach (HtmlElement item in webBrowser1.Document.All) // "2conv" sitesinde convert butonu için bu kodu buldum
            {
                if (item.GetAttribute("classname") == "button large orange track download")
                {
                    //pictureBox1.Visible = false;
                    //timer1.Stop();
                    item.InvokeMember("click");
                }
            }
        }
    }
    }
    
