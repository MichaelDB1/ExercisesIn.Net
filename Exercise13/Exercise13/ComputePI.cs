using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class ComputePI
    {
        private Double Sum = 0.0;
        private int MaxNumber;

        public void SetMax(int theMax)
        {
            MaxNumber = theMax;
        }

        public void CalcPie()
        {
            for (int increaser = 1; increaser <= MaxNumber; increaser += 2)
            {
                if (increaser % 4 == 1)
                {
                    Sum += (Double)1 / increaser;
                }
                else if (increaser % 4 == 3)
                {
                    Sum -= (Double)1 / increaser;
                }
                else
                {
                    Console.WriteLine("Bugger it's broken");
                }
            }
        }

        public double GetSum()
        {
            return Sum*4;
        }

        public double ComputePi()
        {
            return (Sum * 4) - Math.PI;
        }
        
    }
}
