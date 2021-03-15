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
    public partial class kitap_emanet_iade_islemleri : Form
    {
        public kitap_emanet_iade_islemleri()
        {
            InitializeComponent();
        }

        string konum = " ";
        string tablo = "";

        BusinessEmanetler emanet_islem = new BusinessEmanetler();
        void veri_cek()
        {
            //Emanetler tablosundaki verileri datagridview'e yüklemek için bu fonksiyonu kullanıyoruz.
            List<EntityEmanetler> ktp = emanet_islem.EmanetlerYukle();
            dataGridView1.DataSource = ktp;
        }

        BusinessEmanetler emanet_ekle = new BusinessEmanetler();
        private void emanet_btn_Click(object sender, EventArgs e)
        {
            //emanetislemleri fonksiyonuna gerekli parametreleri göndererek emanet verme işlemini yapıyoruz.
            try
            {
                int Sonuc = emanet_ekle.EmanetIslemleri( int.Parse(emanet_ktpid_txt.Text), int.Parse(emanet_ogrid_txt.Text), 
                    DateTime.Parse(emanet_tarih_txt.Text), DateTime.Parse(emanet_tarih_son_txt.Text), "alım");
                MessageBox.Show("Emanet verme işlemi başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Emanet işlemi için lütfen alanları doldurunuz!");
            }
        }

        BusinessOgrenci ogr_islem = new BusinessOgrenci();
        private void emanet_ogr_ara_btn_Click(object sender, EventArgs e)
        {
            //öğrenci tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                List<EntityOgrenci> ogr = ogr_islem.OgrenciListele(emanet_ogrno_txt.Text);
                dataGridView1.DataSource = ogr;
                tablo = "emanet_islemleri_ogrenci";
                MessageBox.Show("Arama başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz girdi!");
            }
        }

        BusinessKitaplar kitap_islem = new BusinessKitaplar();
        private void emanet_ktp_ara_btn_Click(object sender, EventArgs e)
        {
            //kitaplar tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                List<EntityKitaplar> ktp2 = kitap_islem.KitapListele(emanet_ktp_bilgi_txt.Text, konum);
                dataGridView1.DataSource = ktp2;
                tablo = "emanet_islemleri_kitap";
                MessageBox.Show("Arama başrılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }
        }

        private void emanet_ktp_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aramanın neye göre yapılacağı bilgisini combobox'tan alıyoruz.
            konum = emanet_ktp_cmb.SelectedItem.ToString();
        }

        private void emanet_ktp_bilgi_txt_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void emanet_tarih_secim_ValueChanged(object sender, EventArgs e)
        {
            //emanet alınan tarih bilgisini datetimepicker yardımıyla alıyoruz.
            emanet_tarih_txt.Text = emanet_tarih_secim.Value.ToShortDateString();
            DateTime emanettarih = DateTime.Parse(emanet_tarih_txt.Text);

            //emanet tarihine 15 gün ekleyerek son teslim tarihini belirliyoruz.
            emanet_tarih_son_txt.Text = emanettarih.AddDays(15).ToShortDateString();
            
            
        }

        private void emanet_ogrno_txt_MouseClick(object sender, MouseEventArgs e)
        {
        
        }

        private void iade_ogr_ara_btn_Click(object sender, EventArgs e)
        {
            //öğrenci tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                List<EntityEmanetler> kayit_cek = emanet_islem.KayitListeleme(int.Parse(iade_ogrno_txt.Text));
                dataGridView1.DataSource = kayit_cek;
                MessageBox.Show("Arama başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }
        }

        private void iade_ktp_ara_btn_Click(object sender, EventArgs e)
        {
            //kitap tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                string konum = " ";
                konum = iade_ktp_cmb.SelectedItem.ToString();
                List<EntityEmanetler> kayit_cek_2 = emanet_islem.KayitListeleme2(iade_ktp_bilgi_txt.Text, konum);
                dataGridView1.DataSource = kayit_cek_2;
                MessageBox.Show("Arama başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }
        }

        private void iade_btn_Click(object sender, EventArgs e)
        {
            // Business katmanındaki BussinessEmanetler sınıfından TabloEmanetDuzenle fonksiyonu çağırılarak iade güncellemesi yapıyoruz.
            try
            {
                int Sonuc = emanet_ekle.TabloEmanetDuzenleme(int.Parse(iade_ktpid_txt.Text), int.Parse(iade_ogrid_txt.Text), 
                    DateTime.Parse(iade_tarih_txt.Text),"iade");
                MessageBox.Show("İade başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("İade işlemi için lütfen alanları doldurunuz!");
            }
        }

        private void iade_ogrno_txt_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void iade_ktp_bilgi_txt_MouseClick(object sender, MouseEventArgs e)
        {
           
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

        private void kayıt_listele_btn_Click(object sender, EventArgs e)
        {
            //kayıt_listele butonuna tıklandığında veri_cek ve emanet_ve_iade_renk fonksiyonları çalıştırılır.
            veri_cek();
            emanet_ve_iade_renk();
        }

        private void anasayfa_btn_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş yapılır.
            Anasayfa anasyf = new Anasayfa();
            anasyf.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iade_tarih_secim_ValueChanged(object sender, EventArgs e)
        {
            //işlem tarih bilgisini datetimepicker yardımıyla alıyoruz.
            iade_tarih_txt.Text = iade_tarih_secim.Value.ToShortDateString();
            DateTime iadetarih = DateTime.Parse(iade_tarih_txt.Text);
        }
    }
}
