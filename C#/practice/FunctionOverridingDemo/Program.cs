using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverridingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment creditcardPayment = new CreditCardPayment();
            creditcardPayment.ProcessPayment(4000);
            creditcardPayment.samplePayment();
            Console.WriteLine($"{creditcardPayment.Provider}");
            CashOnDelivary cashOnDelivary = new CashOnDelivary();
            cashOnDelivary.ProcessPayment( 8000);
            Console.ReadLine();
        }
    }
}
