using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            connectedArchitecture ca = new connectedArchitecture();
            Console.WriteLine("Enter the start date: ");
            DateTime startdate= DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end date: ");
            DateTime enddate = DateTime.Parse(Console.ReadLine());

            ca.getTranscations(startdate, enddate);

            Console.ReadLine();
        }
    }
}
