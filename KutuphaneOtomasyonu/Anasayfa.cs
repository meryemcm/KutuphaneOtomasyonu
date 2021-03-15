using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void ogrenci_islemleri_Click(object sender, EventArgs e)
        {
            //Ogrenci işlemleri formuna yönlendirmeyi sağlar. 
            ogrenci_islemleri ogr_isl = new ogrenci_islemleri();
            ogr_isl.Show();
            this.Hide();
        }

        private void kitap_islemleri_Click(object sender, EventArgs e)
        {
            //kitap işlemleri formuna yönlendirmeyi sağlar. 
            kitap_islemleri ktp_isl = new kitap_islemleri();
            ktp_isl.Show();
            this.Hide();
        }

        private void emanet_islemleri_Click(object sender, EventArgs e)
        {
            //kitap emanet ve iade işlemleri formuna yönlendirmeyi sağlar. 
            kitap_emanet_iade_islemleri ktp_emt_iade_islm = new kitap_emanet_iade_islemleri();
            ktp_emt_iade_islm.Show();
            this.Hide();
        }

        private void kitap_listesi_Click(object sender, EventArgs e)
        {
            //kitap emanet listeleme formuna yönlendirmeyi sağlar. 
            ktp_emanet_liste ktp_emnt_iade = new ktp_emanet_liste();
            ktp_emnt_iade.Show();
            this.Hide();
        }

        private void ogrenci_listesi_Click(object sender, EventArgs e)
        {
            //öğrenci emanet listeleme formuna yönlendirmeyi sağlar. 
            ogr_emanet_liste ogr_emnt_list = new ogr_emanet_liste();
            ogr_emnt_list.Show();
            this.Hide();
        }

        private void grafik_Click(object sender, EventArgs e)
        {
            //grafik formuna yönlendirmeyi sağlar. 
            grafik graf = new grafik();
            graf.Show();
            this.Hide();
        }
    }
}
