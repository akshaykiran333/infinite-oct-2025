using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solids_Demo
{
    public class IDatabaseDip
    {
        internal void save()
        {
            throw new NotImplementedException();
        }

        internal interface IDatabase
        {
            void save();
            //void Save();
        }
    }
}
