using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Solids_Demo
{
    internal class OcpDemo
    {
        public interface IDiscount
        {
            decimal GetDiscount();
        }
        public class VipDiscount : IDiscount
        {
            public decimal GetDiscount()
            {
                return 0.8m;
            }
        }
        public class EmployeeDiscount : IDiscount
        {
            public decimal GetDiscount()
            {
                return 0.5m;
            }
        }
        public class NoDiscount : IDiscount
        {
            public decimal GetDiscount()
            {
                return 0m;
            }
        }
        public class DiscountService
        {
            public decimal ApplyDiscount(IDiscount discountType)
            {
                return discountType.GetDiscount();
            }
        }
       
    }
}
