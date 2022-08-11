using OOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Akillicocuk : Cocuk, IAskereGit, IEhliyetAl,IKulubeGit
    {
        public void Asker(string adi)
        {
            Console.WriteLine(adi + " " + "askere gidiyor");
        }

        public void Ehliyet(string adi)
        {
            Console.WriteLine(adi + " " + "ehliyet alıyor");
        }

        public void Kulüp(string adi)
        {
            Console.WriteLine(adi + " " + "kulübe gidiyor");
        }
    }


}
