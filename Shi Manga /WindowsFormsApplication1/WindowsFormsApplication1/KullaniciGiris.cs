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
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class KullaniciGiris : MetroForm
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public static int girenid = 0;

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string ad = Txt_KullaniciAdi.Text;
            string sifre = Txt_Sifre.Text;
            con = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=Salimcan.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici where k_ad='" + Txt_KullaniciAdi.Text + "' AND sifre='" + Txt_Sifre.Text + "'";
            dr = cmd.ExecuteReader(); 
            if (dr.Read()) 
                
            {
                string id = dr["Kimlik"].ToString();
                girenid = int.Parse(id);
                Form1 f2 = new Form1();
                f2.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            con.Close();

            //sen burda gıren kullanıcın bı ıd sını atmamıssın degıskene id zaten 1 2 3 tamamda sabıtmı yazcan update sorgusuna burda gıren kısının ıd numarasını alman laım 
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            KullaniciKayit f2 = new KullaniciKayit();
            f2.Show();
        }

        private void KullaniciGiris_KeyDown(object sender, KeyEventArgs e)
        {
           
            }
        }
    }

