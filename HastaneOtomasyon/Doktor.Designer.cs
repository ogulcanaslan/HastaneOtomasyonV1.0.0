
namespace HastaneOtomasyon
{
    partial class Doktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikSıralaAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikSıralaZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDokAd = new System.Windows.Forms.TextBox();
            this.txtDokTC = new System.Windows.Forms.TextBox();
            this.txtDokUzmAlan = new System.Windows.Forms.TextBox();
            this.txtDokUnv = new System.Windows.Forms.TextBox();
            this.mskdDokTelf = new System.Windows.Forms.MaskedTextBox();
            this.rTxtDokAdres = new System.Windows.Forms.RichTextBox();
            this.dttmDokDogumTrh = new System.Windows.Forms.DateTimePicker();
            this.nmrcDokPolNo = new System.Windows.Forms.NumericUpDown();
            this.btnDokKydt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dokNo = new System.Windows.Forms.Label();
            this.DokSil = new System.Windows.Forms.Button();
            this.lblDokNo = new System.Windows.Forms.Label();
            this.lblDokAdi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGuncel = new System.Windows.Forms.Button();
            this.comboDoktorSil = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcDokPolNo)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1256, 24);
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
            this.doktorListeleToolStripMenuItem,
            this.poliklinikAraToolStripMenuItem,
            this.poliklinikSıralaAZToolStripMenuItem,
            this.poliklinikSıralaZAToolStripMenuItem});
            this.poliklinikEkleToolStripMenuItem.Name = "poliklinikEkleToolStripMenuItem";
            this.poliklinikEkleToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.poliklinikEkleToolStripMenuItem.Text = "Doktorlar";
            // 
            // poliklinikEkleToolStripMenuItem1
            // 
            this.poliklinikEkleToolStripMenuItem1.Name = "poliklinikEkleToolStripMenuItem1";
            this.poliklinikEkleToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.poliklinikEkleToolStripMenuItem1.Text = "Doktor Ekle";
            this.poliklinikEkleToolStripMenuItem1.Click += new System.EventHandler(this.poliklinikEkleToolStripMenuItem1_Click);
            // 
            // poliklinikSilToolStripMenuItem
            // 
            this.poliklinikSilToolStripMenuItem.Name = "poliklinikSilToolStripMenuItem";
            this.poliklinikSilToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.poliklinikSilToolStripMenuItem.Text = "Doktor Sil";
            this.poliklinikSilToolStripMenuItem.Click += new System.EventHandler(this.poliklinikSilToolStripMenuItem_Click);
            // 
            // doktorListeleToolStripMenuItem
            // 
            this.doktorListeleToolStripMenuItem.Name = "doktorListeleToolStripMenuItem";
            this.doktorListeleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.doktorListeleToolStripMenuItem.Text = "Doktor Listele";
            this.doktorListeleToolStripMenuItem.Click += new System.EventHandler(this.poliklinikListeleToolStripMenuItem_Click);
            // 
            // poliklinikAraToolStripMenuItem
            // 
            this.poliklinikAraToolStripMenuItem.Name = "poliklinikAraToolStripMenuItem";
            this.poliklinikAraToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.poliklinikAraToolStripMenuItem.Text = "Doktor Ara";
            this.poliklinikAraToolStripMenuItem.Click += new System.EventHandler(this.poliklinikAraToolStripMenuItem_Click);
            // 
            // poliklinikSıralaAZToolStripMenuItem
            // 
            this.poliklinikSıralaAZToolStripMenuItem.Name = "poliklinikSıralaAZToolStripMenuItem";
            this.poliklinikSıralaAZToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.poliklinikSıralaAZToolStripMenuItem.Text = "Doktor Sırala (A_Z)";
            this.poliklinikSıralaAZToolStripMenuItem.Click += new System.EventHandler(this.poliklinikSıralaAZToolStripMenuItem_Click);
            // 
            // poliklinikSıralaZAToolStripMenuItem
            // 
            this.poliklinikSıralaZAToolStripMenuItem.Name = "poliklinikSıralaZAToolStripMenuItem";
            this.poliklinikSıralaZAToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.poliklinikSıralaZAToolStripMenuItem.Text = "Doktor Sırala (Z_A)";
            this.poliklinikSıralaZAToolStripMenuItem.Click += new System.EventHandler(this.poliklinikSıralaZAToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doktor Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doktor T.C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doktor Uzmanlık Alanı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doktor Ünvan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Doktor Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Doktor Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Doğum Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Poliklinik no";
            // 
            // txtDokAd
            // 
            this.txtDokAd.Location = new System.Drawing.Point(231, 40);
            this.txtDokAd.Name = "txtDokAd";
            this.txtDokAd.Size = new System.Drawing.Size(100, 20);
            this.txtDokAd.TabIndex = 10;
            // 
            // txtDokTC
            // 
            this.txtDokTC.Location = new System.Drawing.Point(231, 88);
            this.txtDokTC.Name = "txtDokTC";
            this.txtDokTC.Size = new System.Drawing.Size(100, 20);
            this.txtDokTC.TabIndex = 11;
            // 
            // txtDokUzmAlan
            // 
            this.txtDokUzmAlan.Location = new System.Drawing.Point(231, 133);
            this.txtDokUzmAlan.Name = "txtDokUzmAlan";
            this.txtDokUzmAlan.Size = new System.Drawing.Size(100, 20);
            this.txtDokUzmAlan.TabIndex = 12;
            // 
            // txtDokUnv
            // 
            this.txtDokUnv.Location = new System.Drawing.Point(231, 179);
            this.txtDokUnv.Name = "txtDokUnv";
            this.txtDokUnv.Size = new System.Drawing.Size(100, 20);
            this.txtDokUnv.TabIndex = 13;
            // 
            // mskdDokTelf
            // 
            this.mskdDokTelf.Location = new System.Drawing.Point(231, 228);
            this.mskdDokTelf.Mask = "(999) 000-0000";
            this.mskdDokTelf.Name = "mskdDokTelf";
            this.mskdDokTelf.Size = new System.Drawing.Size(100, 20);
            this.mskdDokTelf.TabIndex = 14;
            // 
            // rTxtDokAdres
            // 
            this.rTxtDokAdres.Location = new System.Drawing.Point(231, 414);
            this.rTxtDokAdres.Name = "rTxtDokAdres";
            this.rTxtDokAdres.Size = new System.Drawing.Size(283, 96);
            this.rTxtDokAdres.TabIndex = 15;
            this.rTxtDokAdres.Text = "";
            // 
            // dttmDokDogumTrh
            // 
            this.dttmDokDogumTrh.Location = new System.Drawing.Point(231, 284);
            this.dttmDokDogumTrh.Name = "dttmDokDogumTrh";
            this.dttmDokDogumTrh.Size = new System.Drawing.Size(200, 20);
            this.dttmDokDogumTrh.TabIndex = 16;
            // 
            // nmrcDokPolNo
            // 
            this.nmrcDokPolNo.Location = new System.Drawing.Point(231, 343);
            this.nmrcDokPolNo.Name = "nmrcDokPolNo";
            this.nmrcDokPolNo.Size = new System.Drawing.Size(120, 20);
            this.nmrcDokPolNo.TabIndex = 17;
            // 
            // btnDokKydt
            // 
            this.btnDokKydt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDokKydt.Location = new System.Drawing.Point(202, 547);
            this.btnDokKydt.Name = "btnDokKydt";
            this.btnDokKydt.Size = new System.Drawing.Size(75, 23);
            this.btnDokKydt.TabIndex = 18;
            this.btnDokKydt.Text = "Kaydet";
            this.btnDokKydt.UseVisualStyleBackColor = true;
            this.btnDokKydt.Click += new System.EventHandler(this.btnDokKydt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(539, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 310);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dokNo
            // 
            this.dokNo.AutoSize = true;
            this.dokNo.Location = new System.Drawing.Point(77, 68);
            this.dokNo.Name = "dokNo";
            this.dokNo.Size = new System.Drawing.Size(69, 13);
            this.dokNo.TabIndex = 20;
            this.dokNo.Text = "Doktor No\'su";
            // 
            // DokSil
            // 
            this.DokSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DokSil.Location = new System.Drawing.Point(135, 110);
            this.DokSil.Name = "DokSil";
            this.DokSil.Size = new System.Drawing.Size(75, 23);
            this.DokSil.TabIndex = 22;
            this.DokSil.Text = "Sil";
            this.DokSil.UseVisualStyleBackColor = true;
            this.DokSil.Click += new System.EventHandler(this.DokSil_Click);
            // 
            // lblDokNo
            // 
            this.lblDokNo.AutoSize = true;
            this.lblDokNo.Location = new System.Drawing.Point(280, 75);
            this.lblDokNo.Name = "lblDokNo";
            this.lblDokNo.Size = new System.Drawing.Size(71, 13);
            this.lblDokNo.TabIndex = 24;
            this.lblDokNo.Text = "Doktor No\'Su";
            // 
            // lblDokAdi
            // 
            this.lblDokAdi.AutoSize = true;
            this.lblDokAdi.Location = new System.Drawing.Point(280, 117);
            this.lblDokAdi.Name = "lblDokAdi";
            this.lblDokAdi.Size = new System.Drawing.Size(57, 13);
            this.lblDokAdi.TabIndex = 25;
            this.lblDokAdi.Text = "Doktor Adı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 26;
            // 
            // btnAra
            // 
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.Location = new System.Drawing.Point(303, 159);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 27;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(363, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // btnGuncel
            // 
            this.btnGuncel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncel.Location = new System.Drawing.Point(276, 547);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.Size = new System.Drawing.Size(75, 23);
            this.btnGuncel.TabIndex = 29;
            this.btnGuncel.Text = "Güncelle";
            this.btnGuncel.UseVisualStyleBackColor = true;
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // comboDoktorSil
            // 
            this.comboDoktorSil.FormattingEnabled = true;
            this.comboDoktorSil.Location = new System.Drawing.Point(172, 65);
            this.comboDoktorSil.Name = "comboDoktorSil";
            this.comboDoktorSil.Size = new System.Drawing.Size(121, 21);
            this.comboDoktorSil.TabIndex = 30;
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1256, 641);
            this.Controls.Add(this.comboDoktorSil);
            this.Controls.Add(this.btnGuncel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDokAdi);
            this.Controls.Add(this.lblDokNo);
            this.Controls.Add(this.DokSil);
            this.Controls.Add(this.dokNo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDokKydt);
            this.Controls.Add(this.nmrcDokPolNo);
            this.Controls.Add(this.dttmDokDogumTrh);
            this.Controls.Add(this.rTxtDokAdres);
            this.Controls.Add(this.mskdDokTelf);
            this.Controls.Add(this.txtDokUnv);
            this.Controls.Add(this.txtDokUzmAlan);
            this.Controls.Add(this.txtDokTC);
            this.Controls.Add(this.txtDokAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor";
            this.Load += new System.EventHandler(this.Doktor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcDokPolNo)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem doktorListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikSıralaAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikSıralaZAToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDokAd;
        private System.Windows.Forms.TextBox txtDokTC;
        private System.Windows.Forms.TextBox txtDokUzmAlan;
        private System.Windows.Forms.TextBox txtDokUnv;
        private System.Windows.Forms.MaskedTextBox mskdDokTelf;
        private System.Windows.Forms.RichTextBox rTxtDokAdres;
        private System.Windows.Forms.DateTimePicker dttmDokDogumTrh;
        private System.Windows.Forms.NumericUpDown nmrcDokPolNo;
        private System.Windows.Forms.Button btnDokKydt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dokNo;
        private System.Windows.Forms.Button DokSil;
        private System.Windows.Forms.Label lblDokNo;
        private System.Windows.Forms.Label lblDokAdi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGuncel;
        private System.Windows.Forms.ComboBox comboDoktorSil;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}