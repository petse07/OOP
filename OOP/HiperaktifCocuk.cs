using OOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class HiperaktifCocuk : Cocuk, IAskereGit
    {
        public void Asker(string adi)
        {
            Console.WriteLine(adi + " " + "askere gidiyor");
        }
    }
}
