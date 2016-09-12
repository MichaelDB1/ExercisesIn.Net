using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class SumAdnAveragecs
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
            int min = LowerNumber;
            int max = HigherNumber;
            do
            {
                Sum = Sum + min;
                min++;
            }
            while (min <= max);
        }
        
        public int GetSum()
        {
            return Sum;
        }

        public Double GetAverage()
        {
            Double average = (Double)Sum / (HigherNumber - LowerNumber);
            return average;
        }
    }
}
