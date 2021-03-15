using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class EntityKitaplar
    {
        int _KitapID;
        string _KitapAdi;
        string _KitapYazari;
        int _KitapBaskiYil;
        int _KitapSayfaSayisi;
        string _KitapDil;
        string _KitapYayinEvi;
        string _KitapTuru;

        //Bu sınıftaki değişkenlere diğer katmanlardan ulaşabilmek için kapsülleme işlemi yapıyoruz.
        public int KitapID { get => _KitapID; set => _KitapID = value; }
        public string KitapAdi { get => _KitapAdi; set => _KitapAdi = value; }
        public string KitapYazari { get => _KitapYazari; set => _KitapYazari = value; }
        public int KitapBaskiYil { get => _KitapBaskiYil; set => _KitapBaskiYil = value; }
        public int KitapSayfaSayisi { get => _KitapSayfaSayisi; set => _KitapSayfaSayisi = value; }
        public string KitapDil { get => _KitapDil; set => _KitapDil = value; }
        public string KitapYayinEvi { get => _KitapYayinEvi; set => _KitapYayinEvi = value; }
        public string KitapTuru { get => _KitapTuru; set => _KitapTuru = value; }
    }
}
