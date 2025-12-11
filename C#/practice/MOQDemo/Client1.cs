using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQDemo
{
    public class Client1
    {
        IMath math;
        public Client1(IMath m)
        {
            math = m;
        }


        public string AddClient1(int x , int y)
        {
            return math.Add (x, y);
        }

        internal object AddClient(string v)
        {
            throw new NotImplementedException();
        }
    }
}
