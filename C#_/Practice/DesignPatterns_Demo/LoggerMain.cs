using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo
{
    internal class LoggerMain
    {
        static void Main(string[] args)
        {

            Logger log = Logger.Instance;

            log.WriteLog("Application started");
            log.WriteLog("Log message number 1");
            log.WriteLog("Application ended");

            Console.WriteLine("Logs written successfully!");
            Console.ReadLine();
        }
    }
}

