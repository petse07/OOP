using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Insan
    {   //Başlangıç Scope


        //access modifiers (public, private..), değişken tipi, deişken adı
        public string ad;   //
        public string soyad;
        public int yas;
        public double maas;
        public bool cinsiyet;
        public static int boy;


        //methodlar 2'ye ayrılırlar
        //access modifiers, dönüş tipi, method adı()
        public void Uyu(string adi, string soyadi)
        {
            Console.WriteLine(adi +" " + soyadi+ " Uyuyor");
        }

        public int yashesap(int dogumtarihi)
        {
            int hesaplananyas = 0;
            hesaplananyas = 2022 - dogumtarihi;
            return hesaplananyas;

        }


        public void  yazdir(string ad, string soyad)
        {
            Console.WriteLine("Kişinin adı " + ad+ " kisinin soyadı " + soyad);
        }

        public Insan()
        {

        }


        public Insan(string ad, string soyad)
        {

        }

    }   //bitiş scope
}
