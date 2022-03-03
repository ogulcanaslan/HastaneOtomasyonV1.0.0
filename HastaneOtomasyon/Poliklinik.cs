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
    public partial class Poliklinik : Form
    {
        public Poliklinik()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Server = .;Database=Hastane;uid=sa;pwd=11072010");
        private void Poliklinik_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = Baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "GetirPoliklinik";

            SqlDataReader dr;
            Baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboPolNoArama.Items.Add(dr["PolNo"]);
                comboSil.Items.Add(dr["PolNo"]);
            }
            Baglanti.Close();


            lblPolAd.Visible = false;
            txtPolAd.Visible = false;
            lblBasHemsire.Visible = false;
            txtpolBasHem.Visible = false;
            lblPolBas.Visible = false;
            txtPolBas.Visible = false;     
            lblUzSayi.Visible = false;
            nmrUzmanSayisi.Visible = false;
            lblYatakSay.Visible = false;
            nmrYatakSay.Visible = false;
            btnEkle.Visible = false;



            lblPolAdiArama.Visible = false;
            txtPolAdArama.Visible = false;
            lblPolNoArama.Visible = false;
            //txtPolNoArama.Visible = false;
            comboPolNoArama.Visible = false;
            btnAra.Visible = false;


            lblPolNo.Visible = false;
            //txtPolNoSil.Visible = false;
            comboSil.Visible = false;
            btnSil.Visible = false;


            dataGridView1.Visible = false;

            btnGuncelle.Visible = false;

        }





        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }

        private void poliklinikEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblPolAd.Visible = true;
            txtPolAd.Visible = true;
            lblBasHemsire.Visible = true;
            txtpolBasHem.Visible = true;
            lblPolBas.Visible = true;
            txtPolBas.Visible = true;
            lblUzSayi.Visible = true;
            nmrUzmanSayisi.Visible = true;
            lblYatakSay.Visible = true;
            nmrYatakSay.Visible = true;
            btnEkle.Visible = true;

            btnGuncelle.Visible = false;

            lblPolAdiArama.Visible = false;
            txtPolAdArama.Visible = false;
            lblPolNoArama.Visible = false;
            //txtPolNoArama.Visible = false;
            comboPolNoArama.Visible = false;
            btnAra.Visible = false;


            lblPolNo.Visible = false;
            comboSil.Visible = false;
            //txtPolNoSil.Visible = false;
            btnSil.Visible = false;
        }

        private void poliklinikSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lblPolAd.Visible = false;
            txtPolAd.Visible = false;
            lblBasHemsire.Visible = false;
            txtpolBasHem.Visible = false;
            lblPolBas.Visible = false;
            txtPolBas.Visible = false;
            lblUzSayi.Visible = false;
            nmrUzmanSayisi.Visible = false;
            lblYatakSay.Visible = false;
            nmrYatakSay.Visible = false;
            btnEkle.Visible = false;

            btnGuncelle.Visible = false;

            lblPolAdiArama.Visible = false;
            txtPolAdArama.Visible = false;
            lblPolNoArama.Visible = false;
            //txtPolNoArama.Visible = false;
            comboPolNoArama.Visible = false;
            comboPolNoArama.Visible = false;
            btnAra.Visible = false;


            lblPolNo.Visible = true;
            comboSil.Visible = true;
            //txtPolNoSil.Visible = true;
            btnSil.Visible = true;


            dataGridView1.Visible = false;
        }

        private void poliklinikListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PoliklinikListele";
            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
            dataGridView1.Visible = true;

            lblPolAd.Visible = true;
            txtPolAd.Visible = true;
            lblBasHemsire.Visible = true;
            txtpolBasHem.Visible = true;
            lblPolBas.Visible = true;
            txtPolBas.Visible = true;
            lblUzSayi.Visible = true;
            nmrUzmanSayisi.Visible = true;
            lblYatakSay.Visible = true;
            nmrYatakSay.Visible = true;
            btnEkle.Visible = false;

            btnGuncelle.Visible = true;



            lblPolAdiArama.Visible = false;
            txtPolAdArama.Visible = false;
            lblPolNoArama.Visible = false;
            //txtPolNoArama.Visible = false;
            comboPolNoArama.Visible = false;
            comboPolNoArama.Visible = false;
            btnAra.Visible = false;


            lblPolNo.Visible = false;
            comboSil.Visible = false;
            //txtPolNoSil.Visible = false;
            btnSil.Visible = false;
        }

        private void poliklinikAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPolAd.Visible = false;
            txtPolAd.Visible = false;
            lblBasHemsire.Visible = false;
            txtpolBasHem.Visible = false;
            lblPolBas.Visible = false;
            txtPolBas.Visible = false;
            lblUzSayi.Visible = false;
            nmrUzmanSayisi.Visible = false;
            lblYatakSay.Visible = false;
            nmrYatakSay.Visible = false;
            btnEkle.Visible = false;

            btnGuncelle.Visible = false;

            lblPolAdiArama.Visible = true;
            txtPolAdArama.Visible = true;
            lblPolNoArama.Visible = true;
            //txtPolNoArama.Visible = true;
            comboPolNoArama.Visible = true;
            btnAra.Visible = true;


            lblPolNo.Visible = false;

            comboSil.Visible = false;
            //txtPolNoSil.Visible = false;
            btnSil.Visible = false;

            dataGridView1.Visible = false;

        }

        private void poliklinikSıralaAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PoliklinikSiralaAZ";
            command.ExecuteNonQuery();
            Baglanti.Close();

            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
            dataGridView1.Visible = true;
        }

        private void poliklinikSıralaZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PoliklinikSiralaZA";
            command.ExecuteNonQuery();
            Baglanti.Close();

            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
            dataGridView1.Visible = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PoliklinikEkle";
            command.Parameters.AddWithValue("PolAdi", txtPolAd.Text);
            command.Parameters.AddWithValue("PolUzmSayisi", nmrUzmanSayisi.Text);
            command.Parameters.AddWithValue("PolBaskani", txtPolBas.Text);
            command.Parameters.AddWithValue("PolBasHemsire", txtpolBasHem.Text);

            command.Parameters.AddWithValue("PolYatakSayisi", nmrYatakSay.Text);
            
            command.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Bilgiler Kaydedildi");
            MListele();
        }

        public void MListele()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PoliklinikListele";
            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
            dataGridView1.Visible = true;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Baglanti.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PoliklinikAra";
            command.Parameters.AddWithValue("PolNo", comboPolNoArama.Text);
            command.Parameters.AddWithValue("PolAdi", txtPolAdArama.Text);
            Baglanti.Close();

            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Polikliniği Silmek İstiyor musunuz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                Baglanti.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = Baglanti;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "PoliklinikSil";
                command.Parameters.AddWithValue("PolNo", comboSil.Text);
                command.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Poliklinik Başarıyla Silindi");
                MListele();

            }
            else if (secenek == DialogResult.No)
            {

            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            string polNo = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            string polAd = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            string PolUzSayisi = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            string PolBaskani = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            string PolBasHems = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            string PolYatakSayisi = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            txtPolAd.Tag = polNo;
            txtPolAd.Text = polAd;
            nmrUzmanSayisi.Text = PolUzSayisi;
            txtPolBas.Text = PolBaskani;
            txtpolBasHem.Text = PolBasHems;
            nmrYatakSay.Text = PolYatakSayisi;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGiris go = new KullaniciGiris();
            go.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Polikliniği Güncellemek İstiyor musunuz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                Baglanti.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = Baglanti;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "PoliklinikGuncelle";
                command.Parameters.AddWithValue("PolNo", txtPolAd.Tag);

                command.Parameters.AddWithValue("PolAdi", txtPolAd.Text);
                command.Parameters.AddWithValue("PolUzmSayisi", nmrUzmanSayisi.Text);
                command.Parameters.AddWithValue("PolBaskani", txtPolBas.Text);
                command.Parameters.AddWithValue("PolBasHemsire", txtpolBasHem.Text);

                command.Parameters.AddWithValue("PolYatakSayisi", nmrYatakSay.Text);

                command.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Bilgiler Kaydedildi");
                MListele();

            }
            else if (secenek == DialogResult.No)
            {

            }


            
        }
    }
}
