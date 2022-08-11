using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructors
{
    public class Kafa
    {
        public Goz goz;
        public Kulak kulak;
        public Burun burun;

        public Kafa()
        {

        }


        public Kafa(Goz goz, Kulak kulak, Burun burun)
        {
            this.goz = goz;
            this.kulak = kulak;
            this.burun = burun;
        }
    }
}
