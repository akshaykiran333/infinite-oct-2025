using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Text;
using System.Threading.Tasks;
using RemotingLib2;


namespace ServerApp2
{

    internal class Program
    {
        public static void Main()
        {
            HttpChannel channel = new HttpChannel(8085);
            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(ServiceClass),
                "StudentService",
                WellKnownObjectMode.Singleton);

            Console.WriteLine("Server Started on http://localhost:8085/StudentService");
            Console.ReadLine();
        }
    }
}

