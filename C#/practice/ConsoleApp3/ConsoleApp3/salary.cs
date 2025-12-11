using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class salary
    {
        static void Main(string[] args)
        {
            //   int employee_id;
            //   string designation;
            //   decimal salary;
            //  Console.WriteLine("enter employee_id,designation,salary");
            //  employee_id=Convert.ToInt32(Console.ReadLine());
            //   decimal=Convert.ToDecimal(Console.ReadLine());
            //switchhh
            //Console.WriteLine("choose the option 1.add,2.sub,3.multiply4.div");
            //  int choice=Convert.ToInt32(Console.ReadLine());
            // double num1, num2;
            //Console.WriteLine("enter the first number");
            // num1=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the second number");
            //num2=Convert.ToDouble(Console.ReadLine());
            //switch (choice)
            //{
            //     case 1:
            //        Console.WriteLine("addition is" + (num1 + num2));
            //        break;
            //     case 2:
            //        Console.WriteLine("subtraction is" +(num1 - num2));
            //         break;
            //     case 3:
            //          Console.WriteLine("multiplication is " + (num1 * num2));
            //         break;
            //     case 4:
            //         if (num2 != 0)
            //             Console.WriteLine("division is" + (num1 / num2));
            //         else
            //             Console.WriteLine("error:division by 0 not allowed");
            //         break;

            // }
            //Console.ReadLine();
            Console.WriteLine("enter salary amount");
            double  salary=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter years of experience");
            int years = Convert.ToInt32(Console.ReadLine());
            int bonus = 0;
            if (years < 5)
            {
                bonus = 5;
            }
            else if (years >=5 && years<10)
            {
                bonus = 10;
            }
            else
            {
                bonus=20;
            }
            double bonusAmount = (salary * bonus)/100;
            double finalSalary = (salary+bonusAmount);
            Console.WriteLine($"\nYears of Experience: {years}");
            Console.WriteLine($"Basic Salary: {salary:C}");
            Console.WriteLine($"Bonus ({bonus}%): {bonusAmount:C}");
            Console.WriteLine($"Final Salary: {finalSalary:C}");





        }
    }
}
