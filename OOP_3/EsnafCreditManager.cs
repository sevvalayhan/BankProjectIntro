using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class EsnafCreditManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("esnaf kredisi hesaplandı");
        }
    }
}
