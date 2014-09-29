using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class InterestCalculator
    {
        private decimal money;
        private double interest;
        private int years;
        private decimal result;

        public InterestCalculator(decimal money, double interest, int years, CalculateInterest d)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.result = d(money, interest, years);
        }

        public decimal Money
        {
            get { return this.money; }
            set { this.money = value; }
        }

        public double Interest
        {
            get { return this.interest; }
            set { this.interest = value; }
        }

        public int Years
        {
            get { return this.years; }
            set { this.years = value; }
        }

        public decimal Result
        {
            get { return this.result; }
            private set { this.result = value; }
        }
    }
}
