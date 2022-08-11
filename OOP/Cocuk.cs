using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Cocuk : Insan
    {
        public string sifat;
        
        public void Sifatyaz(string ad, string soyad, string sifati)
        {
            Console.WriteLine(ad + " " + soyad + " " + "akıllıdır");
        }

    }
}
