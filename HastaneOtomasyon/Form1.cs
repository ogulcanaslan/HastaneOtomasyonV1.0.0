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
    public partial class Form1 : Form
    {


        SqlConnection Baglanti = new SqlConnection("Server = .;Database=Hastane;uid=sa;pwd=11072010");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString()== "Hasta Giriş Ekranı")
            {
                Hasta go = new Hasta();
                go.Show();
                this.Hide();
            }
            if (comboBox1.SelectedItem.ToString() == "Doktorlar")
            {
                Doktor go = new Doktor();
                go.Show();
                this.Hide();
            }
            if (comboBox1.SelectedItem.ToString() == "Poliklinikler")
            {
                Poliklinik go = new Poliklinik();
                go.Show();
                this.Hide();
            }
            if (comboBox1.SelectedItem.ToString() == "Raporlama")
            {
                Raporlar go = new Raporlar();
                go.Show();
                this.Hide();
            }

        }
    }
}
