using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyon
{
    public partial class KullaniciGiris : Form
    {
        SqlConnection baglan = new SqlConnection("Server = .;Database=Hastane;uid=sa;pwd=11072010");
        

        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {
            grpKayit.Visible = false;
            grpGiris.Visible = true;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "Giris";
            komut.Parameters.AddWithValue("kad", txtKullaniciAdiGiris.Text);
            
            komut.Parameters.AddWithValue("sifre", txtSifreGiris.Text);
            baglan.Open();
            SqlDataReader dr;

            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                
                MessageBox.Show("Terbrikler! Başarılı bir Şekilde Giriş Yaptınız");
                Form1 go = new Form1();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifrenizi Kontrol Ediniz");
                txtKullaniciAdiGiris.Clear();
                txtSifreGiris.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                grpKayit.Visible = true;
            }
            if (checkBox1.Checked == false)
            {
                grpKayit.Visible = false;
            }
            
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if (txtSifreKayıt.Text==txtSifreKayitTekrar.Text)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglan;
                komut.CommandType = CommandType.StoredProcedure;
                komut.CommandText = "UyeEkle";
                komut.Parameters.AddWithValue("kad", txtKullaniciAdiKayit.Text);
                komut.Parameters.AddWithValue("sifre", txtSifreKayıt.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Üye Kaydınız Başarılı");
                grpKayit.Visible = false;
            }
            else
            {
                MessageBox.Show("Girdiğiniz Şifreleri Kontrol Edin");
                
            }
            

            
        }
    }
}
