using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_but_really_6_ooops
{
    class SumAndAverage
    {
        private int LowerNumber;
        private int HigherNumber;
        private int Sum;

        public void SetRaange(int theLower, int theHigher)
        {
            LowerNumber = theLower;
            HigherNumber = theHigher;
        }

        public void CalculateSum()
        {
            int min = LowerNumber;
            int max = HigherNumber;
            while (min <= max)
            {
                Sum = Sum + min;
                min++;
            }
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

