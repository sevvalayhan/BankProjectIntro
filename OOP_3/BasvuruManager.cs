using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class BasvuruManager
    {

        public void BasvuruYap(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Hesapla();
            foreach (var logger in loggerServices)
            {
                logger.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
