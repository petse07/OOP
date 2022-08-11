using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Matematik
    {
        //iki sayısının toplamını alan ve int tipinde değer dönen method
        public int Topla(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public int Topla(int sayi1, int sayi2, int sayi3)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2 + sayi3;
            return sonuc;
        }

    }
}
