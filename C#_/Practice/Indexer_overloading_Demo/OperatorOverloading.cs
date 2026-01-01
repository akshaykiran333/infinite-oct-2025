using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_overloading_Demo
{
    internal class OperatorOverloading

    {
        static void Main(string[] args)
        {
            complex c1 = new complex(12, 50);
            complex c2 = new complex(6, 7);
            complex sum = c1 + c2;
            complex sub = c1 - c2;
            complex mul = c1 * c2;
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);
            Console.WriteLine($"c1==c2 : {c1==c2}");
            Console.WriteLine($"c1!=c2 : {c1!=c2}");
            Console.WriteLine($"Equals method{c1.Equals(c2)}");
            Console.ReadLine();
        }
    }
    public class complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }
        public string lastOperator = "";
        public complex(int real, int imaginary)
        {
            Real = real;
             Imaginary = imaginary;
        }
        public static complex operator +(complex c1, complex c2)
        {
            complex result = new complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
            result.lastOperator = "+(Addition)";
            return result;
        }
        public static complex operator -(complex c1, complex c2)
        {
            complex result = new complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
            result.lastOperator = "-(Subtraction)";
            return result;
        }
        public static complex operator *(complex c1, complex c2)
        {
            complex result = new complex(c1.Real * c2.Real, c1.Imaginary * c2.Imaginary);
            result.lastOperator = "*(Multiplication)";
            return result;
        }
        public static bool operator ==(complex c1,complex c2)
        {
            return (c1.Real == c2.Real && c1.Imaginary == c2.Imaginary);
        }
        public static bool operator !=(complex c1, complex c2)
        {
            return !(c1==c2);
        }
        public override bool Equals(object obj)
        {
            if (obj is complex other)
            {
                return this.Real == other.Real && this.Imaginary == other.Imaginary;

            }
            return false;
        }
        public override string ToString()
        {
            return $"Operation:{lastOperator} -> Result={Real} + {Imaginary}i";
        }
    }
}
