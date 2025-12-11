using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Solids_Demo.IDatabaseDip;
using static Solids_Demo.IManagerIsp;
using static Solids_Demo.IWorkerIsp;
using static Solids_Demo.OcpDemo;
using static Solids_Demo.SqlDatabaseDip;
using static Solids_Demo.SRP;
using static System.Console;

namespace Solids_Demo
{
    internal class Program
    {
        // SRP

        public static void Main(string[] args)
        {
            var generator = new InvoiceGenerator();
            var repository = new InvoiceRepository();
            var emailService = new EmailService();


            generator.GenerateInvoice();
            repository.SaveToDatabase();
            emailService.SendEmail();



            var service = new DiscountService();

            decimal vipDiscount = service.ApplyDiscount(new VipDiscount());
            decimal empDiscount = service.ApplyDiscount(new EmployeeDiscount());
            decimal noDiscount = service.ApplyDiscount(new NoDiscount());

            WriteLine("Vip Discount: " + vipDiscount);
            WriteLine("Emp Discount: " + empDiscount);
            WriteLine("No Discount: " + noDiscount);



            IBonus permanentEmployee = new PermanentEmployee
            {
                EmpId = 101,
                EmpName = "Akshay",
                EmpDept = "SE"
            };

            ContractEmployee contractEmployee = new ContractEmployee
            {
                EmpId = 102,
                EmpName = "Kiran",
                EmpDept = "ASE"
            };

            Console.WriteLine($"Permanent Employee Bonus: {permanentEmployee.GetBonus(5000):C}");
            Console.WriteLine("Contract Employee does not receive a bonus.");

            Worker worker = new Worker();
            worker.Work();
            worker.Eat();

            Manager manager = new Manager();
            manager.Work();
            manager.Eat();
            manager.ManageTeam();


            IDatabaseDip database = new IDatabaseDip();
            OrderProcessor processor = new OrderProcessor(database);

            processor.Process();
            Console.ReadLine();
        }
        
    }

}
           
