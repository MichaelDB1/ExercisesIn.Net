using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class SumAndAverage
    {
        private int LowerNumber;
        private int HigherNumber;
        private int Sum;

        public void SetRange(int theLower, int theHigher)
        {
            LowerNumber = theLower;
            HigherNumber = theHigher;
        }
        
        public void CalculateSum()
        {
            for(int i = LowerNumber; i <= HigherNumber; i++)
            {
                if( i % 2 > 0)
                {
                    Sum = Sum + i;
                }
            }
        }

        public int GetOddSum()
        {
            return Sum;
        }

        public Double getAverage()
        {
            Double average = (Double)Sum * 2 / (HigherNumber - LowerNumber);
            return average;
        }
    }
}
