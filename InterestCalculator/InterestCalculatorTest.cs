using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class InterestCalculatorTest
    {
        static void Main(string[] args)
        {
            CalculateInterest d1 = DelegateCalcInterest.GetCompoundInterest;
            CalculateInterest d2 = DelegateCalcInterest.GetSimpleInterest;

            InterestCalculator calc1 = new InterestCalculator(500m, 5.6, 10, d1);
            InterestCalculator calc2 = new InterestCalculator(2500m, 7.2, 15, d2);

            Console.WriteLine("{0:0.0000}", calc1.Result);
            Console.WriteLine();
            Console.WriteLine("{0:0.0000}", calc2.Result);
            Console.WriteLine();
        }
    }
}
