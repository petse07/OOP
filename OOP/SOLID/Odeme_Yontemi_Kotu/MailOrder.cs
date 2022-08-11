using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.Odeme_Yontemi_Kotu
{
    public class MailOrder: IOdeme
    {
        public void OdemeYap(int tutar)
        {
            Console.WriteLine("Mail order ile " + tutar + " ödeme yapıldı");
        }
    }
}
