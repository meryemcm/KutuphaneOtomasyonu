using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSINESSLAYER;
using ENTITYLAYER;

namespace KutuphaneOtomasyonu
{
    public partial class ogr_emanet_liste : Form
    {
        public ogr_emanet_liste()
        {
            InitializeComponent();
        }

        BusinessEmanetler emanet_ogr = new BusinessEmanetler();


        public void emanet_ve_iade_renk()
        {
            double ceza;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                string islem_turu = dataGridView1.Rows[i].Cells[6].Value.ToString();

                //eğer islem_turu iade'ye eşitse ilgili satırlar yeşil olur.
                if (islem_turu == "iade")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                //almaverme tablosundaki islem_turu iadeye eşit değilse tarihsel işlemler aşağıdaki gibi yapılır.
                if (islem_turu != "iade")
                {
                    string t1, t2; DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = DateTime.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    t2 = t3.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);


                    //eğer iade tarihine 3 gün veya daha az kaldıysa o kişinin satırı sarı olarak görünür
                    if (Int32.Parse(fark.TotalDays.ToString()) > -3 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //eğer son iade tarihi geçmişse satırın kırmızı görünmesi sağlanır.
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        //borcu hesaplatmak için farkı hesaplatıp farkla belirlenen borc miktarını çarpıyoruz.
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        dataGridView1.Rows[i].Cells[5].Value = ceza.ToString("c");
                    }
                }


            }
        }
        private void listele_btn_Click(object sender, EventArgs e)
        {
            //öğrencilerin daha önce yaptığı kitap emanet ve iadeleri datagridview üzerinde gösterilir.
            List<EntityEmanetler> ktp1 = emanet_ogr.EmanetlerYukle();
            dataGridView1.DataSource = ktp1;
            emanet_ve_iade_renk();
            MessageBox.Show("Kayıt gösterme başarılı!");
        }

        private void ara_btn_Click(object sender, EventArgs e)
        {
            //BusinessLayer'daki businessemanetler sınıfından OgrenciEmanetListeleme fonksiyonu çalıştırılıp arama textbox 
            //içindeki veri tablodan çağırılıp datagridview üzerinden  gösterilir.

            List<EntityEmanetler> arama = emanet_ogr.OgrenciEmanetListeleme(ogrno_txt.Text);
            dataGridView1.DataSource = arama;
            emanet_ve_iade_renk();
            MessageBox.Show("Arama Başarılı!");
        }

        private void anasayfa_btn_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu.
            Anasayfa anasyf = new Anasayfa();
            anasyf.Show();
            this.Hide();
        }
    }
}
