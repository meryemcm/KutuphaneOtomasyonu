
namespace KutuphaneOtomasyonu
{
    partial class grafik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grafik));
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.anasayfa_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(76, 82);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(532, 379);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // anasayfa_btn
            // 
            this.anasayfa_btn.BackColor = System.Drawing.Color.Plum;
            this.anasayfa_btn.Location = new System.Drawing.Point(502, 27);
            this.anasayfa_btn.Name = "anasayfa_btn";
            this.anasayfa_btn.Size = new System.Drawing.Size(160, 34);
            this.anasayfa_btn.TabIndex = 1;
            this.anasayfa_btn.Text = "ANASAYFA";
            this.anasayfa_btn.UseVisualStyleBackColor = false;
            this.anasayfa_btn.Click += new System.EventHandler(this.anasayfa_btn_Click);
            // 
            // grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 492);
            this.Controls.Add(this.anasayfa_btn);
            this.Controls.Add(this.zedGraphControl1);
            this.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "grafik";
            this.Text = "GRAFİK GÖSTERİM";
            this.Load += new System.EventHandler(this.grafik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button anasayfa_btn;
    }
}