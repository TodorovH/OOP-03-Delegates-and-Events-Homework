using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    public delegate decimal CalculateInterest(decimal sum, double interest, int years);

    public class DelegateCalcInterest
    {
        public static decimal GetSimpleInterest(decimal sum, double interest, int years)
        {
            decimal result = sum * (decimal)(1 + interest * years / 100);
            return result;
        }

        public static decimal GetCompoundInterest(decimal sum, double interest, int years)
        {
            decimal result = sum * (decimal)Math.Pow(1 + (interest / 12 / 100), years * 12);
            return result;
        }
    }
}
