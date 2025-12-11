using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns_Demo.FacadePattern;
using static DesignPatterns_Demo.SimpleFactory1;

namespace DesignPatterns_Demo
{
    internal class SimpleFactMain          /// Simple Factory
    {
        public static void Main()
        {

            Console.Write("Enter notification type (email/sms/push): ");
            string type = Console.ReadLine();

            Console.Write("Enter message: ");
            string message = Console.ReadLine();

            INotification notification = NotificationFactory.GetNotification(type);
            notification.Send(message);


        }
    }
}