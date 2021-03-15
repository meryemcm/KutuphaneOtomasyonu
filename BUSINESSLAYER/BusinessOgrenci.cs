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
    public class BusinessOgrenci
    {
        DATAACCESSLAYER.DataAccessLayer dal1 = new DATAACCESSLAYER.DataAccessLayer();
        public List<EntityOgrenci> OgrenciListele()
        {
            //veritabanından Öğrenci tablosundaki değerleri çekiyoruz.
            OleDbDataReader dataread = dal1.DataRead("SELECT * FROM Ogrenci", CommandType.Text);
            if (dataread.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                List<EntityOgrenci> ogrenci1 = new List<EntityOgrenci>();
                while (dataread.Read())
                {
                    EntityOgrenci ogr = new EntityOgrenci { OgrenciID = int.Parse(dataread["OgrenciID"].ToString()), Isim = dataread["Isim"].ToString(), Soyisim=dataread["Soyisim"].ToString(), OgrenciNo = dataread["OgrenciNo"].ToString(), Sinif = int.Parse(dataread["Sinif"].ToString()), Telefon = int.Parse(dataread["Telefon"].ToString()), Email = dataread["Email"].ToString(), Adres=dataread["Adres"].ToString()};
                    ogrenci1.Add(ogr);
                }
                return ogrenci1;
            }

            return null;
        }
        DATAACCESSLAYER.DataAccessLayer dal2 = new DATAACCESSLAYER.DataAccessLayer();

        public List<EntityOgrenci> OgrenciListele(string OgrenciNo)
        {
            //veritabanından Öğrenci tablosundaki değerleri çekiyoruz.
            OleDbDataReader dataread = dal2.DataRead("SELECT * FROM Ogrenci WHERE OgrenciNo='" + OgrenciNo + "'", CommandType.Text);
            if (dataread.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                List<EntityOgrenci> ogrenci1 = new List<EntityOgrenci>();
                while (dataread.Read())
                {
                    EntityOgrenci ogr = new EntityOgrenci { OgrenciID = int.Parse(dataread["OgrenciID"].ToString()), Isim = dataread["Isim"].ToString(), Soyisim = dataread["Soyisim"].ToString(), OgrenciNo = dataread["OgrenciNo"].ToString(), Sinif = int.Parse(dataread["Sinif"].ToString()), Telefon = int.Parse(dataread["Telefon"].ToString()), Email = dataread["Email"].ToString(), Adres = dataread["Adres"].ToString() };
                    ogrenci1.Add(ogr);
                }
                return ogrenci1;
            }

            return null;
        }

        DATAACCESSLAYER.DataAccessLayer dal3 = new DATAACCESSLAYER.DataAccessLayer();
        public int OgrenciEkle(string Isim, string Soyisim, string OgrenciNo,int Sinif,int Telefon, string Email,string Adres)
        {
            //öğrenci eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dal3.EklemeSilmeGuncellemeYap("INSERT into Ogrenci (Isim,Soyisim,OgrenciNo,Sinif,Telefon,Email,Adres) VALUES ('" +  Isim + "','" + Soyisim + "','" + OgrenciNo +"','"+Sinif+ "','" + Telefon + "','" + Email + "','" + Adres + "')", System.Data.CommandType.Text);
            return sonuc;
        }
        
        DATAACCESSLAYER.DataAccessLayer dal4 = new DATAACCESSLAYER.DataAccessLayer();
        public int OgrenciGuncelle(int OgrenciID, string Isim, string Soyisim, string OgrenciNo, int Sinif, int Telefon, string Email, string Adres)
        {
            //öğrenci güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dal4.EklemeSilmeGuncellemeYap("UPDATE Ogrenci SET Isim='" + Isim + "',Soyisim='" + Soyisim + "', OgrenciNo='" + OgrenciNo + "',Sinif='" + Sinif + "',Telefon='" +Telefon + "', Email='" + Email + "', Adres='" + Adres + "' WHERE OgrenciID=" + OgrenciID + "", System.Data.CommandType.Text);
            return sonuc;
        }

        DATAACCESSLAYER.DataAccessLayer dal5 = new DATAACCESSLAYER.DataAccessLayer();
        public int OgrenciSil(int OgrenciID)
        {
            //öğrenciyi silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dal5.EklemeSilmeGuncellemeYap("DELETE from Ogrenci where OgrenciID =" + OgrenciID + "", System.Data.CommandType.Text);
            return sonuc;
        }
    }
}
