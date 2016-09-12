using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class PrintWord
    {
        public String NumbCheck ( int numb)
        {
            String result;
            if (numb == 1)
            {
                result = "ONE";
            }
            else if (numb == 2)
            {
                result = "Two";
            }
            else if (numb == 3)
            {
                result = "Three";
            }
            else if (numb == 4)
            {
                result = "Four";
            }
            else if (numb == 5)
            {
                result = "Five";
            }
            else if (numb == 6)
            {
                result = "Six";
            }
            else if (numb == 7)
            {
                result = "Seven";
            }
            else if (numb == 8)
            {
                result = "Eight";
            }
            else if (numb == 9)
            {
                result = "Nine";
            }
            else
            {
                result = "Other";
            }
            return result;
        }

        public String SecoundNumbCheck ( int numb)
        {
            String result;
            switch (numb) {
                case 1: result = "ONE";
                    break;
                case 2: result = "Two";
                    break;
                case 3:
                    result = "Three";
                    break;
                case 4:
                    result = "Four";
                    break;
                case 5:
                    result = "Five";
                    break;
                case 6:
                    result = "Six";
                    break;
                case 7:
                    result = "Seven";
                    break;
                case 8:
                    result = "Eight";
                    break;
                case 9:
                    result = "Nine";
                    break;
                default: result = "Other";
                    break;
            }
            return result;
        }
        
    }
}
