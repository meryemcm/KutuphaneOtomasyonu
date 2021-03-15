using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class EntityEmanetler
    {
     
        int _OgrenciID;
        int _KitapID;
        string _EmanetVermeTarihi;
        string _EmanetGeriAlmaTarihi;
        string _EmanetİslemTarihi;
        string _Borc;
        string _IslemTuru;

        //Bu sınıftaki değişkenlere diğer katmanlardan ulaşabilmek için kapsülleme işlemi yapıyoruz.
        
        public int OgrenciID { get => _OgrenciID; set => _OgrenciID = value; }
        public int KitapID { get => _KitapID; set => _KitapID = value; }
        public string EmanetVermeTarihi { get => _EmanetVermeTarihi; set => _EmanetVermeTarihi = value; }
        public string EmanetGeriAlmaTarihi { get => _EmanetGeriAlmaTarihi; set => _EmanetGeriAlmaTarihi = value; }
        public string EmanetİslemTarihi { get => _EmanetİslemTarihi; set => _EmanetİslemTarihi = value; }
        public string Borc { get => _Borc; set => _Borc = value; }
        public string IslemTuru { get => _IslemTuru; set => _IslemTuru = value; }
    }
}
