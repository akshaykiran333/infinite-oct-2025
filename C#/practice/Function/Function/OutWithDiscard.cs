using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class OutWithDiscard
    {
        static void Main(string[] args)
        {
            Calculate(10, 5, out int sum, out _, out int product);
            Console.WriteLine("sum" + sum);
            Console.WriteLine("product" + product);
        }
        static void Calculate(int a, int b, out int sum, out int differnce, out int product)
        {
            sum = a + b;
            differnce = a - b;
            product = a * b;
        }

    }
}
