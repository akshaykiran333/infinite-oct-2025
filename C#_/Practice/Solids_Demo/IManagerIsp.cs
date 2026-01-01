using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Solids_Demo.IEatIsp;
using static Solids_Demo.IManageLsp;
using static Solids_Demo.IWorkLsp;

namespace Solids_Demo
{
    internal class IManagerIsp
    {
        public class Manager : IWork, IEat, IManageTeam
        {
            public void Work()
            {
                Console.WriteLine("Manager is working.");
            }

            public void Eat()
            {
                Console.WriteLine("Manager is eating.");
            }

            public void ManageTeam()
            {
                Console.WriteLine("Manager is managing the team.");
            }
        }

    }
}
