using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo
{
    internal class SimpleFactory1
    {
        public interface INotification
        {
            void Send(string message);
        }

        public class EmailNotification : INotification
        {
            public void Send(string message)
            {
                Console.WriteLine("Email sent: " + message);
            }
        }

        public class SmsNotification : INotification
        {
            public void Send(string message)
            {
                Console.WriteLine("SMS sent: " + message);
            }
        }

        public class PushNotification : INotification
        {
            public void Send(string message)
            {
                Console.WriteLine("Push notification sent: " + message);
            }
        }

        public static class NotificationFactory
        {
            public static INotification GetNotification(string type)
            {
                switch (type.ToLower())
                {
                    case "email":
                        return new EmailNotification();
                    case "sms":
                        return new SmsNotification();
                    case "push":
                        return new PushNotification();
                    default:
                        throw new ArgumentException("Invalid notification type.");
                }
            }

        }
    }
}
