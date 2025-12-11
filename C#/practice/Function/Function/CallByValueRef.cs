using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class CallByValueRef
    {
        static void Main(string[] args)

        {
            int a, b;
            a = 10; b = 20;
            Console.WriteLine("call by value");
            Console.WriteLine("value of A before calling method value" + a);
            MethodValue(a);
            Console.WriteLine("after calling methodvalue A" + a);

            Console.WriteLine("call by reference");
            Console.WriteLine("value of B before calling method ref" + b);
                MethodRef(ref b);
            Console.WriteLine("after calling methodref B" + b);

        }
        static void MethodValue(int a)
        {
            a = a + 10;
            Console.WriteLine("value of A in MethodValue"+a);
        }
        static void MethodRef(ref int b)
        {
            b = b + 10;
            Console.WriteLine("value of B in MethodRef" + b);
        }

    }
}
