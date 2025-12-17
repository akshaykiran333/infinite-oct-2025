using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUD obj = new CRUD();
            //obj.showallemployees();
            //obj.SearchRecord();
            //obj.AddRecord();
            //obj.DeleteRecord();
            //obj.sqlquerydemo();
            obj.DMLDemo();
        }
    }
}
