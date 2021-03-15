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
    public partial class kitap_islemleri : Form
    {
        public kitap_islemleri()
        {
            InitializeComponent();
        }

        string konum = " ";
        BusinessKitaplar ktpislem = new BusinessKitaplar();
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            //BusinessLayer'daki businesskitaplar sınıfındaki KitapEkle fonksiyonu çaılştırılarak kitap ekleme işlemi yapılır.
            int sonuc = ktpislem.KitapEkle(ktpadi_txt.Text,yazar_txt.Text,int.Parse(baskiyil_txt.Text),int.Parse(sayfa_txt.Text),dil_txt.Text,yayin_txt.Text,tur_txt.Text);
            MessageBox.Show("Kitap Başarıyla Eklendi.");
        }
        BusinessKitaplar ktpekle = new BusinessKitaplar();

        BusinessKitaplar ktp_guncelle = new BusinessKitaplar();
        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            //BusinessLayer'daki businesskitaplar sınıfındaki KitapGuncelle fonksiyonu çalıştırılarak kitap güncellleme işlemi yapılır.
            try
            {
                int Sonuc = ktp_guncelle.KitapGuncelle(int.Parse(ktpid_txt.Text), ktpadi_txt.Text, yazar_txt.Text, int.Parse(baskiyil_txt.Text), int.Parse(sayfa_txt.Text), dil_txt.Text, yayin_txt.Text, tur_txt.Text);
                MessageBox.Show("Kitap başarıyla güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen güncelleme bilgilerini doğru giriniz!");
            }

        }
        void veri_cek()
        {
            //kitaplar listesinden sütun bilgilerini çekip datagridview'e aktarır.
            List<EntityKitaplar> ktp = ktp_islem.KitapListele();
            ktp_liste_dg.DataSource = ktp;
        }
        BusinessKitaplar ktp_islem = new BusinessKitaplar();
        private void ktp_liste_btn_Click(object sender, EventArgs e)
        {
            //veri_cek fonksiyonu ile tüm kitap bilgileri datagridview'e aktarılır.
            veri_cek();
            MessageBox.Show("Tüm kayıtlar listelendi");
        }

        BusinessKitaplar ktpsil = new BusinessKitaplar();
        private void sil_btn_Click(object sender, EventArgs e)
        {
            //BusinessLayer'daki businesskitaplar sınıfındaki KitapSil fonksiyonu çalıştırılarak kitap silme işlemi yapılır.
            try
            {
                int Sonuc = ktpsil.KitapSil(int.Parse(ktpid_txt.Text));
                MessageBox.Show("Kitap başarıyla silindi");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen alanları doldurduğunuzdan veya doğru olduğundan emin olunuz!");
            }
        }

        private void ktp_liste_dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ktp_liste_dg.Rows[e.RowIndex];
                ktpid_txt.Text = row.Cells[0].Value.ToString();
                ktpadi_txt.Text = row.Cells[1].Value.ToString();
                yazar_txt.Text = row.Cells[2].Value.ToString();
                baskiyil_txt.Text = row.Cells[3].Value.ToString();
                sayfa_txt.Text = row.Cells[4].Value.ToString();
                dil_txt.Text = row.Cells[5].Value.ToString();
                yayin_txt.Text = row.Cells[6].Value.ToString();
                tur_txt.Text = row.Cells[7].Value.ToString();
                
            }
        }

        private void ktp_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //konum değeri textbox içersindeki seçilen değere eşitlenir.
            konum = ktp_cmb.SelectedItem.ToString();
        }

        private void ktp_ara_txt_TextChanged(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            ktp_ara_txt.Text = "";
        }

        private void ara_btn_Click(object sender, EventArgs e)
        {
            //BusinessLayer'daki businesskitaplar sınıfından KitapListele fonksiyonu çalıştırılarak kitap bilgileri
            //datagridview'e aktarılır.
            try
            {
                List<EntityKitaplar> ktp2 = ktp_islem.KitapListele(ktp_ara_txt.Text, konum);
                ktp_liste_dg.DataSource = ktp2;
                MessageBox.Show("Arama sonuçları listelendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz!");
            }
        }

        private void anasayfa_btn_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu.
            Anasayfa anasyf = new Anasayfa();
            anasyf.Show();
            this.Hide();
        }

        private void ktpid_txt_Click(object sender, EventArgs e)
        {
            ktpid_txt.Text = "";
        }

        private void ktpadi_txt_Click(object sender, EventArgs e)
        {
            ktpadi_txt.Text = "";
        }

        private void yazar_txt_Click(object sender, EventArgs e)
        {
            yazar_txt.Text = "";
        }

        private void baskiyil_txt_Click(object sender, EventArgs e)
        {
            baskiyil_txt.Text = "";
        }

        private void sayfa_txt_Click(object sender, EventArgs e)
        {
            sayfa_txt.Text = "";
        }

        private void dil_txt_Click(object sender, EventArgs e)
        {
            dil_txt.Text = "";
        }

        private void yayin_txt_Click(object sender, EventArgs e)
        {
            yayin_txt.Text = "";
        }

        private void tur_txt_Click(object sender, EventArgs e)
        {
            tur_txt.Text = "";
        }

        private void ktp_ara_txt_Click(object sender, EventArgs e)
        {
            ktp_ara_txt.Text = "";
        }
    }
}
