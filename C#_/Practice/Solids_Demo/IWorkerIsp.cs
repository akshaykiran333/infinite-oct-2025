using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Solids_Demo.IEatIsp;
using static Solids_Demo.IWorkLsp;

namespace Solids_Demo
{
    internal class IWorkerIsp
    {
        public class Worker : IWork, IEat
        {
            public void Work()
            {
                Console.WriteLine("Worker is working.");
            }

            public void Eat()
            {
                Console.WriteLine("Worker is eating.");
            }
        }

    }
}
