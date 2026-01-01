using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class FunctionWithReturnWithArg
    {
        static void Main(string[] args)
        { 
                Console.WriteLine("Enter the num1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the num2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The Addition is: " + Addition(num1, num2));
            }
            static int Addition(int n1, int n2)
            {
                return (n1 + n2);
            }
        }
    }

