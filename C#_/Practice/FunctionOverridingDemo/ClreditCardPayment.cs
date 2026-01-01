using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverridingDemo
{
   public class CreditCardPayment : PaymentMethod
    {
        public override string Provider => "Credit Card Provider";
        public override bool ProcessPayment(decimal amount)
        {
            base.ProcessPayment(999);
            if (amount > 0 && amount<=5000)
            {
                Console.WriteLine($"processing credit card payment of {amount:C} through {Provider}");
                return true;           
            }
            else
            {
                Console.WriteLine("credit card payment failed: Amount exceeds limit");
                return false;
            }
        }
    }
}
