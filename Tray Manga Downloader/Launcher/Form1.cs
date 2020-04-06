using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


            WebClient webClient = new WebClient(); // Dosyaları indirebilmem için gereken bir kod.
 
            timer1.Enabled = true; // Salimcan.com'da bulunan manga kategorisine yönlendirmek için Timer'ı başlattım.


            NotifyIcon trayIcon = new NotifyIcon();
            notifyIcon1.ShowBalloonTip(1, "Bilgi", "Shi Manga ekibi olarak size teşekkür ederiz...", ToolTipIcon.Info);

            // Nesneyi oluşturuyoruz.

            // Sağ alt köşede olan o küçük simgenin fotoğrafını belirliyoruz.
            notifyIcon1.Icon = new Icon("C:mangalogo.ico");

        // Mouse ile simgenin üzerine gelindiğince belirecek metin
        notifyIcon1.Text = "Shi Manga bileşenleri karşıdan yüklüyor...";

            // Simgeyi görünür hale getir
            notifyIcon1.Visible = true;
            // Yeni bir baloncuk göstermek için
            notifyIcon1.ShowBalloonTip(1, "Bilgi", "Salimcan.com ziyaret ediliyor.", ToolTipIcon.Info);

    
            Directory.CreateDirectory(@"C:\Shi_Manga"); // Resimlerin indirilme dizinini/yerini oluşturuyor.

  

            // "A Love story in Moist Rainy Days" Mangası.
            Directory.CreateDirectory(@"C:\Shi Manga\A Love story in Moist Rainy Days");
        
            for (int a = 1; a < 23; a++)
            {

                if (File.Exists(@"C:\Shi Manga\A Love story in Moist Rainy Days\" + a + ".png") == true) // dizindeki dosya var mı ?
                { 
                    string dosya_dizini = @"C:\Shi Manga\A Love story in Moist Rainy Days\" + a + ".png";
                   
                    //MessageBox.Show(+a + ".Dosya ( A LOVE) Bulundu indirmiyorum. @@@");
                } 
                else
                {
                    webClient.DownloadFile("http://salimcan.com/wp-content/uploads/2016/04/" + a + ".png", @"C:\Shi Manga\A Love story in Moist Rainy Days\" + a + ".png");
                  //  MessageBox.Show(a+"Dosya (a love) Bulunamadı indiriyorum.");
                }


            }



            // "Brand New School" Mangası.
            
            Directory.CreateDirectory(@"C:\Shi Manga\Brand New School");
            for (int brand = 1; brand < 22; brand++)
                {
                    if (File.Exists(@"C:\Shi Manga\Brand New School\" + brand + ".jpg") == true) // dizindeki dosya var mı ?
                    {
                        string dosya_dizini = @"C:\Shi Manga\Brand New School\" + brand + ".jpg";
                   // MessageBox.Show(brand + ".  (BRAND) Dosya Bulundu indirmiyorum. @@@");

                }

              
                else
                {
                        webClient.DownloadFile("https://shimanga.files.wordpress.com/2016/05/" + brand+".jpg", @"C:\Shi Manga\Brand New School\"+brand+".jpg");

                     
                }

            }




            // "Hibi Chouchou" Mangası.

            Directory.CreateDirectory(@"C:\Shi Manga\Hibi Chouchou");
            for (int hibi = 1; hibi < 22; hibi++)
                {
                    if (File.Exists(@"C:\Shi Manga\Hibi Chouchou\" + hibi + ".jpg") == true) // dizindeki dosya var mı ?
                    {
                        string dosya_dizini = @"C:\Shi Manga\Hibi Chouchou\" + hibi + ".jpg";
                   
                    }

                    else
                    {https://shimanga.files.wordpress.com/2016/05/21.jpg
                        webClient.DownloadFile("http://salimcan.com/wp-content/uploads/2016/04/hibi" + hibi + ".jpg", @"C:\Shi Manga\Hibi Chouchou\" + hibi + ".jpg");
                      
                    }
                }

            // "Fullmetal Alchemist" Mangası.
            Directory.CreateDirectory(@"C:\Shi Manga\Fullmetal Alchemist");
            for (int full = 1; full < 53; full++)
            {
                if (File.Exists(@"C:\Shi Manga\Fullmetal Alchemist\" + full + ".jpg") == true) // dizindeki dosya var mı ?
                {
                    string dosya_dizini = @"C:\Shi Manga\Fullmetal Alchemist\" + full + ".jpg";
                   
                }

                else
                {
                   
                    webClient.DownloadFile("https://shimangaa2.files.wordpress.com/2016/05/" + full + ".jpg", @"C:\Shi Manga\Fullmetal Alchemist\" + full + ".jpg");
                   
                }
            }


            // "Die" Mangası.
            Directory.CreateDirectory(@"C:\Shi Manga\Die");
            for (int die = 1; die < 16; die++)
            {
                if (File.Exists(@"C:\Shi Manga\Die\" + die + ".jpg") == true) // dizindeki dosya var mı ?
                {
                    string dosya_dizini = @"C:\Shi Manga\Fullmetal Alchemist\" + die + ".jpg";

                }

                else
                {

                    webClient.DownloadFile("https://shimangaa3.files.wordpress.com/2016/05/" + die + ".jpg", @"C:\Shi Manga\Die\" + die + ".jpg");
                    
                }
            }





           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Hide(); // Formu gizlemek için gereken kod.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            Process.Start("www.salimcan.com"); // Salimcan.com'un manga kategorisi.
            timer1.Enabled = false;

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void programHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Hakkinda yeniform = new Hakkinda();
            yeniform.Show();

        }
    }
}