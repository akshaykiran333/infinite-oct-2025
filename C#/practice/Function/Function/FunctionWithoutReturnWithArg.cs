using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class FunctionWithoutReturnWithArg
    {
        static void Addition(int x, int y)
        {
            int res;
            res=x + y;
            Console.WriteLine("x+y="+res);
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter value of x and y");
            x=Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());
            Addition(x,y);
            Console.ReadLine();
        }
    }
}
