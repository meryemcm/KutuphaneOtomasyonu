
namespace KutuphaneOtomasyonu
{
    partial class kitap_islemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitap_islemleri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tur_txt = new System.Windows.Forms.TextBox();
            this.yayin_txt = new System.Windows.Forms.TextBox();
            this.dil_txt = new System.Windows.Forms.TextBox();
            this.sayfa_txt = new System.Windows.Forms.TextBox();
            this.baskiyil_txt = new System.Windows.Forms.TextBox();
            this.yazar_txt = new System.Windows.Forms.TextBox();
            this.ktpadi_txt = new System.Windows.Forms.TextBox();
            this.ktpid_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ara_btn = new System.Windows.Forms.Button();
            this.ktp_ara_txt = new System.Windows.Forms.TextBox();
            this.ktp_cmb = new System.Windows.Forms.ComboBox();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.ktp_liste_dg = new System.Windows.Forms.DataGridView();
            this.ktp_liste_btn = new System.Windows.Forms.Button();
            this.anasayfa_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ktp_liste_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.tur_txt);
            this.groupBox1.Controls.Add(this.yayin_txt);
            this.groupBox1.Controls.Add(this.dil_txt);
            this.groupBox1.Controls.Add(this.sayfa_txt);
            this.groupBox1.Controls.Add(this.baskiyil_txt);
            this.groupBox1.Controls.Add(this.yazar_txt);
            this.groupBox1.Controls.Add(this.ktpadi_txt);
            this.groupBox1.Controls.Add(this.ktpid_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(48, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİTAP BİLGİLERİ";
            // 
            // tur_txt
            // 
            this.tur_txt.Location = new System.Drawing.Point(157, 288);
            this.tur_txt.Multiline = true;
            this.tur_txt.Name = "tur_txt";
            this.tur_txt.Size = new System.Drawing.Size(183, 24);
            this.tur_txt.TabIndex = 15;
            this.tur_txt.Text = "Türü";
            this.tur_txt.Click += new System.EventHandler(this.tur_txt_Click);
            // 
            // yayin_txt
            // 
            this.yayin_txt.Location = new System.Drawing.Point(157, 256);
            this.yayin_txt.Multiline = true;
            this.yayin_txt.Name = "yayin_txt";
            this.yayin_txt.Size = new System.Drawing.Size(183, 24);
            this.yayin_txt.TabIndex = 14;
            this.yayin_txt.Text = "Yayın Evi";
            this.yayin_txt.Click += new System.EventHandler(this.yayin_txt_Click);
            // 
            // dil_txt
            // 
            this.dil_txt.Location = new System.Drawing.Point(157, 219);
            this.dil_txt.Multiline = true;
            this.dil_txt.Name = "dil_txt";
            this.dil_txt.Size = new System.Drawing.Size(183, 24);
            this.dil_txt.TabIndex = 13;
            this.dil_txt.Text = "Kitap Dili";
            this.dil_txt.Click += new System.EventHandler(this.dil_txt_Click);
            // 
            // sayfa_txt
            // 
            this.sayfa_txt.Location = new System.Drawing.Point(157, 182);
            this.sayfa_txt.Multiline = true;
            this.sayfa_txt.Name = "sayfa_txt";
            this.sayfa_txt.Size = new System.Drawing.Size(183, 24);
            this.sayfa_txt.TabIndex = 12;
            this.sayfa_txt.Text = "Sayfa Sayısı";
            this.sayfa_txt.Click += new System.EventHandler(this.sayfa_txt_Click);
            // 
            // baskiyil_txt
            // 
            this.baskiyil_txt.Location = new System.Drawing.Point(157, 148);
            this.baskiyil_txt.Multiline = true;
            this.baskiyil_txt.Name = "baskiyil_txt";
            this.baskiyil_txt.Size = new System.Drawing.Size(183, 24);
            this.baskiyil_txt.TabIndex = 11;
            this.baskiyil_txt.Text = "Kitap Baskı Yılı";
            this.baskiyil_txt.Click += new System.EventHandler(this.baskiyil_txt_Click);
            // 
            // yazar_txt
            // 
            this.yazar_txt.Location = new System.Drawing.Point(157, 113);
            this.yazar_txt.Multiline = true;
            this.yazar_txt.Name = "yazar_txt";
            this.yazar_txt.Size = new System.Drawing.Size(183, 24);
            this.yazar_txt.TabIndex = 10;
            this.yazar_txt.Text = "Kitap Yazarı";
            this.yazar_txt.Click += new System.EventHandler(this.yazar_txt_Click);
            // 
            // ktpadi_txt
            // 
            this.ktpadi_txt.Location = new System.Drawing.Point(157, 76);
            this.ktpadi_txt.Multiline = true;
            this.ktpadi_txt.Name = "ktpadi_txt";
            this.ktpadi_txt.Size = new System.Drawing.Size(183, 24);
            this.ktpadi_txt.TabIndex = 9;
            this.ktpadi_txt.Text = "Kitap Adı";
            this.ktpadi_txt.Click += new System.EventHandler(this.ktpadi_txt_Click);
            // 
            // ktpid_txt
            // 
            this.ktpid_txt.Location = new System.Drawing.Point(157, 39);
            this.ktpid_txt.Multiline = true;
            this.ktpid_txt.Name = "ktpid_txt";
            this.ktpid_txt.Size = new System.Drawing.Size(183, 24);
            this.ktpid_txt.TabIndex = 8;
            this.ktpid_txt.Text = "Kitap ID";
            this.ktpid_txt.Click += new System.EventHandler(this.ktpid_txt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Türü :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Yayın Evi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kitap Dili :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sayfa Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitap Baskı Yılı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Yazarı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.ara_btn);
            this.groupBox2.Controls.Add(this.ktp_ara_txt);
            this.groupBox2.Controls.Add(this.ktp_cmb);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Coral;
            this.groupBox2.Location = new System.Drawing.Point(514, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KİTAP ARA";
            // 
            // ara_btn
            // 
            this.ara_btn.Location = new System.Drawing.Point(56, 122);
            this.ara_btn.Name = "ara_btn";
            this.ara_btn.Size = new System.Drawing.Size(140, 33);
            this.ara_btn.TabIndex = 2;
            this.ara_btn.Text = "ARA";
            this.ara_btn.UseVisualStyleBackColor = true;
            this.ara_btn.Click += new System.EventHandler(this.ara_btn_Click);
            // 
            // ktp_ara_txt
            // 
            this.ktp_ara_txt.Location = new System.Drawing.Point(32, 82);
            this.ktp_ara_txt.Multiline = true;
            this.ktp_ara_txt.Name = "ktp_ara_txt";
            this.ktp_ara_txt.Size = new System.Drawing.Size(192, 25);
            this.ktp_ara_txt.TabIndex = 1;
            this.ktp_ara_txt.Text = "Kitap Bilgisi giriniz..";
            this.ktp_ara_txt.Click += new System.EventHandler(this.ktp_ara_txt_Click);
            // 
            // ktp_cmb
            // 
            this.ktp_cmb.FormattingEnabled = true;
            this.ktp_cmb.Items.AddRange(new object[] {
            "KitapAdi",
            "KitapYazari",
            "KitapBasiYil",
            "KitapSayfaSayisi",
            "KitapDil",
            "KitapYayinEvi",
            "KitapTuru"});
            this.ktp_cmb.Location = new System.Drawing.Point(32, 38);
            this.ktp_cmb.Name = "ktp_cmb";
            this.ktp_cmb.Size = new System.Drawing.Size(192, 29);
            this.ktp_cmb.TabIndex = 0;
            this.ktp_cmb.SelectedIndexChanged += new System.EventHandler(this.ktp_cmb_SelectedIndexChanged);
            // 
            // ekle_btn
            // 
            this.ekle_btn.BackColor = System.Drawing.Color.LightGreen;
            this.ekle_btn.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_btn.Location = new System.Drawing.Point(442, 311);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(104, 42);
            this.ekle_btn.TabIndex = 2;
            this.ekle_btn.Text = "EKLE";
            this.ekle_btn.UseVisualStyleBackColor = false;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.BackColor = System.Drawing.Color.LightBlue;
            this.guncelle_btn.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle_btn.Location = new System.Drawing.Point(593, 308);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(107, 45);
            this.guncelle_btn.TabIndex = 3;
            this.guncelle_btn.Text = "GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = false;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.sil_btn.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_btn.Location = new System.Drawing.Point(733, 308);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(108, 45);
            this.sil_btn.TabIndex = 4;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = false;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // ktp_liste_dg
            // 
            this.ktp_liste_dg.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ktp_liste_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ktp_liste_dg.Location = new System.Drawing.Point(36, 462);
            this.ktp_liste_dg.Name = "ktp_liste_dg";
            this.ktp_liste_dg.Size = new System.Drawing.Size(793, 191);
            this.ktp_liste_dg.TabIndex = 5;
            this.ktp_liste_dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ktp_liste_dg_CellContentClick);
            // 
            // ktp_liste_btn
            // 
            this.ktp_liste_btn.BackColor = System.Drawing.Color.Khaki;
            this.ktp_liste_btn.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ktp_liste_btn.Location = new System.Drawing.Point(707, 410);
            this.ktp_liste_btn.Name = "ktp_liste_btn";
            this.ktp_liste_btn.Size = new System.Drawing.Size(134, 36);
            this.ktp_liste_btn.TabIndex = 6;
            this.ktp_liste_btn.Text = "KAYIT GÖSTER";
            this.ktp_liste_btn.UseVisualStyleBackColor = false;
            this.ktp_liste_btn.Click += new System.EventHandler(this.ktp_liste_btn_Click);
            // 
            // anasayfa_btn
            // 
            this.anasayfa_btn.BackColor = System.Drawing.Color.Plum;
            this.anasayfa_btn.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa_btn.Location = new System.Drawing.Point(672, 25);
            this.anasayfa_btn.Name = "anasayfa_btn";
            this.anasayfa_btn.Size = new System.Drawing.Size(141, 32);
            this.anasayfa_btn.TabIndex = 7;
            this.anasayfa_btn.Text = "ANASAYFA";
            this.anasayfa_btn.UseVisualStyleBackColor = false;
            this.anasayfa_btn.Click += new System.EventHandler(this.anasayfa_btn_Click);
            // 
            // kitap_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 665);
            this.Controls.Add(this.anasayfa_btn);
            this.Controls.Add(this.ktp_liste_btn);
            this.Controls.Add(this.ktp_liste_dg);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kitap_islemleri";
            this.Text = "KİTAP İŞEMLERİ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ktp_liste_dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tur_txt;
        private System.Windows.Forms.TextBox yayin_txt;
        private System.Windows.Forms.TextBox dil_txt;
        private System.Windows.Forms.TextBox sayfa_txt;
        private System.Windows.Forms.TextBox baskiyil_txt;
        private System.Windows.Forms.TextBox yazar_txt;
        private System.Windows.Forms.TextBox ktpadi_txt;
        private System.Windows.Forms.TextBox ktpid_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ara_btn;
        private System.Windows.Forms.TextBox ktp_ara_txt;
        private System.Windows.Forms.ComboBox ktp_cmb;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.DataGridView ktp_liste_dg;
        private System.Windows.Forms.Button ktp_liste_btn;
        private System.Windows.Forms.Button anasayfa_btn;
    }
}