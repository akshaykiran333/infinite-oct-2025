using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace assigThread
{
    internal class Factorial
    {
        public static void Main(string[] args)
        {
            WriteLine("Enter the number to calculate the factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Task<int> factorialTask = Task.Run(() =>
            {
                int result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                return result;
            });

            int factorial = factorialTask.Result;

            WriteLine($"Factorial of {number} is: {factorial}");

        }
    }
}
