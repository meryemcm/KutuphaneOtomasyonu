using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class EntityOgrenci
    {
        int _OgrenciID;
        string _Isim;
        string _Soyisim;
        string _OgrenciNo;
        int _Sinif;
        int _Telefon;
        string _Email;
        string _Adres;

        //Bu sınıftaki değişkenlere diğer katmanlardan ulaşabilmek için kapsülleme işlemi yapıyoruz.
        public int OgrenciID { get => _OgrenciID; set => _OgrenciID = value; }
        public string Isim { get => _Isim; set => _Isim = value; }
        public string Soyisim { get => _Soyisim; set => _Soyisim = value; }
        public string OgrenciNo { get => _OgrenciNo; set => _OgrenciNo = value; }
        public int Sinif { get => _Sinif; set => _Sinif = value; }
        public int Telefon { get => _Telefon; set => _Telefon = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Adres { get => _Adres; set => _Adres = value; }
    }
}
