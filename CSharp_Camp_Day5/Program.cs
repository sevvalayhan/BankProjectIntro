using System;

namespace CSharp_Camp_Day5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new GercekMusteri();
            var customer2  = new TuzelMusteri();
        
            var customerManager = new CustomerManager();

            customerManager.Add(customer);
            customerManager.Add(customer2);
        
        }
    }
    
}
