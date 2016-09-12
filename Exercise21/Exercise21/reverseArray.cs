using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    class reverseArray
    {
        protected int[] TheArray;
        protected int Temp;
        protected int ArrayLength;

        public void GetArray(int[] arrays)
        {
            TheArray = arrays;
            ArrayLength = TheArray.Length;
        }

        public void ReverseArray()
        {
            for (int i = 0; i < ArrayLength/2; i++)
            {
                Temp = TheArray[i];
                TheArray[i] = TheArray[ArrayLength - 1 - i];
                TheArray[ArrayLength - 1 - i] = Temp;
            }
        }

        public int[] getReversedArray()
        {
            return TheArray;
        }

        public string getReversed()
        {
            String result = string.Join(",", TheArray);
            return result;
        }

        
    }
}
