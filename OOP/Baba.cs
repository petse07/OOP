
using OOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Baba : Insan, IOzellik, IOzellik2
    {
        public void dinle(string adi)
        {
            Console.WriteLine(adi + " dinliyor");
        }

        public void Oku(string adi)
        {
            Console.WriteLine(adi + " okuyor");
        }


    }
}
