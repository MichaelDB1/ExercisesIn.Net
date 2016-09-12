using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class CheckNumber
    {
        public String NumCheck ( int Numb)
        {
            String result = "Odd";
            if (Numb % 2 <= 0)
            {
                result = "Even";
            }
            return result;
        }
    }
}
