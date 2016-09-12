using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Fibonacci
    {
        private int MyMax;
        private int Num1 = 1;
        private int Num2;
        private double Total;
        StringBuilder Sb = new StringBuilder();

        public void SetMax(int theMax)
        {
            MyMax = theMax;
        }

        public void CalculateMyFib()
        {
            for(int i=0; i < MyMax; i += 2)
            {
                Num1 = Num1 + Num2;
                Total += Num1;
                Sb.Append(Num1);
                Sb.Append(" ");
                Num2 = Num2 + Num1;
                Total += Num2;
                Sb.Append(Num2);
                Sb.Append(" ");
            }
        }
        public StringBuilder GetFibs()
        {
            return Sb;
        }

        public Double GetAverage()
        {
            return Total / MyMax;
        }
    }
}
