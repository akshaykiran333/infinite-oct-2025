using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Solids_Demo.IDatabaseDip;

namespace Solids_Demo
{

    public class OrderProcessor :IDatabaseDip
    {
        private readonly IDatabaseDip _database;

        public OrderProcessor(IDatabaseDip database)
        {
            _database = database;
        }

        public void Process()
        {
            _database.save();
        }

    }
}
