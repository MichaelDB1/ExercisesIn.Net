using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class SumOf7
    {
        private int LowerNumber;
        private int HigherNumber;
        private int Sum;

        public void SetRange(int theLower, int theHigher)
        {
            LowerNumber = theLower;
            HigherNumber = theHigher;
        }

        public void Calculate7Sum()
        {
            for(int i = LowerNumber; i <= HigherNumber; i++)
            {
                if( i % 7 <= 0)
                {
                    Sum = Sum + i;
                }
            }
        }

        public int Get7Sum()
        {
            return Sum;
        }

        public Double GetAverage()
        {
            Double average = (Double)Sum * 7  /  (HigherNumber - LowerNumber);
            return average;
        }
    }
}
