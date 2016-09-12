using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product1toN
{
    class Product1toN
    {

        private int LowerNumber;
        private int HigherNumber;
        private long Sum=1;


        public void SetRange(int theLower, int theHigher)
        {
            LowerNumber = theLower;
            HigherNumber = theHigher;
        }

        public void Reset()
        {
            Sum = 1;
        }

        public void CalcSum()
        {
            int min = LowerNumber;
            int max = HigherNumber;
            while (min <= max)
            {
                Sum *= min;
                min++;
            }
        }

        public long GetSum()
        {
            return Sum;
        }

        public int GetMin()
        {
            return LowerNumber;
        }

        public int GetMax()
        {
            return HigherNumber;
        }

    }
}
