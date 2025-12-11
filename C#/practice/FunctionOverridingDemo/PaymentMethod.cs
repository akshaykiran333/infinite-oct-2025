using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverridingDemo
{
    public class PaymentMethod
    {
        public virtual string Provider => "Generic payment provider";
        public virtual bool ProcessPayment(decimal amount)
        {
            if (amount>0)
            {
                Console.WriteLine($"Processing payment of{amount:C} through {Provider}");
                return true;
            }
            else
                return false;
        }
        public void samplePayment()
        {
            Console.WriteLine("This is sample payment method");
        }
    }
    
}
