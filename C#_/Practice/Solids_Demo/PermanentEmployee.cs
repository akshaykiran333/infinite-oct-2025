using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solids_Demo
{
   

        internal class PermanentEmployee : EmployeeLsv, IBonus
        {
            public decimal GetBonus(decimal salary)
            {
                return salary * 0.20m;
            }
        }
    
}
