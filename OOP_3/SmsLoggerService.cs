﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms ile loglandı");
        }
    }
}
