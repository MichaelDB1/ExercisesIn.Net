using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class SumSquare
    {
        private int HigherNumber;
        private int LowerNumber;
        private int Sum;

        public void SetRange(int theLower, int theHigher)
        {
            LowerNumber = theLower;
            HigherNumber = theHigher;
        }

        public void CalculateSquaredSum()
        {
            for(int i = LowerNumber; i <= HigherNumber; i++)
            {
                Sum = Sum + (i * i);
            }
        }

        public int GetSum()
        {
            return Sum;
        }
    }
}
