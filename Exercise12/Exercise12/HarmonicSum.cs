using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class HarmonicSum
    {
        private int MaxNumber;
        private Double Left2Right = 0.0;
        private Double Right2Left = 0.0;

        public void SetMax(int theMax)
        {
            MaxNumber = theMax;
        }

        public void CalcLeft2Right()
        {
            for(int i= 1; i <= MaxNumber; i++)
            {
                Left2Right = Left2Right + 1.0 / i;
            }
        }

        public void CalcRight2Left()
        {
            for(int i= MaxNumber; i >= 1; i--)
            {
                Right2Left = Right2Left + 1.0 / i;
            }
        }

        public Double GetLeft2Right()
        {
            return Left2Right;
        }

        public Double GetRight2Left()
        {
            return Right2Left;
        }

        public Double GetDifference()
        {
            Double difference = Right2Left - Left2Right;
            return difference;
        }
    }
}
