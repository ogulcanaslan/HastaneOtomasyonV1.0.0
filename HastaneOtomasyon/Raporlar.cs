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
    public partial class Raporlar : Form
    {
        SqlConnection Baglanti = new SqlConnection("Server = .;Database=Hastane;uid=sa;pwd=11072010");
        public Raporlar()
        {
            InitializeComponent();
        }
        //public void MListele()
        //{
        //    SqlCommand command = new SqlCommand();
        //    command.Connection = Baglanti;
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.CommandText = "HastaListle";
        //    SqlDataAdapter gorunutle = new SqlDataAdapter(command);
        //    DataTable doldur = new DataTable();
        //    gorunutle.Fill(doldur);
        //    dataGridView1.DataSource = doldur;
        //    dataGridView1.Visible = true;
        //}
        private void Raporlar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UzmanSayisiOrtalama";
            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
            

            //MListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "YatakAdetGoster";
            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DoktorDogumTarihiveUzmanlikAlaniSiralama";
            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DoktorDogumveUnvanSirala";
            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "HastaKiloOrtalama";
            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "HastaYasOrtalama";
            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Baglanti;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "HastaBoyOrtalaması";
            SqlDataAdapter gorunutle = new SqlDataAdapter(command);
            DataTable doldur = new DataTable();
            gorunutle.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }
    }
}
