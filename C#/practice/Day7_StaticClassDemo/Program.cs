using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_StaticClassDemo
{
    static class MathHelper
    {
        public static double pi = 3.14149;
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(int a, int b)
        {
            if (b == 0)

                throw new DivideByZeroException("Denominator cannot be zero");
            return (double) a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = MathHelper.Add(20, 5);
            Console.WriteLine("Addition"+ result);
            result= MathHelper.Sub(20, 5);
            Console.WriteLine("Subtraction"+result);
            result=MathHelper.Multiply(20, 5); 
            Console.WriteLine("Multiplication" + result);
            result = MathHelper.Divide(20, 5);
            Console.WriteLine("Division" + result);
        }
    }
}
