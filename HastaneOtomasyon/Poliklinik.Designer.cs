
namespace HastaneOtomasyon
{
    partial class Poliklinik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poliklinik));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikSıralaAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikSıralaZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPolAd = new System.Windows.Forms.Label();
            this.lblUzSayi = new System.Windows.Forms.Label();
            this.lblPolBas = new System.Windows.Forms.Label();
            this.lblBasHemsire = new System.Windows.Forms.Label();
            this.lblYatakSay = new System.Windows.Forms.Label();
            this.txtPolAd = new System.Windows.Forms.TextBox();
            this.txtPolBas = new System.Windows.Forms.TextBox();
            this.txtpolBasHem = new System.Windows.Forms.TextBox();
            this.nmrUzmanSayisi = new System.Windows.Forms.NumericUpDown();
            this.nmrYatakSay = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPolNo = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblPolNoArama = new System.Windows.Forms.Label();
            this.lblPolAdiArama = new System.Windows.Forms.Label();
            this.txtPolAdArama = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.comboPolNoArama = new System.Windows.Forms.ComboBox();
            this.comboSil = new System.Windows.Forms.ComboBox();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUzmanSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYatakSay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.poliklinikEkleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1099, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.anaSayfaToolStripMenuItem_Click);
            // 
            // poliklinikEkleToolStripMenuItem
            // 
            this.poliklinikEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poliklinikEkleToolStripMenuItem1,
            this.poliklinikSilToolStripMenuItem,
            this.poliklinikListeleToolStripMenuItem,
            this.poliklinikAraToolStripMenuItem,
            this.poliklinikSıralaAZToolStripMenuItem,
            this.poliklinikSıralaZAToolStripMenuItem});
            this.poliklinikEkleToolStripMenuItem.Name = "poliklinikEkleToolStripMenuItem";
            this.poliklinikEkleToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.poliklinikEkleToolStripMenuItem.Text = "Poliklinik";
            // 
            // poliklinikEkleToolStripMenuItem1
            // 
            this.poliklinikEkleToolStripMenuItem1.Name = "poliklinikEkleToolStripMenuItem1";
            this.poliklinikEkleToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.poliklinikEkleToolStripMenuItem1.Text = "Poliklinik Ekle";
            this.poliklinikEkleToolStripMenuItem1.Click += new System.EventHandler(this.poliklinikEkleToolStripMenuItem1_Click);
            // 
            // poliklinikSilToolStripMenuItem
            // 
            this.poliklinikSilToolStripMenuItem.Name = "poliklinikSilToolStripMenuItem";
            this.poliklinikSilToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.poliklinikSilToolStripMenuItem.Text = "Poliklinik Sil";
            this.poliklinikSilToolStripMenuItem.Click += new System.EventHandler(this.poliklinikSilToolStripMenuItem_Click);
            // 
            // poliklinikListeleToolStripMenuItem
            // 
            this.poliklinikListeleToolStripMenuItem.Name = "poliklinikListeleToolStripMenuItem";
            this.poliklinikListeleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.poliklinikListeleToolStripMenuItem.Text = "Poliklinik Listele";
            this.poliklinikListeleToolStripMenuItem.Click += new System.EventHandler(this.poliklinikListeleToolStripMenuItem_Click);
            // 
            // poliklinikAraToolStripMenuItem
            // 
            this.poliklinikAraToolStripMenuItem.Name = "poliklinikAraToolStripMenuItem";
            this.poliklinikAraToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.poliklinikAraToolStripMenuItem.Text = "Poliklinik Ara";
            this.poliklinikAraToolStripMenuItem.Click += new System.EventHandler(this.poliklinikAraToolStripMenuItem_Click);
            // 
            // poliklinikSıralaAZToolStripMenuItem
            // 
            this.poliklinikSıralaAZToolStripMenuItem.Name = "poliklinikSıralaAZToolStripMenuItem";
            this.poliklinikSıralaAZToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.poliklinikSıralaAZToolStripMenuItem.Text = "Poliklinik Sırala (A_Z)";
            this.poliklinikSıralaAZToolStripMenuItem.Click += new System.EventHandler(this.poliklinikSıralaAZToolStripMenuItem_Click);
            // 
            // poliklinikSıralaZAToolStripMenuItem
            // 
            this.poliklinikSıralaZAToolStripMenuItem.Name = "poliklinikSıralaZAToolStripMenuItem";
            this.poliklinikSıralaZAToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.poliklinikSıralaZAToolStripMenuItem.Text = "PoliklinikSırala (Z_A)";
            this.poliklinikSıralaZAToolStripMenuItem.Click += new System.EventHandler(this.poliklinikSıralaZAToolStripMenuItem_Click);
            // 
            // lblPolAd
            // 
            this.lblPolAd.AutoSize = true;
            this.lblPolAd.Location = new System.Drawing.Point(75, 59);
            this.lblPolAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPolAd.Name = "lblPolAd";
            this.lblPolAd.Size = new System.Drawing.Size(84, 16);
            this.lblPolAd.TabIndex = 1;
            this.lblPolAd.Text = "Poliklinik Adı";
            // 
            // lblUzSayi
            // 
            this.lblUzSayi.AutoSize = true;
            this.lblUzSayi.Location = new System.Drawing.Point(75, 121);
            this.lblUzSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUzSayi.Name = "lblUzSayi";
            this.lblUzSayi.Size = new System.Drawing.Size(90, 16);
            this.lblUzSayi.TabIndex = 2;
            this.lblUzSayi.Text = "Uzman Sayısı";
            // 
            // lblPolBas
            // 
            this.lblPolBas.AutoSize = true;
            this.lblPolBas.Location = new System.Drawing.Point(75, 183);
            this.lblPolBas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPolBas.Name = "lblPolBas";
            this.lblPolBas.Size = new System.Drawing.Size(113, 16);
            this.lblPolBas.TabIndex = 3;
            this.lblPolBas.Text = "Poliklinik Başkanı";
            // 
            // lblBasHemsire
            // 
            this.lblBasHemsire.AutoSize = true;
            this.lblBasHemsire.Location = new System.Drawing.Point(75, 244);
            this.lblBasHemsire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasHemsire.Name = "lblBasHemsire";
            this.lblBasHemsire.Size = new System.Drawing.Size(152, 16);
            this.lblBasHemsire.TabIndex = 4;
            this.lblBasHemsire.Text = "Poliklinik Baş Hemşiresi";
            // 
            // lblYatakSay
            // 
            this.lblYatakSay.AutoSize = true;
            this.lblYatakSay.Location = new System.Drawing.Point(75, 309);
            this.lblYatakSay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYatakSay.Name = "lblYatakSay";
            this.lblYatakSay.Size = new System.Drawing.Size(83, 16);
            this.lblYatakSay.TabIndex = 5;
            this.lblYatakSay.Text = "Yatak Sayısı";
            // 
            // txtPolAd
            // 
            this.txtPolAd.Location = new System.Drawing.Point(240, 55);
            this.txtPolAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPolAd.Name = "txtPolAd";
            this.txtPolAd.Size = new System.Drawing.Size(132, 22);
            this.txtPolAd.TabIndex = 7;
            // 
            // txtPolBas
            // 
            this.txtPolBas.Location = new System.Drawing.Point(240, 180);
            this.txtPolBas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPolBas.Name = "txtPolBas";
            this.txtPolBas.Size = new System.Drawing.Size(132, 22);
            this.txtPolBas.TabIndex = 9;
            // 
            // txtpolBasHem
            // 
            this.txtpolBasHem.Location = new System.Drawing.Point(240, 240);
            this.txtpolBasHem.Margin = new System.Windows.Forms.Padding(4);
            this.txtpolBasHem.Name = "txtpolBasHem";
            this.txtpolBasHem.Size = new System.Drawing.Size(132, 22);
            this.txtpolBasHem.TabIndex = 10;
            // 
            // nmrUzmanSayisi
            // 
            this.nmrUzmanSayisi.Location = new System.Drawing.Point(240, 118);
            this.nmrUzmanSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.nmrUzmanSayisi.Name = "nmrUzmanSayisi";
            this.nmrUzmanSayisi.Size = new System.Drawing.Size(160, 22);
            this.nmrUzmanSayisi.TabIndex = 13;
            // 
            // nmrYatakSay
            // 
            this.nmrYatakSay.Location = new System.Drawing.Point(227, 306);
            this.nmrYatakSay.Margin = new System.Windows.Forms.Padding(4);
            this.nmrYatakSay.Name = "nmrYatakSay";
            this.nmrYatakSay.Size = new System.Drawing.Size(160, 22);
            this.nmrYatakSay.TabIndex = 14;
            // 
            // btnEkle
            // 
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Location = new System.Drawing.Point(163, 367);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 28);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(505, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 363);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblPolNo
            // 
            this.lblPolNo.AutoSize = true;
            this.lblPolNo.Location = new System.Drawing.Point(108, 92);
            this.lblPolNo.Name = "lblPolNo";
            this.lblPolNo.Size = new System.Drawing.Size(82, 16);
            this.lblPolNo.TabIndex = 17;
            this.lblPolNo.Text = "Poliklinik No";
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Location = new System.Drawing.Point(163, 141);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 28);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblPolNoArama
            // 
            this.lblPolNoArama.AutoSize = true;
            this.lblPolNoArama.Location = new System.Drawing.Point(108, 199);
            this.lblPolNoArama.Name = "lblPolNoArama";
            this.lblPolNoArama.Size = new System.Drawing.Size(82, 16);
            this.lblPolNoArama.TabIndex = 20;
            this.lblPolNoArama.Text = "Poliklinik No";
            // 
            // lblPolAdiArama
            // 
            this.lblPolAdiArama.AutoSize = true;
            this.lblPolAdiArama.Location = new System.Drawing.Point(108, 228);
            this.lblPolAdiArama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPolAdiArama.Name = "lblPolAdiArama";
            this.lblPolAdiArama.Size = new System.Drawing.Size(84, 16);
            this.lblPolAdiArama.TabIndex = 21;
            this.lblPolAdiArama.Text = "Poliklinik Adı";
            // 
            // txtPolAdArama
            // 
            this.txtPolAdArama.Location = new System.Drawing.Point(227, 225);
            this.txtPolAdArama.Margin = new System.Windows.Forms.Padding(4);
            this.txtPolAdArama.Name = "txtPolAdArama";
            this.txtPolAdArama.Size = new System.Drawing.Size(132, 22);
            this.txtPolAdArama.TabIndex = 23;
            // 
            // btnAra
            // 
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.Location = new System.Drawing.Point(163, 277);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 28);
            this.btnAra.TabIndex = 24;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // comboPolNoArama
            // 
            this.comboPolNoArama.FormattingEnabled = true;
            this.comboPolNoArama.Location = new System.Drawing.Point(227, 196);
            this.comboPolNoArama.Name = "comboPolNoArama";
            this.comboPolNoArama.Size = new System.Drawing.Size(121, 24);
            this.comboPolNoArama.TabIndex = 25;
            // 
            // comboSil
            // 
            this.comboSil.FormattingEnabled = true;
            this.comboSil.Location = new System.Drawing.Point(227, 89);
            this.comboSil.Name = "comboSil";
            this.comboSil.Size = new System.Drawing.Size(121, 24);
            this.comboSil.TabIndex = 26;
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(163, 402);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(79, 28);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Poliklinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 554);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.comboSil);
            this.Controls.Add(this.comboPolNoArama);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtPolAdArama);
            this.Controls.Add(this.lblPolAdiArama);
            this.Controls.Add(this.lblPolNoArama);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblPolNo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nmrYatakSay);
            this.Controls.Add(this.nmrUzmanSayisi);
            this.Controls.Add(this.txtpolBasHem);
            this.Controls.Add(this.txtPolBas);
            this.Controls.Add(this.txtPolAd);
            this.Controls.Add(this.lblYatakSay);
            this.Controls.Add(this.lblBasHemsire);
            this.Controls.Add(this.lblPolBas);
            this.Controls.Add(this.lblUzSayi);
            this.Controls.Add(this.lblPolAd);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Poliklinik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poliklinik";
            this.Load += new System.EventHandler(this.Poliklinik_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUzmanSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYatakSay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem poliklinikSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikSıralaAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikSıralaZAToolStripMenuItem;
        private System.Windows.Forms.Label lblPolAd;
        private System.Windows.Forms.Label lblUzSayi;
        private System.Windows.Forms.Label lblPolBas;
        private System.Windows.Forms.Label lblBasHemsire;
        private System.Windows.Forms.Label lblYatakSay;
        private System.Windows.Forms.TextBox txtPolAd;
        private System.Windows.Forms.TextBox txtPolBas;
        private System.Windows.Forms.TextBox txtpolBasHem;
        private System.Windows.Forms.NumericUpDown nmrUzmanSayisi;
        private System.Windows.Forms.NumericUpDown nmrYatakSay;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPolNo;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblPolNoArama;
        private System.Windows.Forms.Label lblPolAdiArama;
        private System.Windows.Forms.TextBox txtPolAdArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox comboPolNoArama;
        private System.Windows.Forms.ComboBox comboSil;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button btnGuncelle;
    }
}