
namespace HastaneOtomasyon
{
    partial class KullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.grpGiris = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifreGiris = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdiGiris = new System.Windows.Forms.TextBox();
            this.lblSifreGiris = new System.Windows.Forms.Label();
            this.lblKullaniciAdiGiris = new System.Windows.Forms.Label();
            this.grpKayit = new System.Windows.Forms.GroupBox();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.txtSifreKayıt = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdiKayit = new System.Windows.Forms.TextBox();
            this.lblSifreKayıt = new System.Windows.Forms.Label();
            this.lblKullaniciKayit = new System.Windows.Forms.Label();
            this.txtSifreKayitTekrar = new System.Windows.Forms.TextBox();
            this.lblSifreTekrar = new System.Windows.Forms.Label();
            this.grpGiris.SuspendLayout();
            this.grpKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGiris
            // 
            this.grpGiris.BackColor = System.Drawing.Color.White;
            this.grpGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpGiris.BackgroundImage")));
            this.grpGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpGiris.Controls.Add(this.checkBox1);
            this.grpGiris.Controls.Add(this.btnGiris);
            this.grpGiris.Controls.Add(this.txtSifreGiris);
            this.grpGiris.Controls.Add(this.txtKullaniciAdiGiris);
            this.grpGiris.Controls.Add(this.lblSifreGiris);
            this.grpGiris.Controls.Add(this.lblKullaniciAdiGiris);
            this.grpGiris.Location = new System.Drawing.Point(147, 71);
            this.grpGiris.Name = "grpGiris";
            this.grpGiris.Size = new System.Drawing.Size(313, 408);
            this.grpGiris.TabIndex = 0;
            this.grpGiris.TabStop = false;
            this.grpGiris.Text = "Giriş";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(105, 269);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "ÜYE OL";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Location = new System.Drawing.Point(105, 190);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifreGiris
            // 
            this.txtSifreGiris.Location = new System.Drawing.Point(148, 112);
            this.txtSifreGiris.Name = "txtSifreGiris";
            this.txtSifreGiris.PasswordChar = '*';
            this.txtSifreGiris.Size = new System.Drawing.Size(100, 22);
            this.txtSifreGiris.TabIndex = 3;
            // 
            // txtKullaniciAdiGiris
            // 
            this.txtKullaniciAdiGiris.Location = new System.Drawing.Point(148, 67);
            this.txtKullaniciAdiGiris.Name = "txtKullaniciAdiGiris";
            this.txtKullaniciAdiGiris.Size = new System.Drawing.Size(100, 22);
            this.txtKullaniciAdiGiris.TabIndex = 2;
            // 
            // lblSifreGiris
            // 
            this.lblSifreGiris.AutoSize = true;
            this.lblSifreGiris.Location = new System.Drawing.Point(42, 115);
            this.lblSifreGiris.Name = "lblSifreGiris";
            this.lblSifreGiris.Size = new System.Drawing.Size(35, 16);
            this.lblSifreGiris.TabIndex = 1;
            this.lblSifreGiris.Text = "Şifre";
            // 
            // lblKullaniciAdiGiris
            // 
            this.lblKullaniciAdiGiris.AutoSize = true;
            this.lblKullaniciAdiGiris.Location = new System.Drawing.Point(42, 70);
            this.lblKullaniciAdiGiris.Name = "lblKullaniciAdiGiris";
            this.lblKullaniciAdiGiris.Size = new System.Drawing.Size(80, 16);
            this.lblKullaniciAdiGiris.TabIndex = 0;
            this.lblKullaniciAdiGiris.Text = "Kullanıcı Adı";
            // 
            // grpKayit
            // 
            this.grpKayit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpKayit.BackgroundImage")));
            this.grpKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpKayit.Controls.Add(this.lblSifreTekrar);
            this.grpKayit.Controls.Add(this.txtSifreKayitTekrar);
            this.grpKayit.Controls.Add(this.btnKayıt);
            this.grpKayit.Controls.Add(this.txtSifreKayıt);
            this.grpKayit.Controls.Add(this.txtKullaniciAdiKayit);
            this.grpKayit.Controls.Add(this.lblSifreKayıt);
            this.grpKayit.Controls.Add(this.lblKullaniciKayit);
            this.grpKayit.Location = new System.Drawing.Point(529, 71);
            this.grpKayit.Name = "grpKayit";
            this.grpKayit.Size = new System.Drawing.Size(313, 408);
            this.grpKayit.TabIndex = 5;
            this.grpKayit.TabStop = false;
            this.grpKayit.Text = "Kayıt Ol";
            // 
            // btnKayıt
            // 
            this.btnKayıt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayıt.Location = new System.Drawing.Point(108, 190);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(75, 23);
            this.btnKayıt.TabIndex = 4;
            this.btnKayıt.Text = "Kayıt Ol";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // txtSifreKayıt
            // 
            this.txtSifreKayıt.Location = new System.Drawing.Point(148, 115);
            this.txtSifreKayıt.Name = "txtSifreKayıt";
            this.txtSifreKayıt.PasswordChar = '*';
            this.txtSifreKayıt.Size = new System.Drawing.Size(100, 22);
            this.txtSifreKayıt.TabIndex = 3;
            // 
            // txtKullaniciAdiKayit
            // 
            this.txtKullaniciAdiKayit.Location = new System.Drawing.Point(148, 67);
            this.txtKullaniciAdiKayit.Name = "txtKullaniciAdiKayit";
            this.txtKullaniciAdiKayit.Size = new System.Drawing.Size(100, 22);
            this.txtKullaniciAdiKayit.TabIndex = 2;
            // 
            // lblSifreKayıt
            // 
            this.lblSifreKayıt.AutoSize = true;
            this.lblSifreKayıt.Location = new System.Drawing.Point(42, 118);
            this.lblSifreKayıt.Name = "lblSifreKayıt";
            this.lblSifreKayıt.Size = new System.Drawing.Size(35, 16);
            this.lblSifreKayıt.TabIndex = 1;
            this.lblSifreKayıt.Text = "Şifre";
            // 
            // lblKullaniciKayit
            // 
            this.lblKullaniciKayit.AutoSize = true;
            this.lblKullaniciKayit.Location = new System.Drawing.Point(42, 70);
            this.lblKullaniciKayit.Name = "lblKullaniciKayit";
            this.lblKullaniciKayit.Size = new System.Drawing.Size(80, 16);
            this.lblKullaniciKayit.TabIndex = 0;
            this.lblKullaniciKayit.Text = "Kullanıcı Adı";
            // 
            // txtSifreKayitTekrar
            // 
            this.txtSifreKayitTekrar.Location = new System.Drawing.Point(148, 143);
            this.txtSifreKayitTekrar.Name = "txtSifreKayitTekrar";
            this.txtSifreKayitTekrar.PasswordChar = '*';
            this.txtSifreKayitTekrar.Size = new System.Drawing.Size(100, 22);
            this.txtSifreKayitTekrar.TabIndex = 5;
            // 
            // lblSifreTekrar
            // 
            this.lblSifreTekrar.AutoSize = true;
            this.lblSifreTekrar.Location = new System.Drawing.Point(42, 149);
            this.lblSifreTekrar.Name = "lblSifreTekrar";
            this.lblSifreTekrar.Size = new System.Drawing.Size(78, 16);
            this.lblSifreTekrar.TabIndex = 6;
            this.lblSifreTekrar.Text = "Şifre Tekrar";
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 567);
            this.Controls.Add(this.grpKayit);
            this.Controls.Add(this.grpGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.KullaniciGiris_Load);
            this.grpGiris.ResumeLayout(false);
            this.grpGiris.PerformLayout();
            this.grpKayit.ResumeLayout(false);
            this.grpKayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGiris;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifreGiris;
        private System.Windows.Forms.TextBox txtKullaniciAdiGiris;
        private System.Windows.Forms.Label lblSifreGiris;
        private System.Windows.Forms.Label lblKullaniciAdiGiris;
        private System.Windows.Forms.GroupBox grpKayit;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.TextBox txtSifreKayıt;
        private System.Windows.Forms.TextBox txtKullaniciAdiKayit;
        private System.Windows.Forms.Label lblSifreKayıt;
        private System.Windows.Forms.Label lblKullaniciKayit;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblSifreTekrar;
        private System.Windows.Forms.TextBox txtSifreKayitTekrar;
    }
}