using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Tribonaccics
    {
        private int MyMax;
        private int Num1 = 1;
        private int Num2;
        private int Num3;
        private Double Total;
        StringBuilder Sb = new StringBuilder();

        public void SetMax(int theMax)
        {
            MyMax = theMax;
        }

        public void CalculateMyFib()
        {
            for(int i = 0; i < MyMax; i += 2)
            {
                Num1 = Num1 + Num2 + Num3;
                Total += Num1;
                Sb.Append(Num1);
                Sb.Append(" ");
                Num2 = Num2 + Num1 + Num3;
                Total += Num2;
                Sb.Append(Num2);
                Sb.Append(" ");
                Num3 = Num3 + Num1 + Num2;
                Sb.Append(Num3);
                Sb.Append(" ");
                Total = +Num3;
            }
        }

        public StringBuilder GetTribs()
        {
            return Sb;
        }

        public Double GetAverage()
        {
            return Total / MyMax;
        }
    }
}
