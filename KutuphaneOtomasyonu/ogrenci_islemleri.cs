using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITYLAYER;
using BUSINESSLAYER;

namespace KutuphaneOtomasyonu
{
    public partial class ogrenci_islemleri : Form
    {
        public ogrenci_islemleri()
        {
            InitializeComponent();
        }

        BusinessOgrenci ogrislem = new BusinessOgrenci();
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            //BusinessLayer'daki BusinessOgrenci OgrenciEkle fonksiyonu çalıştırılarak öğrenci ekleme işlemi yapılır.
            int sonuc = ogrislem.OgrenciEkle(isim_txt.Text,soyisim_txt.Text,ogrno_txt.Text,(int.Parse(sinif_txt.Text)),(int.Parse(tel_txt.Text)),mail_txt.Text,adres_txt.Text);
            MessageBox.Show("Öğrenci Başarıyla Eklendi.");
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            //BusinessLayer'daki BusinessOgrenci OgrenciGuncelle fonksiyonu çalıştırılarak öğrenci güncelleme işlemi yapılır.
            try
            {
                int sonuc = ogrislem.OgrenciGuncelle(int.Parse(ogrid_txt.Text), isim_txt.Text, soyisim_txt.Text, ogrno_txt.Text, (int.Parse(sinif_txt.Text)), (int.Parse(tel_txt.Text)), mail_txt.Text, adres_txt.Text);
                MessageBox.Show("Öğrenci Başarıyla Güncellendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen güncelleme bilgilerini doğru girdiğinizden emin olun!");
            }
        }

        BusinessOgrenci ogr_sil = new BusinessOgrenci();
        private void sil_btn_Click(object sender, EventArgs e)
        {
            //BusinessLayer'daki BusinessOgrenci sınıfındaki OgrenciSil fonksiyonu çalıştırılarak öğrenci silme işlemi yapılır.
            try
            {
                ogr_sil.OgrenciSil(int.Parse(ogrid_txt.Text));
                MessageBox.Show("Öğrenci Başarıyla Silindi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen girilen değerleri kontrol ediniz!");
            }
        }

        BusinessOgrenci ogr_list = new BusinessOgrenci();
        void ogr_gstr()
        {
            //ogrenciler listesindeki verileri ogr_goster fonkiyonu ile datagridview'e çağırır. 
            List<EntityOgrenci> ogrenci1 = ogr_list.OgrenciListele();
            ogr_list_dg.DataSource = ogrenci1;
        }

        private void ogr_liste_btn_Click(object sender, EventArgs e)
        {
            //ogr_gstr fonksiyonu ile öğrenci listelemesi yapılır.
            ogr_gstr();
            MessageBox.Show("Öğrenciler Başarıyla Listelendi.");
        }

        private void ogr_list_dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'de tıklanan satırın bilgileri textbox'a aktarılır.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ogr_list_dg.Rows[e.RowIndex];
                ogrid_txt.Text = row.Cells[0].Value.ToString();
                isim_txt.Text = row.Cells[1].Value.ToString();
                soyisim_txt.Text = row.Cells[2].Value.ToString();
                ogrno_txt.Text = row.Cells[3].Value.ToString();
                sinif_txt.Text = row.Cells[4].Value.ToString();
                tel_txt.Text = row.Cells[5].Value.ToString();
                mail_txt.Text = row.Cells[6].Value.ToString();
                adres_txt.Text = row.Cells[7].Value.ToString();
            }
        }

        private void ara_btn_Click(object sender, EventArgs e)
        {
            // arama textbox'ındaki metin ogrenci tablosundan bulunarak listeleniyor.
            List<EntityOgrenci> ogrenci1 = ogrislem.OgrenciListele(ara_txt.Text);
            ogr_list_dg.DataSource = ogrenci1;
        }


        private void anasayfa_btn_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu
            Anasayfa anasyf = new Anasayfa();
            anasyf.Show();
            this.Hide();
        }

        private void ogrid_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            ogrid_txt.Text = "";
        }

        private void isim_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            isim_txt.Text = "";
        }

        private void soyisim_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            soyisim_txt.Text = "";
        }

        private void ogrno_txt_Click(object sender, EventArgs e)
        {
            ogrno_txt.Text = "";
        }

        private void sinif_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            sinif_txt.Text = "";
        }

        private void tel_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            tel_txt.Text = "";
        }

        private void mail_txt_Click(object sender, EventArgs e)
        {
             //textbox içindeki yazılar silinir.
            mail_txt.Text = "";
        }

        private void adres_txt_Click(object sender, EventArgs e)
        { //textbox içindeki yazılar silinir.
            adres_txt.Text = "";
        }

        private void ara_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            ara_txt.Text = "";
        }
    }
}
