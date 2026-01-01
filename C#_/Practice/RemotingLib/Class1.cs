using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingLib
{
    
    public class ServiceClass : MarshalByRefObject, IMyinter
    {
        

        public string Show(string name)
        {
            Console.WriteLine($"Message Recevied from the cline is {name}");
            return $"Hello {name} How Are You!!";
        }
    }
}
