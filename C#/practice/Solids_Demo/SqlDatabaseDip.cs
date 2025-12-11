using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solids_Demo
{
    public class SqlDatabaseDip
    {
        public class SqlDatabase : IDatabaseDip
        {
            public void save()
            {
                Console.WriteLine("Saving to Sql");
            }
        }
    }
}
