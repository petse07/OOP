using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.Odeme_Yontemi_Kotu
{
    public class OdemeIslemi
    {
        public IOdeme  odeme;

        public OdemeIslemi(IOdeme odeme)
        {
            this.odeme = odeme;
        }

        public void OdemeYap(int tutar)
        {
            odeme.OdemeYap(tutar);
        }
    }
}
