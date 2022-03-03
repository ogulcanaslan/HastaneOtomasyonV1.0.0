
namespace HastaneOtomasyon
{
    partial class Hasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hasta));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikSıralaAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikSıralaZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHastaAdEkle = new System.Windows.Forms.Label();
            this.lblHastTcEkle = new System.Windows.Forms.Label();
            this.lblHastDogumTarihiEkle = new System.Windows.Forms.Label();
            this.lblHastBoyekle = new System.Windows.Forms.Label();
            this.lblHastKiloEkle = new System.Windows.Forms.Label();
            this.lblHastYasEkle = new System.Windows.Forms.Label();
            this.lblHastaReceteEkle = new System.Windows.Forms.Label();
            this.lblHastaRaporDurumuEkle = new System.Windows.Forms.Label();
            this.lblRandevuTarihiEkle = new System.Windows.Forms.Label();
            this.lblDokNoEkle = new System.Windows.Forms.Label();
            this.txtHastaAdEkle = new System.Windows.Forms.TextBox();
            this.txtHastaTCEkle = new System.Windows.Forms.TextBox();
            this.txtHastBoyEkle = new System.Windows.Forms.TextBox();
            this.txtHastaKiloEkle = new System.Windows.Forms.TextBox();
            this.txtHastaYasEkle = new System.Windows.Forms.TextBox();
            this.txtHastaReceteEkle = new System.Windows.Forms.TextBox();
            this.dateHastaDogTarEKLE = new System.Windows.Forms.DateTimePicker();
            this.dateRandevuTarihEkle = new System.Windows.Forms.DateTimePicker();
            this.cmbRaporDurumEkle = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblHastNoSil = new System.Windows.Forms.Label();
            this.btnHastaSil = new System.Windows.Forms.Button();
            this.lblHastNoArama = new System.Windows.Forms.Label();
            this.lblHastAdArama = new System.Windows.Forms.Label();
            this.lblHastTCArama = new System.Windows.Forms.Label();
            this.txtHastaNoArama = new System.Windows.Forms.TextBox();
            this.txtHastaAdArama = new System.Windows.Forms.TextBox();
            this.txtHastaTCArama = new System.Windows.Forms.TextBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelleHasta = new System.Windows.Forms.Button();
            this.comboDokNo = new System.Windows.Forms.ComboBox();
            this.txtHastaNoSil = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.poliklinikEkleToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.poliklinikEkleToolStripMenuItem.Text = "Hastalar";
            // 
            // poliklinikEkleToolStripMenuItem1
            // 
            this.poliklinikEkleToolStripMenuItem1.Name = "poliklinikEkleToolStripMenuItem1";
            this.poliklinikEkleToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.poliklinikEkleToolStripMenuItem1.Text = "Hasta Ekle";
            this.poliklinikEkleToolStripMenuItem1.Click += new System.EventHandler(this.poliklinikEkleToolStripMenuItem1_Click);
            // 
            // poliklinikSilToolStripMenuItem
            // 
            this.poliklinikSilToolStripMenuItem.Name = "poliklinikSilToolStripMenuItem";
            this.poliklinikSilToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.poliklinikSilToolStripMenuItem.Text = "Hasta Sil";
            this.poliklinikSilToolStripMenuItem.Click += new System.EventHandler(this.poliklinikSilToolStripMenuItem_Click);
            // 
            // poliklinikListeleToolStripMenuItem
            // 
            this.poliklinikListeleToolStripMenuItem.Name = "poliklinikListeleToolStripMenuItem";
            this.poliklinikListeleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.poliklinikListeleToolStripMenuItem.Text = "Hasta Listele";
            this.poliklinikListeleToolStripMenuItem.Click += new System.EventHandler(this.poliklinikListeleToolStripMenuItem_Click);
            // 
            // poliklinikAraToolStripMenuItem
            // 
            this.poliklinikAraToolStripMenuItem.Name = "poliklinikAraToolStripMenuItem";
            this.poliklinikAraToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.poliklinikAraToolStripMenuItem.Text = "Hasta Ara";
            this.poliklinikAraToolStripMenuItem.Click += new System.EventHandler(this.poliklinikAraToolStripMenuItem_Click);
            // 
            // poliklinikSıralaAZToolStripMenuItem
            // 
            this.poliklinikSıralaAZToolStripMenuItem.Name = "poliklinikSıralaAZToolStripMenuItem";
            this.poliklinikSıralaAZToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.poliklinikSıralaAZToolStripMenuItem.Text = "Hasta Sırala (A_Z)";
            this.poliklinikSıralaAZToolStripMenuItem.Click += new System.EventHandler(this.poliklinikSıralaAZToolStripMenuItem_Click);
            // 
            // poliklinikSıralaZAToolStripMenuItem
            // 
            this.poliklinikSıralaZAToolStripMenuItem.Name = "poliklinikSıralaZAToolStripMenuItem";
            this.poliklinikSıralaZAToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.poliklinikSıralaZAToolStripMenuItem.Text = "Hasta Sırala (Z_A)";
            this.poliklinikSıralaZAToolStripMenuItem.Click += new System.EventHandler(this.poliklinikSıralaZAToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // lblHastaAdEkle
            // 
            this.lblHastaAdEkle.AutoSize = true;
            this.lblHastaAdEkle.Location = new System.Drawing.Point(51, 45);
            this.lblHastaAdEkle.Name = "lblHastaAdEkle";
            this.lblHastaAdEkle.Size = new System.Drawing.Size(107, 16);
            this.lblHastaAdEkle.TabIndex = 2;
            this.lblHastaAdEkle.Text = "Hasta Ad Soyad";
            // 
            // lblHastTcEkle
            // 
            this.lblHastTcEkle.AutoSize = true;
            this.lblHastTcEkle.Location = new System.Drawing.Point(51, 89);
            this.lblHastTcEkle.Name = "lblHastTcEkle";
            this.lblHastTcEkle.Size = new System.Drawing.Size(65, 16);
            this.lblHastTcEkle.TabIndex = 3;
            this.lblHastTcEkle.Text = "Hasta TC";
            // 
            // lblHastDogumTarihiEkle
            // 
            this.lblHastDogumTarihiEkle.AutoSize = true;
            this.lblHastDogumTarihiEkle.Location = new System.Drawing.Point(51, 137);
            this.lblHastDogumTarihiEkle.Name = "lblHastDogumTarihiEkle";
            this.lblHastDogumTarihiEkle.Size = new System.Drawing.Size(128, 16);
            this.lblHastDogumTarihiEkle.TabIndex = 4;
            this.lblHastDogumTarihiEkle.Text = "Hasta Doğum Tarihi";
            // 
            // lblHastBoyekle
            // 
            this.lblHastBoyekle.AutoSize = true;
            this.lblHastBoyekle.Location = new System.Drawing.Point(51, 187);
            this.lblHastBoyekle.Name = "lblHastBoyekle";
            this.lblHastBoyekle.Size = new System.Drawing.Size(71, 16);
            this.lblHastBoyekle.TabIndex = 5;
            this.lblHastBoyekle.Text = "Hasta Boy";
            // 
            // lblHastKiloEkle
            // 
            this.lblHastKiloEkle.AutoSize = true;
            this.lblHastKiloEkle.Location = new System.Drawing.Point(51, 239);
            this.lblHastKiloEkle.Name = "lblHastKiloEkle";
            this.lblHastKiloEkle.Size = new System.Drawing.Size(69, 16);
            this.lblHastKiloEkle.TabIndex = 6;
            this.lblHastKiloEkle.Text = "Hasta Klio";
            // 
            // lblHastYasEkle
            // 
            this.lblHastYasEkle.AutoSize = true;
            this.lblHastYasEkle.Location = new System.Drawing.Point(51, 292);
            this.lblHastYasEkle.Name = "lblHastYasEkle";
            this.lblHastYasEkle.Size = new System.Drawing.Size(71, 16);
            this.lblHastYasEkle.TabIndex = 7;
            this.lblHastYasEkle.Text = "Hasta Yaş";
            // 
            // lblHastaReceteEkle
            // 
            this.lblHastaReceteEkle.AutoSize = true;
            this.lblHastaReceteEkle.Location = new System.Drawing.Point(51, 345);
            this.lblHastaReceteEkle.Name = "lblHastaReceteEkle";
            this.lblHastaReceteEkle.Size = new System.Drawing.Size(91, 16);
            this.lblHastaReceteEkle.TabIndex = 8;
            this.lblHastaReceteEkle.Text = "Hasta Recete";
            // 
            // lblHastaRaporDurumuEkle
            // 
            this.lblHastaRaporDurumuEkle.AutoSize = true;
            this.lblHastaRaporDurumuEkle.Location = new System.Drawing.Point(51, 390);
            this.lblHastaRaporDurumuEkle.Name = "lblHastaRaporDurumuEkle";
            this.lblHastaRaporDurumuEkle.Size = new System.Drawing.Size(134, 16);
            this.lblHastaRaporDurumuEkle.TabIndex = 9;
            this.lblHastaRaporDurumuEkle.Text = "Hasta Rapor Durumu";
            // 
            // lblRandevuTarihiEkle
            // 
            this.lblRandevuTarihiEkle.AutoSize = true;
            this.lblRandevuTarihiEkle.Location = new System.Drawing.Point(51, 444);
            this.lblRandevuTarihiEkle.Name = "lblRandevuTarihiEkle";
            this.lblRandevuTarihiEkle.Size = new System.Drawing.Size(100, 16);
            this.lblRandevuTarihiEkle.TabIndex = 10;
            this.lblRandevuTarihiEkle.Text = "Randevu Tarihi";
            // 
            // lblDokNoEkle
            // 
            this.lblDokNoEkle.AutoSize = true;
            this.lblDokNoEkle.Location = new System.Drawing.Point(51, 497);
            this.lblDokNoEkle.Name = "lblDokNoEkle";
            this.lblDokNoEkle.Size = new System.Drawing.Size(69, 16);
            this.lblDokNoEkle.TabIndex = 11;
            this.lblDokNoEkle.Text = "Doktor No";
            // 
            // txtHastaAdEkle
            // 
            this.txtHastaAdEkle.Location = new System.Drawing.Point(268, 40);
            this.txtHastaAdEkle.Name = "txtHastaAdEkle";
            this.txtHastaAdEkle.Size = new System.Drawing.Size(100, 22);
            this.txtHastaAdEkle.TabIndex = 12;
            // 
            // txtHastaTCEkle
            // 
            this.txtHastaTCEkle.Location = new System.Drawing.Point(268, 86);
            this.txtHastaTCEkle.Name = "txtHastaTCEkle";
            this.txtHastaTCEkle.Size = new System.Drawing.Size(100, 22);
            this.txtHastaTCEkle.TabIndex = 13;
            // 
            // txtHastBoyEkle
            // 
            this.txtHastBoyEkle.Location = new System.Drawing.Point(268, 184);
            this.txtHastBoyEkle.Name = "txtHastBoyEkle";
            this.txtHastBoyEkle.Size = new System.Drawing.Size(100, 22);
            this.txtHastBoyEkle.TabIndex = 14;
            // 
            // txtHastaKiloEkle
            // 
            this.txtHastaKiloEkle.Location = new System.Drawing.Point(268, 236);
            this.txtHastaKiloEkle.Name = "txtHastaKiloEkle";
            this.txtHastaKiloEkle.Size = new System.Drawing.Size(100, 22);
            this.txtHastaKiloEkle.TabIndex = 15;
            // 
            // txtHastaYasEkle
            // 
            this.txtHastaYasEkle.Location = new System.Drawing.Point(268, 289);
            this.txtHastaYasEkle.Name = "txtHastaYasEkle";
            this.txtHastaYasEkle.Size = new System.Drawing.Size(100, 22);
            this.txtHastaYasEkle.TabIndex = 16;
            // 
            // txtHastaReceteEkle
            // 
            this.txtHastaReceteEkle.Location = new System.Drawing.Point(268, 342);
            this.txtHastaReceteEkle.Name = "txtHastaReceteEkle";
            this.txtHastaReceteEkle.Size = new System.Drawing.Size(100, 22);
            this.txtHastaReceteEkle.TabIndex = 17;
            // 
            // dateHastaDogTarEKLE
            // 
            this.dateHastaDogTarEKLE.Location = new System.Drawing.Point(268, 132);
            this.dateHastaDogTarEKLE.Name = "dateHastaDogTarEKLE";
            this.dateHastaDogTarEKLE.Size = new System.Drawing.Size(200, 22);
            this.dateHastaDogTarEKLE.TabIndex = 19;
            // 
            // dateRandevuTarihEkle
            // 
            this.dateRandevuTarihEkle.Location = new System.Drawing.Point(268, 439);
            this.dateRandevuTarihEkle.Name = "dateRandevuTarihEkle";
            this.dateRandevuTarihEkle.Size = new System.Drawing.Size(200, 22);
            this.dateRandevuTarihEkle.TabIndex = 20;
            // 
            // cmbRaporDurumEkle
            // 
            this.cmbRaporDurumEkle.FormattingEnabled = true;
            this.cmbRaporDurumEkle.Items.AddRange(new object[] {
            "VAR",
            "YOK"});
            this.cmbRaporDurumEkle.Location = new System.Drawing.Point(268, 387);
            this.cmbRaporDurumEkle.Name = "cmbRaporDurumEkle";
            this.cmbRaporDurumEkle.Size = new System.Drawing.Size(121, 24);
            this.cmbRaporDurumEkle.TabIndex = 21;
            // 
            // btnEkle
            // 
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Location = new System.Drawing.Point(175, 540);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblHastNoSil
            // 
            this.lblHastNoSil.AutoSize = true;
            this.lblHastNoSil.Location = new System.Drawing.Point(113, 111);
            this.lblHastNoSil.Name = "lblHastNoSil";
            this.lblHastNoSil.Size = new System.Drawing.Size(65, 16);
            this.lblHastNoSil.TabIndex = 23;
            this.lblHastNoSil.Text = "Hasta No";
            // 
            // btnHastaSil
            // 
            this.btnHastaSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHastaSil.Location = new System.Drawing.Point(159, 156);
            this.btnHastaSil.Name = "btnHastaSil";
            this.btnHastaSil.Size = new System.Drawing.Size(75, 23);
            this.btnHastaSil.TabIndex = 25;
            this.btnHastaSil.Text = "Sil";
            this.btnHastaSil.UseVisualStyleBackColor = true;
            this.btnHastaSil.Click += new System.EventHandler(this.btnHastaSil_Click);
            // 
            // lblHastNoArama
            // 
            this.lblHastNoArama.AutoSize = true;
            this.lblHastNoArama.Location = new System.Drawing.Point(106, 206);
            this.lblHastNoArama.Name = "lblHastNoArama";
            this.lblHastNoArama.Size = new System.Drawing.Size(65, 16);
            this.lblHastNoArama.TabIndex = 26;
            this.lblHastNoArama.Text = "Hasta No";
            // 
            // lblHastAdArama
            // 
            this.lblHastAdArama.AutoSize = true;
            this.lblHastAdArama.Location = new System.Drawing.Point(106, 242);
            this.lblHastAdArama.Name = "lblHastAdArama";
            this.lblHastAdArama.Size = new System.Drawing.Size(107, 16);
            this.lblHastAdArama.TabIndex = 27;
            this.lblHastAdArama.Text = "Hasta Ad Soyad";
            // 
            // lblHastTCArama
            // 
            this.lblHastTCArama.AutoSize = true;
            this.lblHastTCArama.Location = new System.Drawing.Point(106, 276);
            this.lblHastTCArama.Name = "lblHastTCArama";
            this.lblHastTCArama.Size = new System.Drawing.Size(65, 16);
            this.lblHastTCArama.TabIndex = 28;
            this.lblHastTCArama.Text = "Hasta TC";
            // 
            // txtHastaNoArama
            // 
            this.txtHastaNoArama.Location = new System.Drawing.Point(236, 203);
            this.txtHastaNoArama.Name = "txtHastaNoArama";
            this.txtHastaNoArama.Size = new System.Drawing.Size(100, 22);
            this.txtHastaNoArama.TabIndex = 29;
            // 
            // txtHastaAdArama
            // 
            this.txtHastaAdArama.Location = new System.Drawing.Point(236, 239);
            this.txtHastaAdArama.Name = "txtHastaAdArama";
            this.txtHastaAdArama.Size = new System.Drawing.Size(100, 22);
            this.txtHastaAdArama.TabIndex = 30;
            // 
            // txtHastaTCArama
            // 
            this.txtHastaTCArama.Location = new System.Drawing.Point(236, 273);
            this.txtHastaTCArama.Name = "txtHastaTCArama";
            this.txtHastaTCArama.Size = new System.Drawing.Size(100, 22);
            this.txtHastaTCArama.TabIndex = 31;
            // 
            // btnArama
            // 
            this.btnArama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArama.Location = new System.Drawing.Point(175, 314);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(75, 23);
            this.btnArama.TabIndex = 32;
            this.btnArama.Text = "Ara";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(502, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 331);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnGuncelleHasta
            // 
            this.btnGuncelleHasta.Location = new System.Drawing.Point(247, 540);
            this.btnGuncelleHasta.Name = "btnGuncelleHasta";
            this.btnGuncelleHasta.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelleHasta.TabIndex = 34;
            this.btnGuncelleHasta.Text = "Güncelle";
            this.btnGuncelleHasta.UseVisualStyleBackColor = true;
            this.btnGuncelleHasta.Click += new System.EventHandler(this.btnGuncelleHasta_Click);
            // 
            // comboDokNo
            // 
            this.comboDokNo.FormattingEnabled = true;
            this.comboDokNo.Location = new System.Drawing.Point(268, 494);
            this.comboDokNo.Name = "comboDokNo";
            this.comboDokNo.Size = new System.Drawing.Size(121, 24);
            this.comboDokNo.TabIndex = 35;
            // 
            // txtHastaNoSil
            // 
            this.txtHastaNoSil.Location = new System.Drawing.Point(211, 108);
            this.txtHastaNoSil.Name = "txtHastaNoSil";
            this.txtHastaNoSil.Size = new System.Drawing.Size(100, 22);
            this.txtHastaNoSil.TabIndex = 36;
            // 
            // Hasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 584);
            this.Controls.Add(this.txtHastaNoSil);
            this.Controls.Add(this.comboDokNo);
            this.Controls.Add(this.btnGuncelleHasta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.txtHastaTCArama);
            this.Controls.Add(this.txtHastaAdArama);
            this.Controls.Add(this.txtHastaNoArama);
            this.Controls.Add(this.lblHastTCArama);
            this.Controls.Add(this.lblHastAdArama);
            this.Controls.Add(this.lblHastNoArama);
            this.Controls.Add(this.btnHastaSil);
            this.Controls.Add(this.lblHastNoSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbRaporDurumEkle);
            this.Controls.Add(this.dateRandevuTarihEkle);
            this.Controls.Add(this.dateHastaDogTarEKLE);
            this.Controls.Add(this.txtHastaReceteEkle);
            this.Controls.Add(this.txtHastaYasEkle);
            this.Controls.Add(this.txtHastaKiloEkle);
            this.Controls.Add(this.txtHastBoyEkle);
            this.Controls.Add(this.txtHastaTCEkle);
            this.Controls.Add(this.txtHastaAdEkle);
            this.Controls.Add(this.lblDokNoEkle);
            this.Controls.Add(this.lblRandevuTarihiEkle);
            this.Controls.Add(this.lblHastaRaporDurumuEkle);
            this.Controls.Add(this.lblHastaReceteEkle);
            this.Controls.Add(this.lblHastYasEkle);
            this.Controls.Add(this.lblHastKiloEkle);
            this.Controls.Add(this.lblHastBoyekle);
            this.Controls.Add(this.lblHastDogumTarihiEkle);
            this.Controls.Add(this.lblHastTcEkle);
            this.Controls.Add(this.lblHastaAdEkle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta";
            this.Load += new System.EventHandler(this.Hasta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label lblHastaAdEkle;
        private System.Windows.Forms.Label lblHastTcEkle;
        private System.Windows.Forms.Label lblHastDogumTarihiEkle;
        private System.Windows.Forms.Label lblHastBoyekle;
        private System.Windows.Forms.Label lblHastKiloEkle;
        private System.Windows.Forms.Label lblHastYasEkle;
        private System.Windows.Forms.Label lblHastaReceteEkle;
        private System.Windows.Forms.Label lblHastaRaporDurumuEkle;
        private System.Windows.Forms.Label lblRandevuTarihiEkle;
        private System.Windows.Forms.Label lblDokNoEkle;
        private System.Windows.Forms.TextBox txtHastaAdEkle;
        private System.Windows.Forms.TextBox txtHastaTCEkle;
        private System.Windows.Forms.TextBox txtHastBoyEkle;
        private System.Windows.Forms.TextBox txtHastaKiloEkle;
        private System.Windows.Forms.TextBox txtHastaYasEkle;
        private System.Windows.Forms.TextBox txtHastaReceteEkle;
        private System.Windows.Forms.DateTimePicker dateHastaDogTarEKLE;
        private System.Windows.Forms.DateTimePicker dateRandevuTarihEkle;
        private System.Windows.Forms.ComboBox cmbRaporDurumEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblHastNoSil;
        private System.Windows.Forms.Button btnHastaSil;
        private System.Windows.Forms.Label lblHastNoArama;
        private System.Windows.Forms.Label lblHastAdArama;
        private System.Windows.Forms.Label lblHastTCArama;
        private System.Windows.Forms.TextBox txtHastaNoArama;
        private System.Windows.Forms.TextBox txtHastaAdArama;
        private System.Windows.Forms.TextBox txtHastaTCArama;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button btnGuncelleHasta;
        private System.Windows.Forms.ComboBox comboDokNo;
        private System.Windows.Forms.TextBox txtHastaNoSil;
    }
}