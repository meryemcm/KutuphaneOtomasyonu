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
    public partial class ktp_emanet_liste : Form
    {
        public ktp_emanet_liste()
        {
            InitializeComponent();
        }

        private void ara_btn_Click(object sender, EventArgs e)
        {
            //arama fonksiyonunda sorgu yapıp dönen liste değerlerini datagridview'e ekliyoruz.
            try
            {
                string konum = " ";
                konum = kategori_cmb.SelectedItem.ToString();
                List<EntityEmanetler> kayit_cekme = emanet_iade.KayitListeleme2(ktp_txt.Text, konum);
                dataGridView1.DataSource = kayit_cekme;
                emanet_ve_iade_renk();
                MessageBox.Show("Arama başarılı!");

            }
            //eğer arama bölümü boş veya geçersiz ise hata mesajı veriyoruz.
            catch (Exception)
            {
                MessageBox.Show("Giriş değerlerini kontrol ediniz!");
            }

        }

        BusinessEmanetler emanet_iade = new BusinessEmanetler();

        void veri_cek()
        {
            //veritabanından Emanetler'deki tüm verileri çekip datagridview'e yazıyoruz.
            List<EntityEmanetler> kitap = emanet_iade.EmanetlerYukle();
            dataGridView1.DataSource = kitap;
        }

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

                //Emanetler tablosundaki islem_turu iadeye eşit değilse tarihsel işlemler aşağıdaki gibi yapılır.
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
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        dataGridView1.Rows[i].Cells[5].Value = ceza.ToString("c");
                    }
                }


            }
        }


        private void listele_btn_Click(object sender, EventArgs e)
        {
            veri_cek();
            emanet_ve_iade_renk();
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
