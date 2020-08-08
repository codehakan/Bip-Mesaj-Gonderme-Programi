namespace Bip_Mesaj_Gönderme_Programı
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_gonderilecekMetin = new System.Windows.Forms.RichTextBox();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.btn_durdur = new System.Windows.Forms.Button();
            this.btn_hazirla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_hiz = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_gonderilen = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_gonderilecek = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.lbl_notice = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gönderilenKelimeSayacınıSıfırlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_gonderilecekMetin
            // 
            this.txt_gonderilecekMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_gonderilecekMetin.Location = new System.Drawing.Point(12, 132);
            this.txt_gonderilecekMetin.Name = "txt_gonderilecekMetin";
            this.txt_gonderilecekMetin.Size = new System.Drawing.Size(610, 244);
            this.txt_gonderilecekMetin.TabIndex = 0;
            this.txt_gonderilecekMetin.Text = resources.GetString("txt_gonderilecekMetin.Text");
            this.txt_gonderilecekMetin.TextChanged += new System.EventHandler(this.txt_gonderilecekMetin_TextChanged);
            // 
            // btn_baslat
            // 
            this.btn_baslat.Enabled = false;
            this.btn_baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_baslat.Location = new System.Drawing.Point(12, 382);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(168, 42);
            this.btn_baslat.TabIndex = 1;
            this.btn_baslat.Text = "BAŞLAT";
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // btn_durdur
            // 
            this.btn_durdur.Enabled = false;
            this.btn_durdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_durdur.Location = new System.Drawing.Point(454, 382);
            this.btn_durdur.Name = "btn_durdur";
            this.btn_durdur.Size = new System.Drawing.Size(168, 45);
            this.btn_durdur.TabIndex = 2;
            this.btn_durdur.Text = "DURDUR";
            this.btn_durdur.UseVisualStyleBackColor = true;
            this.btn_durdur.Click += new System.EventHandler(this.btn_durdur_Click);
            // 
            // btn_hazirla
            // 
            this.btn_hazirla.BackColor = System.Drawing.SystemColors.Control;
            this.btn_hazirla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_hazirla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_hazirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hazirla.Location = new System.Drawing.Point(6, 51);
            this.btn_hazirla.Name = "btn_hazirla";
            this.btn_hazirla.Size = new System.Drawing.Size(184, 25);
            this.btn_hazirla.TabIndex = 3;
            this.btn_hazirla.Text = "HAZIRLA- (Kaydet)";
            this.btn_hazirla.UseVisualStyleBackColor = false;
            this.btn_hazirla.Click += new System.EventHandler(this.btn_hazirla_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_hiz
            // 
            this.txt_hiz.BackColor = System.Drawing.SystemColors.Window;
            this.txt_hiz.Location = new System.Drawing.Point(6, 20);
            this.txt_hiz.MaxLength = 4;
            this.txt_hiz.Name = "txt_hiz";
            this.txt_hiz.ShortcutsEnabled = false;
            this.txt_hiz.Size = new System.Drawing.Size(100, 23);
            this.txt_hiz.TabIndex = 4;
            this.txt_hiz.Text = "200";
            this.txt_hiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hiz.TextChanged += new System.EventHandler(this.txt_hiz_TextChanged);
            this.txt_hiz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hiz_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_gonderilen);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 84);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gönderilen Mesaj Sayısı";
            // 
            // lbl_gonderilen
            // 
            this.lbl_gonderilen.AutoSize = true;
            this.lbl_gonderilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gonderilen.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_gonderilen.Location = new System.Drawing.Point(6, 38);
            this.lbl_gonderilen.Name = "lbl_gonderilen";
            this.lbl_gonderilen.Size = new System.Drawing.Size(143, 20);
            this.lbl_gonderilen.TabIndex = 0;
            this.lbl_gonderilen.TabStop = true;
            this.lbl_gonderilen.Text = "0 kelime gönderildi.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_gonderilecek);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(222, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gönderilecek Toplam Mesaj";
            // 
            // lbl_gonderilecek
            // 
            this.lbl_gonderilecek.AutoSize = true;
            this.lbl_gonderilecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gonderilecek.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_gonderilecek.Location = new System.Drawing.Point(6, 38);
            this.lbl_gonderilecek.Name = "lbl_gonderilecek";
            this.lbl_gonderilecek.Size = new System.Drawing.Size(138, 20);
            this.lbl_gonderilecek.TabIndex = 0;
            this.lbl_gonderilecek.TabStop = true;
            this.lbl_gonderilecek.Text = "0 kelime ayarlandı.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_degistir);
            this.groupBox1.Controls.Add(this.btn_hazirla);
            this.groupBox1.Controls.Add(this.txt_hiz);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(432, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 84);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayarlar(MiliSaniye olarak)";
            // 
            // btn_degistir
            // 
            this.btn_degistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_degistir.Location = new System.Drawing.Point(112, 20);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(78, 25);
            this.btn_degistir.TabIndex = 5;
            this.btn_degistir.Text = "Düzenle";
            this.btn_degistir.UseVisualStyleBackColor = true;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // lbl_notice
            // 
            this.lbl_notice.BackColor = System.Drawing.Color.PaleGreen;
            this.lbl_notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_notice.ForeColor = System.Drawing.Color.Black;
            this.lbl_notice.Location = new System.Drawing.Point(186, 382);
            this.lbl_notice.Name = "lbl_notice";
            this.lbl_notice.Size = new System.Drawing.Size(262, 45);
            this.lbl_notice.TabIndex = 8;
            this.lbl_notice.Text = "Bilgilendirme Metni Aktif Edildi";
            this.lbl_notice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_notice.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gönderilenKelimeSayacınıSıfırlaToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 29);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gönderilenKelimeSayacınıSıfırlaToolStripMenuItem
            // 
            this.gönderilenKelimeSayacınıSıfırlaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gönderilenKelimeSayacınıSıfırlaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gönderilenKelimeSayacınıSıfırlaToolStripMenuItem.Image")));
            this.gönderilenKelimeSayacınıSıfırlaToolStripMenuItem.Name = "gönderilenKelimeSayacınıSıfırlaToolStripMenuItem";
            this.gönderilenKelimeSayacınıSıfırlaToolStripMenuItem.Size = new System.Drawing.Size(271, 25);
            this.gönderilenKelimeSayacınıSıfırlaToolStripMenuItem.Text = "Gönderilen Kelime Sayacını Sıfırla";
            this.gönderilenKelimeSayacınıSıfırlaToolStripMenuItem.Click += new System.EventHandler(this.gönderilenKelimeSayacınıSıfırlaToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hakkındaToolStripMenuItem.Image")));
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 2);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(569, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "HakanBey\r\nreload58";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_notice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_durdur);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.txt_gonderilecekMetin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiP - Otomatik Mesaj Gönderme Botu v1.0 - Hakan AKKAYA";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_gonderilecekMetin;
        private System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.Button btn_durdur;
        private System.Windows.Forms.Button btn_hazirla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_hiz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel lbl_gonderilen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lbl_gonderilecek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_notice;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_degistir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gönderilenKelimeSayacınıSıfırlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

