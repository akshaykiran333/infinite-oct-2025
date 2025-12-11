using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                Addition();
                Console.ReadLine();
            }
            static void Addition()
            {
                int num1, num2, sum;
                Console.WriteLine("enter the first number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the second number");
                num2 = Convert.ToInt32(Console.ReadLine());
                sum = num1 + num2;
                Console.WriteLine("sum of numbers" + sum);
            }
    }
}
