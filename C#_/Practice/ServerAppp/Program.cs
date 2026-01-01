using RemotingLib;                     // REQUIRED
using RemotingTrn;                     // REQUIRED
using System;
using System.Runtime.Remoting;        // REQUIRED
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace ServerAppp
{
    public class ServerClass
    {
        public static void Main()
        {
            TcpChannel channel = new TcpChannel(8085);
            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownServiceType(
    typeof(ServiceClass),
    "Hi",
    WellKnownObjectMode.Singleton);


            Console.WriteLine("Server started on port 8085");
            Console.ReadLine();
        }
    }
}
