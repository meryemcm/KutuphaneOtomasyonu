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
    public class BusinessEmanetler
    {
        DATAACCESSLAYER.DataAccessLayer dal = new DATAACCESSLAYER.DataAccessLayer();
        public List<EntityEmanetler>EmanetlerYukle ()
        {
            OleDbDataReader dataread = dal.DataRead("Select * from Emanetler", CommandType.Text); //Dataaccesslayer katmanı yardımıyla Emanetler tablosundaki verilerimizi çekiyoruz.
            if (dataread.HasRows)
            {
                List<EntityEmanetler> EmanetKayit = new List<EntityEmanetler>();
                while (dataread.Read())
                {
                    //tablodaki verileri çekip yukle listesine ekliyoruz. 
                    EntityEmanetler yukle = new EntityEmanetler { KitapID = int.Parse(dataread["KitapID"].ToString()), OgrenciID = int.Parse(dataread["OgrenciID"].ToString()), EmanetVermeTarihi = dataread["EmanetVermeTarihi"].ToString(), EmanetGeriAlmaTarihi = dataread["EmanetGeriAlmaTarihi"].ToString(), EmanetİslemTarihi = dataread["EmanetİslemTarihi"].ToString(), Borc = dataread["Borc"].ToString(), IslemTuru = dataread["IslemTuru"].ToString() };

                    EmanetKayit.Add(yukle);
                }
                return EmanetKayit; //listeyi geri yolluyoruz.
            }

            return null;
        }

        DATAACCESSLAYER.DataAccessLayer dal1 = new DATAACCESSLAYER.DataAccessLayer();
        public int TabloEmanetDuzenleme(int KitapID, int OgrenciID,DateTime EmanetİslemTarihi, string IslemTuru)
        {
            //Emanetler tablosundaki verileri güncellemek için sorgumuzu gönderiyoruz.
            int Sonuc = dal1.EklemeSilmeGuncellemeYap("update Emanetler set IslemTuru='" + IslemTuru + "', EmanetİslemTarihi='" + EmanetİslemTarihi + "' where OgrenciID=" + OgrenciID + " and KitapID = " + KitapID + "", System.Data.CommandType.Text);

            return Sonuc;
        }

        public List<EntityEmanetler> KayitListeleme(int OgrenciNo)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            OleDbDataReader dataread = dal.DataRead("Select * from Emanetler where OgrenciID in (select OgrenciID from Ogrenci where OgrenciNo ='" + OgrenciNo + "') ", CommandType.Text);
            if (dataread.HasRows)
            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<EntityEmanetler> EmanetKayit = new List<EntityEmanetler>();
                while (dataread.Read())
                {



                    EntityEmanetler kaydet = new EntityEmanetler { KitapID = int.Parse(dataread["KitapID"].ToString()), OgrenciID = int.Parse(dataread["OgrenciID"].ToString()), EmanetVermeTarihi = dataread["EmanetVermeTarihi"].ToString(), EmanetGeriAlmaTarihi = dataread["EmanetGeriAlmaTarihi"].ToString(), EmanetİslemTarihi = dataread["EmanetİslemTarihi"].ToString(), Borc = dataread["Borc"].ToString(), IslemTuru = dataread["IslemTuru"].ToString() };

                    EmanetKayit.Add(kaydet);
                }
                return EmanetKayit;
            }

            return null;
        }

        DATAACCESSLAYER.DataAccessLayer dal2 = new DATAACCESSLAYER.DataAccessLayer();
        public int EmanetIslemleri(int KitapID, int OgrenciID,  DateTime EmanetVermeTarihi, DateTime EmanetGeriAlmaTarihi, string IslemTuru)
        {
            //emanet vermek için Emanetler tablosuna gerekli verileri yolluyoruz.
            int Sonuc = dal2.EklemeSilmeGuncellemeYap("insert into Emanetler (KitapID,OgrenciID,EmanetVermeTarihi,EmanetGeriAlmaTarihi,IslemTuru) values ('" + KitapID + "','" + OgrenciID + "','" + EmanetVermeTarihi + "','" + EmanetGeriAlmaTarihi + "','" + IslemTuru + "')", System.Data.CommandType.Text);
            return Sonuc;
        }

        DATAACCESSLAYER.DataAccessLayer dal3 = new DATAACCESSLAYER.DataAccessLayer();
        public List<EntityEmanetler> OgrenciEmanetListeleme(string deger)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            OleDbDataReader dataread = dal3.DataRead("Select * from Emanetler where OgrenciID in (Select OgrenciID from Ogrenci where OgrenciNo='" + deger + "')", CommandType.Text);
            if (dataread.HasRows)
            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<EntityEmanetler> EmanetKayit = new List<EntityEmanetler>();
                while (dataread.Read())
                {
                    EntityEmanetler kayit_etme = new EntityEmanetler { KitapID = int.Parse(dataread["KitapID"].ToString()), OgrenciID = int.Parse(dataread["OgrenciID"].ToString()), EmanetVermeTarihi = dataread["EmanetVermeTarihi"].ToString(), EmanetGeriAlmaTarihi = dataread["EmanetGeriAlmaTarihi"].ToString(), EmanetİslemTarihi = dataread["EmanetİslemTarihi"].ToString(), Borc = dataread["Borc"].ToString(), IslemTuru = dataread["IslemTuru"].ToString() };

                    EmanetKayit.Add(kayit_etme);
                }
                return EmanetKayit;
            }

            return null;
        }
        
        DATAACCESSLAYER.DataAccessLayer dal4 = new DATAACCESSLAYER.DataAccessLayer();
        public List<EntityEmanetler> KayitListeleme2(string deger, string konum)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
            OleDbDataReader dataread = dal4.DataRead("Select * from Emanetler where KitapID in (Select KitapID from Kitaplar where " + konum + " ='" + deger + "')", CommandType.Text);
            if (dataread.HasRows)
            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<EntityEmanetler> EmanetKayit = new List<EntityEmanetler>();
                while (dataread.Read())
                {
                    EntityEmanetler kayit_etme = new EntityEmanetler { KitapID = int.Parse(dataread["KitapID"].ToString()), OgrenciID = int.Parse(dataread["OgrenciID"].ToString()), EmanetVermeTarihi = dataread["EmanetVermeTarihi"].ToString(), EmanetGeriAlmaTarihi = dataread["EmanetGeriAlmaTarihi"].ToString(), EmanetİslemTarihi = dataread["EmanetİslemTarihi"].ToString(), Borc = dataread["Borc"].ToString(), IslemTuru = dataread["IslemTuru"].ToString() };

                    EmanetKayit.Add(kayit_etme);
                }
                return EmanetKayit;
            }

            return null;
        }


    }
}


