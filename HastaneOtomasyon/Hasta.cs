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
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Server = .;Database=Hastane;uid=sa;pwd=11072010");
        public void MListele()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "HastaListle";
            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
            dataGridView1.Visible = true;
        }
        private void Hasta_Load(object sender, EventArgs e)
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
                comboDokNo.Items.Add(dr["DokNo"]);
               
                
            }

            Baglanti.Close();

            lblDokNoEkle.Visible = false;
            //nmrDokNoEkle.Visible = false;
            comboDokNo.Visible = false;
            lblHastaAdEkle.Visible = false;
            txtHastaAdEkle.Visible = false;
            lblHastaRaporDurumuEkle.Visible = false;
            cmbRaporDurumEkle.Visible = false;
            lblHastaReceteEkle.Visible = false;
            txtHastaReceteEkle.Visible = false;
            lblHastBoyekle.Visible = false;
            txtHastBoyEkle.Visible = false;
            lblHastDogumTarihiEkle.Visible = false;
            dateHastaDogTarEKLE.Visible = false;
            lblHastKiloEkle.Visible = false;
            txtHastaKiloEkle.Visible = false;
            lblHastTcEkle.Visible = false;
            txtHastaTCEkle.Visible = false;
            lblHastYasEkle.Visible = false;
            txtHastaYasEkle.Visible = false;
            lblRandevuTarihiEkle.Visible = false;
            dateRandevuTarihEkle.Visible = false;
            btnEkle.Visible = false;


            btnGuncelleHasta.Visible = false;


            lblHastAdArama.Visible = false;
            txtHastaAdArama.Visible = false;
            lblHastNoArama.Visible = false;
            txtHastaNoArama.Visible = false;
            lblHastTCArama.Visible = false;
            txtHastaTCArama.Visible = false;
            btnArama.Visible = false;



            lblHastNoSil.Visible = false;
            txtHastaNoSil.Visible = false;
            //comboHastaSil.Visible = false;
            btnHastaSil.Visible = false;

            dataGridView1.Visible = false;

        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }

        private void poliklinikEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblDokNoEkle.Visible = true;
            //nmrDokNoEkle.Visible = true;
            comboDokNo.Visible = true;
            lblHastaAdEkle.Visible = true;
            txtHastaAdEkle.Visible = true;
            lblHastaRaporDurumuEkle.Visible = true;
            cmbRaporDurumEkle.Visible = true;
            lblHastaReceteEkle.Visible = true;
            txtHastaReceteEkle.Visible = true;
            lblHastBoyekle.Visible = true;
            txtHastBoyEkle.Visible = true;
            lblHastDogumTarihiEkle.Visible = true;
            dateHastaDogTarEKLE.Visible = true;
            lblHastKiloEkle.Visible = true;
            txtHastaKiloEkle.Visible = true;
            lblHastTcEkle.Visible = true;
            txtHastaTCEkle.Visible = true;
            lblHastYasEkle.Visible = true;
            txtHastaYasEkle.Visible = true;
            lblRandevuTarihiEkle.Visible = true;
            dateRandevuTarihEkle.Visible = true;
            btnEkle.Visible = true;

            btnGuncelleHasta.Visible = false;

            lblHastAdArama.Visible = false;
            txtHastaAdArama.Visible = false;
            lblHastNoArama.Visible = false;
            txtHastaNoArama.Visible = false;
            lblHastTCArama.Visible = false;
            txtHastaTCArama.Visible = false;
            btnArama.Visible = false;



            lblHastNoSil.Visible = false;
            txtHastaNoSil.Visible = false;
            //comboHastaSil.Visible = false;
            btnHastaSil.Visible = false;

            dataGridView1.Visible = false;
        }

        private void poliklinikSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "HastaListle";
            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
            dataGridView1.Visible = true;





            lblDokNoEkle.Visible = false;
            //nmrDokNoEkle.Visible = false;
            comboDokNo.Visible = false;
            lblHastaAdEkle.Visible = false;
            txtHastaAdEkle.Visible = false;
            lblHastaRaporDurumuEkle.Visible = false;
            cmbRaporDurumEkle.Visible = false;
            lblHastaReceteEkle.Visible = false;
            txtHastaReceteEkle.Visible = false;
            lblHastBoyekle.Visible = false;
            txtHastBoyEkle.Visible = false;
            lblHastDogumTarihiEkle.Visible = false;
            dateHastaDogTarEKLE.Visible = false;
            lblHastKiloEkle.Visible = false;
            txtHastaKiloEkle.Visible = false;
            lblHastTcEkle.Visible = false;
            txtHastaTCEkle.Visible = false;
            lblHastYasEkle.Visible = false;
            txtHastaYasEkle.Visible = false;
            lblRandevuTarihiEkle.Visible = false;
            dateRandevuTarihEkle.Visible = false;
            btnEkle.Visible = false;
            btnGuncelleHasta.Visible = false;


            lblHastAdArama.Visible = false;
            txtHastaAdArama.Visible = false;
            lblHastNoArama.Visible = false;
            txtHastaNoArama.Visible = false;
            lblHastTCArama.Visible = false;
            txtHastaTCArama.Visible = false;
            btnArama.Visible = false;



            lblHastNoSil.Visible = true;
            txtHastaNoSil.Visible = true;
            //comboHastaSil.Visible = true;
            btnHastaSil.Visible = true;




            //dataGridView1.Visible = false;
        }

        private void poliklinikListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = Baglanti;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "HastaListle";
                SqlDataAdapter gorunutle = new SqlDataAdapter(command);
                DataTable doldur = new DataTable();
                gorunutle.Fill(doldur);
                dataGridView1.DataSource = doldur;
                dataGridView1.Visible = true;


                lblDokNoEkle.Visible = true;
                //nmrDokNoEkle.Visible = true;
                comboDokNo.Visible = true;
                lblHastaAdEkle.Visible = true;
                txtHastaAdEkle.Visible = true;
                lblHastaRaporDurumuEkle.Visible = true;
                cmbRaporDurumEkle.Visible = true;
                lblHastaReceteEkle.Visible = true;
                txtHastaReceteEkle.Visible = true;
                lblHastBoyekle.Visible = true;
                txtHastBoyEkle.Visible = true;
                lblHastDogumTarihiEkle.Visible = true;
                dateHastaDogTarEKLE.Visible = true;
                lblHastKiloEkle.Visible = true;
                txtHastaKiloEkle.Visible = true;
                lblHastTcEkle.Visible = true;
                txtHastaTCEkle.Visible = true;
                lblHastYasEkle.Visible = true;
                txtHastaYasEkle.Visible = true;
                lblRandevuTarihiEkle.Visible = true;
                dateRandevuTarihEkle.Visible = true;
                btnEkle.Visible = false;
                btnGuncelleHasta.Visible = true;


                lblHastAdArama.Visible = false;
                txtHastaAdArama.Visible = false;
                lblHastNoArama.Visible = false;
                txtHastaNoArama.Visible = false;
                lblHastTCArama.Visible = false;
                txtHastaTCArama.Visible = false;
                btnArama.Visible = false;



                lblHastNoSil.Visible = false;
                txtHastaNoSil.Visible = false;
                //comboHastaSil.Visible = false;
                btnHastaSil.Visible = false;
            }
            catch 
            {
                MessageBox.Show("İşlem Başarısız...");
            }
            
        }

        private void poliklinikAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDokNoEkle.Visible = false;
            //nmrDokNoEkle.Visible = false;
            comboDokNo.Visible = false;
            lblHastaAdEkle.Visible = false;
            txtHastaAdEkle.Visible = false;
            lblHastaRaporDurumuEkle.Visible = false;
            cmbRaporDurumEkle.Visible = false;
            lblHastaReceteEkle.Visible = false;
            txtHastaReceteEkle.Visible = false;
            lblHastBoyekle.Visible = false;
            txtHastBoyEkle.Visible = false;
            lblHastDogumTarihiEkle.Visible = false;
            dateHastaDogTarEKLE.Visible = false;
            lblHastKiloEkle.Visible = false;
            txtHastaKiloEkle.Visible = false;
            lblHastTcEkle.Visible = false;
            txtHastaTCEkle.Visible = false;
            lblHastYasEkle.Visible = false;
            txtHastaYasEkle.Visible = false;
            lblRandevuTarihiEkle.Visible = false;
            dateRandevuTarihEkle.Visible = false;
            btnEkle.Visible = false;
            btnGuncelleHasta.Visible = false;


            lblHastAdArama.Visible = true;
            txtHastaAdArama.Visible = true;
            lblHastNoArama.Visible = true;
            txtHastaNoArama.Visible = true;
            lblHastTCArama.Visible = true;
            txtHastaTCArama.Visible = true;
            btnArama.Visible = true;



            lblHastNoSil.Visible = false;
            txtHastaNoSil.Visible = false;
            //comboHastaSil.Visible = false;
            btnHastaSil.Visible = false;

            dataGridView1.Visible = false;
        }

        private void poliklinikSıralaAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Baglanti.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = Baglanti;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "HastaSiralaAZ";
                command.ExecuteNonQuery();
                Baglanti.Close();

                SqlDataAdapter gorunutle = new SqlDataAdapter(command);
                DataTable doldur = new DataTable();
                gorunutle.Fill(doldur);
                dataGridView1.DataSource = doldur;
                dataGridView1.Visible = true;
            }
            catch 
            {
                MessageBox.Show("İşlem Başarısız...");

            }
            
        }

        private void poliklinikSıralaZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Baglanti.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = Baglanti;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "HastaSiralaZA";
                command.ExecuteNonQuery();
                Baglanti.Close();

                SqlDataAdapter gorunutle = new SqlDataAdapter(command);
                DataTable doldur = new DataTable();
                gorunutle.Fill(doldur);
                dataGridView1.DataSource = doldur;
                dataGridView1.Visible = true;
            }
            catch
            {

                MessageBox.Show("İşlem Başarısız...");
            }
            
        }

        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            
            DialogResult secenek = MessageBox.Show("Hastayı Silmek İstiyor musunuz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                Baglanti.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = Baglanti;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "HastSil";
                command.Parameters.AddWithValue("HastNo", txtHastaNoSil.Text);
                command.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Hasta Başarıyla Silindi");
                MListele();

            }
            else if (secenek == DialogResult.No)
            {

            }

            
            
            
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Visible = true;
                Baglanti.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = Baglanti;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "HastaArama";
                command.Parameters.AddWithValue("HastNo", txtHastaNoArama.Text);
                command.Parameters.AddWithValue("HastAdSoyad", txtHastaAdArama.Text);
                command.Parameters.AddWithValue("HastTC", txtHastaTCArama.Text);
                Baglanti.Close();

                SqlDataAdapter gorunutle = new SqlDataAdapter(command);
                DataTable doldur = new DataTable();
                gorunutle.Fill(doldur);
                dataGridView1.DataSource = doldur;
            }
            catch
            {
                MessageBox.Show("Hatalı");
            }

            
           
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {


            try
            {
                Baglanti.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = Baglanti;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "HastaEkle";
                command.Parameters.AddWithValue("HastAdSoyAd", txtHastaAdEkle.Text);
                command.Parameters.AddWithValue("HastTC", txtHastaTCEkle.Text);
                command.Parameters.AddWithValue("HastDogumTarihi", dateHastaDogTarEKLE.Value);
                command.Parameters.AddWithValue("HastBoy", txtHastBoyEkle.Text);
                command.Parameters.AddWithValue("HastKilo", txtHastaKiloEkle.Text);
                command.Parameters.AddWithValue("HastYas", txtHastaYasEkle.Text);
                command.Parameters.AddWithValue("HastRecete", txtHastaReceteEkle.Text);
                command.Parameters.AddWithValue("HastRaporDurumu", cmbRaporDurumEkle.Text);
                command.Parameters.AddWithValue("HastRandevuTarihi", dateRandevuTarihEkle.Value);
                command.Parameters.AddWithValue("DoktorNo", comboDokNo.Text);



                command.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Bilgiler Kaydedildi");
                MListele();
            }
            catch
            {
                MessageBox.Show("hatalı");
                DialogResult secenek = MessageBox.Show("Tekrar Denemek İstiyor Musunuz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    Hasta hasta = new Hasta();
                    this.Hide();
                    hasta.Show();

                }
                else if (secenek == DialogResult.No)
                {

                }

            }




        }
        
       
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGiris go = new KullaniciGiris();
            go.Show();
            this.Hide();
        }

        private void btnGuncelleHasta_Click(object sender, EventArgs e)
        {

            DialogResult secenek = MessageBox.Show("Hastayı Güncellemek İstiyor musunuz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {

                Baglanti.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = Baglanti;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "HastaGuncelle";
                command.Parameters.AddWithValue("HastNo", txtHastaAdEkle.Tag);
                command.Parameters.AddWithValue("HastAdSoyAd", txtHastaAdEkle.Text);
                command.Parameters.AddWithValue("HastTC", txtHastaTCEkle.Text);
                command.Parameters.AddWithValue("HastDogumTarihi", dateHastaDogTarEKLE.Value);
                command.Parameters.AddWithValue("HastBoy", txtHastBoyEkle.Text);
                command.Parameters.AddWithValue("HastKilo", txtHastaKiloEkle.Text);
                command.Parameters.AddWithValue("HastYas", txtHastaYasEkle.Text);
                command.Parameters.AddWithValue("HastRecete", txtHastaReceteEkle.Text);
                command.Parameters.AddWithValue("HastRaporDurumu", cmbRaporDurumEkle.Text);
                command.Parameters.AddWithValue("HastRandevuTarihi", dateRandevuTarihEkle.Value);
                command.Parameters.AddWithValue("DoktorNo", comboDokNo.Text);



                command.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Bilgiler Kaydedildi");
                MListele();

            }
            else if (secenek == DialogResult.No)
            {

            }


            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            string HastNo = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            string HastNoSil = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            string HastAdSoyad = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            string HastTC = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            string HastDogumTarihi = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            string HastBoy = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            string HastKilo = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            string HastYas = dataGridView1.Rows[secim].Cells[6].Value.ToString();
            string HastRecete = dataGridView1.Rows[secim].Cells[7].Value.ToString();
            string HastRaporDurum = dataGridView1.Rows[secim].Cells[8].Value.ToString();
            string HastRandevuTarihi = dataGridView1.Rows[secim].Cells[9].Value.ToString();
            string HastDokNo = dataGridView1.Rows[secim].Cells[10].Value.ToString();
            txtHastaAdEkle.Tag = HastNo;
            txtHastaAdEkle.Text = HastAdSoyad;
            txtHastaTCEkle.Text = HastTC;
            dateHastaDogTarEKLE.Text = HastDogumTarihi;
            txtHastBoyEkle.Text = HastBoy;
            txtHastaKiloEkle.Text = HastKilo;
            txtHastaYasEkle.Text = HastYas;
            txtHastaReceteEkle.Text = HastRecete;
            cmbRaporDurumEkle.Text = HastRaporDurum;
            dateRandevuTarihEkle.Text = HastRandevuTarihi;
            comboDokNo.Text = HastDokNo;


            txtHastaNoSil.Text = HastNoSil;
        }
    }
}
