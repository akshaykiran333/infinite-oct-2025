using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectricityMiniPrj.Asp_code
{
    public class ElectricityBill
    {
        private string consumerNumber;
        private string consumerName;
        private int unitsConsumed;
        private double billAmount;

       
        public string ConsumerNumber
        {
            get { return consumerNumber; }
            set
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^EB\d{5}$"))
                    throw new FormatException("Invalid Consumer Number");
                consumerNumber = value;
            }
        }

        public string ConsumerName
        {
            get { return consumerName; }
            set { consumerName = value; }
        }

        public int Units
        {
            get { return unitsConsumed; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Given units is invalid");
                unitsConsumed = value;
            }
        }

        public double BillAmount
        {
            get { return billAmount; }
            set { billAmount = value; }
        }
    }
}