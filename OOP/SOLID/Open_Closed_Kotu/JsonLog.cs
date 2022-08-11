﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.Open_Closed_Kotu
{
    public class JsonLog:ILogger
    {
        public bool Log(string value)
        {
            Console.WriteLine("Json loga a " + value + " yazıldı..");
            return true;
        }
    }
}
