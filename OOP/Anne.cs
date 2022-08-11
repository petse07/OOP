using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Interface;

namespace OOP
{
    public class Anne : Insan, IOzellik
    {
        public void Oku(string adi)
        {
            Console.WriteLine(adi + " okuyor");
        }
    }
}
