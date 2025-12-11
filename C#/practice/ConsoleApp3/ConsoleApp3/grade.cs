using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class grade
    {
        static void Main()
        {

            Console.Write("enter students name");
            string name = Console.ReadLine();
            Console.Write("enter students marks");
            double marks = Convert.ToDouble(Console.ReadLine());
            string grades = Console.ReadLine();
            if (marks >= 91)
                grades = "A+";
            else if (marks >= 80)
                grades = "A";
            else if (marks >= 70)
                grades = "B";
            else if (marks >= 60)
                grades = "C";
            else if (marks >= 50)
                grades = "D";
            else
                grades = "F";
            Console.WriteLine("\nSTUDENT RESULT");
            Console.WriteLine($"Name  : {name}");
            Console.WriteLine($"Marks : {marks}");
            Console.WriteLine($"Grade : {grades}");
            Console.WriteLine("*********");
        }
    }
}