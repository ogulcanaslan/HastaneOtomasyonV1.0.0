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
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Server = .;Database=Hastane;uid=sa;pwd=11072010");
        public void MListele()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DoktorListele";
            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
            dataGridView1.Visible = true;
        }
        private void Doktor_Load(object sender, EventArgs e)
        {


            SqlCommand komut = new SqlCommand();
            komut.Connection = Baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "GetirDoktor";

            SqlDataReader dr;
            Baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                
                comboBox1.Items.Add(dr["DokNo"]);
                comboDoktorSil.Items.Add(dr["DokNo"]);
            }
            Baglanti.Close();

            //Doktor Ekle
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            txtDokAd.Visible = false;
            txtDokTC.Visible = false;
            txtDokUnv.Visible = false;
            txtDokUzmAlan.Visible = false;
            rTxtDokAdres.Visible = false;
            dttmDokDogumTrh.Visible = false;
            mskdDokTelf.Visible = false;
            nmrcDokPolNo.Visible = false;

            btnDokKydt.Visible = false;

            


            dataGridView1.Visible = false;


            //Doktor Silme
            dokNo.Visible = false;
            //txtSilmeDokNo.Visible = false;
            comboDoktorSil.Visible = false;
            DokSil.Visible = false;


            //Doktor Arama
            lblDokAdi.Visible = false;
            lblDokNo.Visible = false;
            btnAra.Visible = false;
            comboBox1.Visible = false;

            
            textBox1.Visible = false;

            btnGuncel.Visible = false;


        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }

        private void poliklinikEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            txtDokAd.Visible = true;
            txtDokTC.Visible = true;
            txtDokUnv.Visible = true;
            txtDokUzmAlan.Visible = true;
            rTxtDokAdres.Visible = true;
            dttmDokDogumTrh.Visible = true;
            mskdDokTelf.Visible = true;
            nmrcDokPolNo.Visible = true;

            btnDokKydt.Visible = true;



            //########
            dataGridView1.Visible = false;


            //Doktor Silme
            dokNo.Visible = false;
            //txtSilmeDokNo.Visible = false;
            comboDoktorSil.Visible = false;
            DokSil.Visible = false;


            //Doktor Arama
            lblDokAdi.Visible = false;
            lblDokNo.Visible = false;
            btnAra.Visible = false;
            
            comboBox1.Visible = false;
            textBox1.Visible = false;


            btnGuncel.Visible = false;

        }

        private void poliklinikSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            txtDokAd.Visible = false;
            txtDokTC.Visible = false;
            txtDokUnv.Visible = false;
            txtDokUzmAlan.Visible = false;
            rTxtDokAdres.Visible = false;
            dttmDokDogumTrh.Visible = false;
            mskdDokTelf.Visible = false;
            nmrcDokPolNo.Visible = false;

            btnDokKydt.Visible = false;



            //########
            dataGridView1.Visible = false;


            //Doktor Silme
            dokNo.Visible = true;
            //txtSilmeDokNo.Visible = true;
            comboDoktorSil.Visible = true;
            DokSil.Visible = true;


            //Doktor Arama
            lblDokAdi.Visible = false;
            lblDokNo.Visible = false;
            btnAra.Visible = false;
            
            comboBox1.Visible = false;
            textBox1.Visible = false;


            btnGuncel.Visible = false;
        }


        //Tamamlandı
        private void poliklinikListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DoktorListele";
            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
            dataGridView1.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            txtDokAd.Visible = true;
            txtDokTC.Visible = true;
            txtDokUnv.Visible = true;
            txtDokUzmAlan.Visible = true;
            rTxtDokAdres.Visible = true;
            dttmDokDogumTrh.Visible = true;
            mskdDokTelf.Visible = true;
            nmrcDokPolNo.Visible = true;

            btnDokKydt.Visible = false;

            dokNo.Visible = false;
            //txtSilmeDokNo.Visible = false;
            comboDoktorSil.Visible = false;
            DokSil.Visible = false;


            //Doktor Arama
            lblDokAdi.Visible = false;
            lblDokNo.Visible = false;
            btnAra.Visible = false;
            comboBox1.Visible = false;
            
            textBox1.Visible = false;


            btnGuncel.Visible = true;
        }


        //Tamamlandı
        private void poliklinikAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            txtDokAd.Visible = false;
            txtDokTC.Visible = false;
            txtDokUnv.Visible = false;
            txtDokUzmAlan.Visible = false;
            rTxtDokAdres.Visible = false;
            dttmDokDogumTrh.Visible = false;
            mskdDokTelf.Visible = false;
            nmrcDokPolNo.Visible = false;

            btnDokKydt.Visible = false;



            //########
            dataGridView1.Visible = false;


            //Doktor Silme
            dokNo.Visible = false;
            //txtSilmeDokNo.Visible = false;
            comboDoktorSil.Visible = false;
            DokSil.Visible = false;


            //Doktor Arama
            lblDokAdi.Visible = true;
            lblDokNo.Visible = true;
            btnAra.Visible = true;
            comboBox1.Visible = true;
           
            textBox1.Visible = true;

            btnGuncel.Visible = false;


        }
        //Tamamlandı
        private void poliklinikSıralaAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DoktorSiralaAZ";
            command.ExecuteNonQuery();
            Baglanti.Close();

            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
            dataGridView1.Visible = true;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            txtDokAd.Visible = false;
            txtDokTC.Visible = false;
            txtDokUnv.Visible = false;
            txtDokUzmAlan.Visible = false;
            rTxtDokAdres.Visible = false;
            dttmDokDogumTrh.Visible = false;
            mskdDokTelf.Visible = false;
            nmrcDokPolNo.Visible = false;

            btnDokKydt.Visible = false;

            dokNo.Visible = false;
            //txtSilmeDokNo.Visible = false;
            comboDoktorSil.Visible = false;
            DokSil.Visible = false;


            //Doktor Arama
            lblDokAdi.Visible = false;
            lblDokNo.Visible = false;
            btnAra.Visible = false;
            comboBox1.Visible = false;
            
            textBox1.Visible = false;

            btnGuncel.Visible = false;
        }

        private void poliklinikSıralaZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DoktorSiralaZA";
            command.ExecuteNonQuery();
            Baglanti.Close();

            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
            dataGridView1.Visible = true;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            txtDokAd.Visible = false;
            txtDokTC.Visible = false;
            txtDokUnv.Visible = false;
            txtDokUzmAlan.Visible = false;
            rTxtDokAdres.Visible = false;
            dttmDokDogumTrh.Visible = false;
            mskdDokTelf.Visible = false;
            nmrcDokPolNo.Visible = false;

            btnDokKydt.Visible = false;

            dokNo.Visible = false;
            //txtSilmeDokNo.Visible = false;
            comboDoktorSil.Visible = false;
            DokSil.Visible = false;


            //Doktor Arama
            lblDokAdi.Visible = false;
            lblDokNo.Visible = false;
            btnAra.Visible = false;
           
            comboBox1.Visible = false;
            textBox1.Visible = false;
            dataGridView1.Visible = true;


            btnGuncel.Visible = false;
        }
        //Tamamlandı
        private void DokSil_Click(object sender, EventArgs e)
        {

            DialogResult secenek = MessageBox.Show("Doktoru Silmek İstiyor musunuz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {

                Baglanti.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = Baglanti;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DoktorSil";
                command.Parameters.AddWithValue("DokNo", comboDoktorSil.Text);
                command.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Doktor Başarıyla Silindi");
                MListele();
                
            }
            else if (secenek == DialogResult.No)
            {

            }

            
        }


        //Tamamolandı
        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Baglanti.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DoktorArama";
            command.Parameters.AddWithValue("DokNo", comboBox1.Text);
            command.Parameters.AddWithValue("DokAdSoyad", textBox1.Text);
            Baglanti.Close();

            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
            
        }



        //Tamamlandı
        private void btnDokKydt_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DoktorEkle";
            command.Parameters.AddWithValue("DokAdSoyad", txtDokAd.Text);
            command.Parameters.AddWithValue("DokTC", txtDokTC.Text);
            command.Parameters.AddWithValue("DokUzmAlani", txtDokUzmAlan.Text);
            command.Parameters.AddWithValue("DokUvan", txtDokUnv.Text);
        
            command.Parameters.AddWithValue("DokTelefon", mskdDokTelf.Text);
            command.Parameters.AddWithValue("DokAdres", rTxtDokAdres.Text);
            command.Parameters.AddWithValue("DokDogumTarihi", dttmDokDogumTrh.Value);
            command.Parameters.AddWithValue("PolNo", nmrcDokPolNo.Text);
            command.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Bilgiler Kaydedildi");
            MListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sectim = dataGridView1.SelectedCells[0].RowIndex;
            string DokNo = dataGridView1.Rows[sectim].Cells[0].Value.ToString();
            string adSoyad = dataGridView1.Rows[sectim].Cells[1].Value.ToString();
            string TC = dataGridView1.Rows[sectim].Cells[2].Value.ToString();
            string UzmanlıkAlan = dataGridView1.Rows[sectim].Cells[3].Value.ToString();
            string unvan = dataGridView1.Rows[sectim].Cells[4].Value.ToString();
            string Telefon = dataGridView1.Rows[sectim].Cells[5].Value.ToString();
            string adres = dataGridView1.Rows[sectim].Cells[6].Value.ToString();
            string dogumTarihi = dataGridView1.Rows[sectim].Cells[7].Value.ToString();
            string poliklinikNo = dataGridView1.Rows[sectim].Cells[8].Value.ToString();

            
            txtDokAd.Tag = DokNo;
            txtDokAd.Text = adSoyad;
            txtDokTC.Text = TC;
            txtDokUzmAlan.Text = UzmanlıkAlan;
            txtDokUnv.Text = unvan;
            mskdDokTelf.Text = Telefon;
            rTxtDokAdres.Text = adres;
            dttmDokDogumTrh.Text = dogumTarihi;
            nmrcDokPolNo.Text = poliklinikNo;
            
            
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {

            DialogResult secenek = MessageBox.Show("Doktoru Güncellemek İstiyor musunuz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {

                Baglanti.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = Baglanti;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DoktorGuncelle";
                command.Parameters.AddWithValue("DokNo", txtDokAd.Tag);
                //command.Parameters.AddWithValue("DokNo", textBox2.Text);
                command.Parameters.AddWithValue("DokAdSoyad", txtDokAd.Text);
                command.Parameters.AddWithValue("DokTC", txtDokTC.Text);
                command.Parameters.AddWithValue("DokUzmAlani", txtDokUzmAlan.Text);
                command.Parameters.AddWithValue("DokUvan", txtDokUnv.Text);

                command.Parameters.AddWithValue("DokTelefon", mskdDokTelf.Text);
                command.Parameters.AddWithValue("DokAdres", rTxtDokAdres.Text);
                command.Parameters.AddWithValue("DokDogumTarihi", dttmDokDogumTrh.Value);
                command.Parameters.AddWithValue("PolNo", nmrcDokPolNo.Text);
                command.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Bilgiler Kaydedildi");
                MListele();
            }
            else if (secenek == DialogResult.No)
            {



            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGiris go = new KullaniciGiris();
            go.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }
    }
}
