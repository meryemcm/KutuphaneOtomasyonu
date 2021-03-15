using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using ENTITYLAYER;

namespace BUSINESSLAYER
{
   public class BusinessKitaplar
    {
        DATAACCESSLAYER.DataAccessLayer dal1 = new DATAACCESSLAYER.DataAccessLayer();
        public List<EntityKitaplar> KitapListele()
        {
            //veritabanından Kitaplar tablosundaki değerleri çekiyoruz.
            OleDbDataReader dataread = dal1.DataRead("SELECT * FROM Kitaplar", CommandType.Text);
            if (dataread.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                List<EntityKitaplar> Kitaplar = new List<EntityKitaplar>();
                while (dataread.Read())
                {
                    EntityKitaplar ktp = new EntityKitaplar { KitapID = int.Parse(dataread["KitapID"].ToString()), KitapAdi = dataread["KitapAdi"].ToString(), KitapYazari = dataread["KitapYazari"].ToString(), KitapBaskiYil =int.Parse(dataread["KitapBaskiYil"].ToString()), KitapSayfaSayisi = int.Parse(dataread["KitapSayfaSayisi"].ToString()), KitapDil = dataread["KitapDil"].ToString(), KitapYayinEvi = dataread["KitapYayinEvi"].ToString(), KitapTuru = dataread["KitapTuru"].ToString() };
                    Kitaplar.Add(ktp);
                }
                return Kitaplar;
            }

            return null;
        }

        DATAACCESSLAYER.DataAccessLayer dal2 = new DATAACCESSLAYER.DataAccessLayer();

        public List<EntityKitaplar> KitapListele(string deger, string konum)
         {
            //veritabanından Kitaplar tablosundaki değerleri çekiyoruz.
            OleDbDataReader dataread = dal2.DataRead("SELECT * FROM Kitaplar WHERE " + konum + " ='" + deger + "'", CommandType.Text);
            if (dataread.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                List<EntityKitaplar> Kitaplar = new List<EntityKitaplar>();
                while (dataread.Read())
                {
                    EntityKitaplar ktp = new EntityKitaplar { KitapID = int.Parse(dataread["KitapID"].ToString()), KitapAdi = dataread["KitapAdi"].ToString(), KitapYazari = dataread["KitapYazari"].ToString(), KitapBaskiYil = int.Parse(dataread["KitapBaskiYil"].ToString()), KitapSayfaSayisi = int.Parse(dataread["KitapSayfaSayisi"].ToString()), KitapDil = dataread["KitapDil"].ToString(), KitapYayinEvi = dataread["KitapYayinEvi"].ToString(), KitapTuru = dataread["KitapTuru"].ToString() };
                    Kitaplar.Add(ktp);
                }
                return Kitaplar;
            }

            return null;

        }

        DATAACCESSLAYER.DataAccessLayer dal3 = new DATAACCESSLAYER.DataAccessLayer();
        public int KitapEkle(string KitapAdi, string KitapYazari, int KitapBaskiYil, int KitapSayfaSayisi, string KitapDil, string KitapYayinEvi, string KitapTuru)
        {
            //Kitap eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dal3.EklemeSilmeGuncellemeYap("INSERT into Kitaplar (KitapAdi,KitapYazari,KitapBaskiYil,KitapSayfaSayisi,KitapDil,KitapYayinEvi,KitapTuru) VALUES ('" + KitapAdi + "','" + KitapYazari + "','" + KitapBaskiYil + "','" + KitapSayfaSayisi + "','" + KitapDil + "','" + KitapYayinEvi + "','" + KitapTuru + "')", System.Data.CommandType.Text);
            return sonuc;
        }

        DATAACCESSLAYER.DataAccessLayer dal4 = new DATAACCESSLAYER.DataAccessLayer();
        public int KitapGuncelle(int KitapID, string KitapAdi, string KitapYazari, int KitapBaskiYil, int KitapSayfaSayisi, string KitapDil, string KitapYayinEvi, string KitapTuru)
        {
            //Kitap güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dal4.EklemeSilmeGuncellemeYap("UPDATE Kitaplar SET KitapAdi='" + KitapAdi + "',KitapYazari='" + KitapYazari + "', KitapBaskiYil='" + KitapBaskiYil + "',KitapSayfaSayisi='" + KitapSayfaSayisi + "',KitapDil='" + KitapDil + "', KitapYayinEvi='" + KitapYayinEvi + "', KitapTuru='" + KitapTuru + "' WHERE KitapID=" + KitapID + "", System.Data.CommandType.Text);
            return sonuc;
        }

        DATAACCESSLAYER.DataAccessLayer dal5 = new DATAACCESSLAYER.DataAccessLayer();
        public int KitapSil(int KitapID)
        {
            //Kitabı silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dal5.EklemeSilmeGuncellemeYap("DELETE from Kitaplar where KitapID =" + KitapID + "", System.Data.CommandType.Text);
            return sonuc;
        }
    }
}
