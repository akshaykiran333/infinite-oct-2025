using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Solids_Demo

{
        // Code in SRP
    internal class SRP
    {
        
        public class InvoiceGenerator
        {
            public void GenerateInvoice()
            {
                WriteLine("invoice generated");
            }
        }

       
        public class InvoiceRepository
        {
            public void SaveToDatabase()
            {
                WriteLine( "invoice saved to database");
            }
        }

        
        public class EmailService
        {
            public void SendEmail()
            {
               WriteLine("invoice sent to email");
            }
        }
       
    }
}

