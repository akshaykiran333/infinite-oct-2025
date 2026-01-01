using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverridingDemo
{
    public class CashOnDelivary : PaymentMethod
    {
        public override string Provider => "CashOnDelivary";
        //public override bool ProcessPayment(decimal amount)
        //{
        //    if (amount > 0 && amount <= 10000)
        //    {
        //        Console.WriteLine($"Processing cash on delivery payment of {amount:C} through {Provider}");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("cash on delivery failed:Amount exceeds limit");
        //        return false;
        //    }
        //}
    }
}
