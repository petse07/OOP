using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID.Open_Closed_Kotu
{
    public class Logger
    {
        public ILogger logger;



        public Logger(ILogger logger)
        {
            this.logger = logger;
        }

        public void Log(string value)
        {
            logger.Log(value);
        }
    }
}
