using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace DATAACCESSLAYER
{
    public class AccessBaglanti
    {
        
        OleDbConnection baglanti;
        // veri tabanı bağlantısının açık olup olmadığını kontrol ediyoruz.
        public OleDbConnection BaglantiKontrol
        {
            get
            {
                if (baglanti != null)
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    return baglanti;
                }
                else
                {
                    baglanti = new OleDbConnection(Provider());
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    return baglanti;
                }

            }

        }

        //BaglantiAyarları sınıfından veritabanı adresimizi almak için bir bağlantı cümlesi oluşturuyoruz.
        private string Provider()
        {
            return BaglantiAyarları.CONNECTION_STRING;
        }


    }
}

