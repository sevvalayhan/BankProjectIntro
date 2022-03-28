using System;
using System.Collections.Generic;

namespace OOP_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditManager tasitCreditManager = new TasitCreditManager();
            var konutCreditManager = new KonutCreditManager();
            var esnafCreditManager = new EsnafCreditManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerServices();
            ILoggerService fileLoggerService = new FileLoggerServices();
            ILoggerService smsLoggerServices = new SmsLoggerService();
            var logger = new List<ILoggerService>() { fileLoggerService,smsLoggerServices};


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitCreditManager,logger);



            var liste = new List<ICreditManager>() { ihtiyacCreditManager,tasitCreditManager,konutCreditManager};

            basvuruManager.KrediOnBilgilendirmesiYap(liste);






        }
    }
}
