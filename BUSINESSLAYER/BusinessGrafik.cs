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
    public class BusinessGrafik
    {
        DATAACCESSLAYER.DataAccessLayer dal = new DATAACCESSLAYER.DataAccessLayer();
        public int listele()
        {
            //veritabanından kitap sayılarını bir sayaçta tutup geri döndürüyoruz.
            int sayac = 0;
            OleDbDataReader dataread = dal.DataRead("Select KitapID from Kitaplar", CommandType.Text);
            if (dataread.HasRows)
            {
                List<EntityKitaplar> kitaplar = new List<EntityKitaplar>();
                while (dataread.Read())
                {
                    sayac++;
                }
                return sayac;
            }

            return 0;
        }

        DATAACCESSLAYER.DataAccessLayer dal2 = new DATAACCESSLAYER.DataAccessLayer();

        public int alma()
        {
            //veritabanında işlem türü alım olan verilerin sayısını bir sayaçta tutup geri döndürüyoruz.
            int sayac = 0;
            OleDbDataReader dataread = dal.DataRead("Select * from Emanetler where IslemTuru='" + "alım" + "'", CommandType.Text);
            if (dataread.HasRows)
            {
                List<EntityKitaplar> kitaplar = new List<EntityKitaplar>();
                while (dataread.Read())
                {
                    sayac++;
                }
                return sayac;
            }

            return 0;
        }
    }
}
