using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class ParamsDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfIntegers(10,20));
            Console.WriteLine(SumOfIntegers(30,40,50));
            Console.WriteLine(SumOfIntegers(60,70,80,90));
            Console.ReadLine();

        }
        static int SumOfIntegers(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers) 
            {
                sum += num;
            }
            return sum;
        }

    }
}
