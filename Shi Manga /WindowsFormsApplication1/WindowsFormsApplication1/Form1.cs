using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MetroFramework.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=Salimcan.mdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        int resimindex = 1, maxresim;
        /*
         bi dener misin bakalım projeye eklediğim hiçbir resdim gözükmüyor 
         geldi :) Oh :D
         başka bir şey sildin mi ? hayır silmedim 
         resimler geldiyse diğer sorunlarına bkalım ? resimler gelmedi ki?  resimleri şeyden alıyor ya benim
         programım anime okuma programı çizgi roman okuma programı C deki bir dosyadan veritabanı yardımıyla resim çekiyor
         benim sorunum projeye eklenmiş olan resimlerin kaybolması bulamaması
         hangi formda yok resimler iletisim/ animeizle / anime muzik / KullaniciKayit / kullanicigiris */
        void arttir()


        {
            conn.Open();
            cmd = new OleDbCommand("Update kullanici set Puan=Puan+1 where kimlik="+KullaniciGiris.girenid,conn);
            dr = cmd.ExecuteReader();
            conn.Close();


        

    }
        
        void islem()
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand("Select "+metroComboBox1.Text+" From Mangalar Where Id=@index", conn);
                cmd.Parameters.AddWithValue("@index", resimindex);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pictureBox1.ImageLocation = dr[0].ToString();
                }
                conn.Close();
                dr.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (maxresim > resimindex)
            {
                resimindex++; // resimindex = 1
                islem();
                button1.Enabled = true; // Buton aktif.
                button2.Enabled = true; // Buton aktif.
                if (resimindex == maxresim) // // Resimindex 
                {
                    button1.Enabled = false;
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (resimindex >=1)
            {
                resimindex--;
                islem();
                button1.Enabled = true;
                button2.Enabled = true;
                if (resimindex == 1) 
                {
                    button2.Enabled = false;
                }
            }
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // ordaki reism seni şaşırtmasın abi o ayrı bir şey çalıştırıyor
            conn.Open();
            cmd = new OleDbCommand("Select * From kullanici Where kimlik=@index", conn);
            cmd.Parameters.AddWithValue("@index", KullaniciGiris.girenid);
            dr = cmd.ExecuteReader();


         
            if (dr.Read())

            {
                string id = dr["Puan"].ToString();
                int puan = int.Parse(id);
                if (puan<20)
                {
                    pictureBox2.ImageLocation = @"C:\Shi Manga\Hibi Chouchou\1.jpg";
                }
                if (puan > 20)
                {
                    pictureBox2.ImageLocation = @"C:\Shi Manga\Brand New School\1.jpg";
                }
            }
           

            conn.Close();




            if (metroComboBox1.SelectedText == "Brand New School")
            {
                conn.Open();
                cmd = new OleDbCommand("Select DizinBrand From Mangalar Where Id=@index", conn);
                cmd.Parameters.AddWithValue("@index", resimindex);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pictureBox1.ImageLocation = dr[0].ToString();
                }
                conn.Close();
                dr.Close();
            }
            if (metroComboBox1.SelectedText == "Hibi Chouchou")
            {
                conn.Open();
                cmd = new OleDbCommand("Select Dizinhibi From Mangalar Where Id=@index", conn);
                cmd.Parameters.AddWithValue("@index", resimindex);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pictureBox1.ImageLocation = dr[0].ToString();
                }
                conn.Close();
                dr.Close();
            }

            label1.Text = resimindex.ToString();
            
            maxresim = System.IO.Directory.GetFiles(@"C:\Shi Manga\Brand New School").Length; 
            maxresim = System.IO.Directory.GetFiles(@"C:\Shi Manga\Hibi Chouchou").Length;
            maxresim = System.IO.Directory.GetFiles(@"C:\Shi Manga\A Love story in Moist Rainy Days").Length;
            maxresim = System.IO.Directory.GetFiles(@"C:\Shi Manga\Fullmetal Alchemist").Length;
            maxresim = System.IO.Directory.GetFiles(@"C:\Shi Manga\Die").Length;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            İletisim frm = new İletisim();
            frm.Show();
           
        }
       
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (maxresim > resimindex)
            {
                resimindex++; // resimindex = 1
                arttir();
                islem();

                cmd = new OleDbCommand("Update kullanici set Puan = Puan+1 where id=Kimlik", conn);
                button1.Enabled = true; // Buton aktif.
                button2.Enabled = true; // Buton aktif.
                label1.Text = resimindex.ToString();
                if (resimindex == maxresim) // // Resimindex 
                {
                    button1.Enabled = false;

                    
                }
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
             if (resimindex >=1)
            {
                resimindex--;
                islem();
                button1.Enabled = true;
                button2.Enabled = true;
                label1.Text = resimindex.ToString();
                if (resimindex == 1)
                {
                    button2.Enabled = false;
                }
        }
    }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "|*.exe;";
            dosya.Title = "Shi Manga - Sıfırla";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            MessageBox.Show(DosyaYolu);
            if (true)
            {
                System.Diagnostics.Process.Start(DosyaYolu);

            }
        }

        private void ımageEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
       
        }

        private void ımageSlider1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            islem();
           
            }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void BTN_indir_Click(object sender, EventArgs e)
        {
        }

        private void BTN_SarkiKontrol_Click(object sender, EventArgs e)
        {
           

                    timer1.Start();
                }
            }
        }

        

       

      


       

        
