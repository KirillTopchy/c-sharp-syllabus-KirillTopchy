using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSales = 0;
        private double _commissionRate;
        public Commission(string eName, string eAddress, string ePhone, string socSecNumber,
            double rate, double commissionRate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commissionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            var commissionEarned = _totalSales * _commissionRate;
            var payment = base.Pay() + commissionEarned;
            _totalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales: " + _totalSales;
            return result;
        }
    }
}
