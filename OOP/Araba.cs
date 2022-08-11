using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Araba
    {
        public int kapiSayisi;
        public string model;
        public string renk;
        public double yakitTuketimi;


        public void Git(string markasi, string modeli)
        {
            Console.WriteLine(markasi + " "+ modeli+ " Gidiyor");
        }


    }
}
