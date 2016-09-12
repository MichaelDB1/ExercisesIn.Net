using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class SumAndAverage
    {
        private int LowerNumber;
        private int HigherNumber;
        private int Sum = 0;

        public void SetRange(int theLower, int theHigher)
        {
            LowerNumber = theLower;
            HigherNumber = theHigher;
        }

        public void CalculateSum()
        {
            for(int i = LowerNumber; i <= HigherNumber; i++)
            {
                Sum = Sum + i;
            }
        }

        public int GetSum()
        {
            return Sum;
        }

        public double GetAverage()
        {
            double average = (double)Sum / (HigherNumber - LowerNumber);
            return average;
        }
    }
}
