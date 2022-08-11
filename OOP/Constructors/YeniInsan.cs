using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructors
{
    public class YeniInsan 
    {

        public string ad;
        public string soyad;
        public Kafa kafa;
        public YeniInsan()
        {

        }

        public YeniInsan(string ad, string soyad, Kafa kafa)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.kafa = kafa;
        }

        public void EkranaYazdir( )
        {
            Console.WriteLine("Kişinin adı " + ad + " " + "Soyadı " + soyad +  " Goz rengi : " + kafa.goz.renk + " Kulagi " + kafa.kulak.sekil + " Burnu " + kafa.burun.sekil);
        }

    }
}
