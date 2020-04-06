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
    public partial class KullaniciKayit : MetroForm
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        private void KullaniciKayit_Load(object sender, EventArgs e)
        {
            
        }
        string vtyolu = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=Salimcan.mdb;Persist Security Info=True";
        private void pictureBox2_Click(object sender, EventArgs e)
        {

           
                int puan = 0;
                MessageBox.Show("Şifreleriniz Uyumludur.", "Şifre Uyumlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OleDbConnection baglanti = new OleDbConnection(vtyolu);
                baglanti.Open();
                string ekle = "insert into kullanici(k_ad,e_mail,sifre,Puan) values (@k_ad,@e_mail,@sifre,@Puan)";

                OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                komut.Parameters.AddWithValue("@k_ad", Txt_Kullaniciadi.Text);
                komut.Parameters.AddWithValue("@e_mail", Txt_Eposta.Text);

                komut.Parameters.AddWithValue("@sifre", Txt_sifre.Text);
                komut.Parameters.AddWithValue("@Puan", puan);

                komut.ExecuteNonQuery();
                baglanti.Close();
            MessageBox.Show("TEBRİKLER");
            
           

        }
    }
}

