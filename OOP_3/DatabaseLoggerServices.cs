using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class DatabaseLoggerServices : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı");
        }
    }


}
