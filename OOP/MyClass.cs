using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class MyClass
    {
        int x;
        int y;
        private void MesajGoster()
        {
            Console.WriteLine("x'in değeri: " + x + " y'nin değeri: " + y);
        }

        public string  MesajDon()
        {
            return " bir mesaj";
        }

        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool IsBetween(int i)
        {
            if (i > 0) return true;
            return false;
        }
    }
}
