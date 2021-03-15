
namespace KutuphaneOtomasyonu
{
    partial class ogr_emanet_liste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogr_emanet_liste));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ogrno_txt = new System.Windows.Forms.TextBox();
            this.ara_btn = new System.Windows.Forms.Button();
            this.anasayfa_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listele_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.ara_btn);
            this.groupBox1.Controls.Add(this.ogrno_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(32, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRENCİ EMANET VEYA İADE ARA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No :";
            // 
            // ogrno_txt
            // 
            this.ogrno_txt.Location = new System.Drawing.Point(104, 43);
            this.ogrno_txt.Name = "ogrno_txt";
            this.ogrno_txt.Size = new System.Drawing.Size(140, 29);
            this.ogrno_txt.TabIndex = 1;
            // 
            // ara_btn
            // 
            this.ara_btn.BackColor = System.Drawing.Color.DarkSalmon;
            this.ara_btn.ForeColor = System.Drawing.Color.White;
            this.ara_btn.Location = new System.Drawing.Point(59, 103);
            this.ara_btn.Name = "ara_btn";
            this.ara_btn.Size = new System.Drawing.Size(149, 41);
            this.ara_btn.TabIndex = 2;
            this.ara_btn.Text = "Öğrenci Ara";
            this.ara_btn.UseVisualStyleBackColor = false;
            this.ara_btn.Click += new System.EventHandler(this.ara_btn_Click);
            // 
            // anasayfa_btn
            // 
            this.anasayfa_btn.BackColor = System.Drawing.Color.Plum;
            this.anasayfa_btn.Location = new System.Drawing.Point(799, 12);
            this.anasayfa_btn.Name = "anasayfa_btn";
            this.anasayfa_btn.Size = new System.Drawing.Size(136, 34);
            this.anasayfa_btn.TabIndex = 1;
            this.anasayfa_btn.Text = "ANASAYFA";
            this.anasayfa_btn.UseVisualStyleBackColor = false;
            this.anasayfa_btn.Click += new System.EventHandler(this.anasayfa_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 164);
            this.dataGridView1.TabIndex = 2;
            // 
            // listele_btn
            // 
            this.listele_btn.BackColor = System.Drawing.Color.Khaki;
            this.listele_btn.Location = new System.Drawing.Point(581, 223);
            this.listele_btn.Name = "listele_btn";
            this.listele_btn.Size = new System.Drawing.Size(147, 39);
            this.listele_btn.TabIndex = 3;
            this.listele_btn.Text = "KAYIT GÖSTER";
            this.listele_btn.UseVisualStyleBackColor = false;
            this.listele_btn.Click += new System.EventHandler(this.listele_btn_Click);
            // 
            // ogr_emanet_liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 284);
            this.Controls.Add(this.listele_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.anasayfa_btn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ogr_emanet_liste";
            this.Text = "ÖĞRENCİ EMANET-İADE LİSTESİ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ara_btn;
        private System.Windows.Forms.TextBox ogrno_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button anasayfa_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listele_btn;
    }
}