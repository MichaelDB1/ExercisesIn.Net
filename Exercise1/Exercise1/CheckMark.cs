using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class CheckMark
    {
        public String Checker ( int Mark)
        {
            String result = "Fail";
            if (Mark >= 50)
            {
                result = "PASS";
            }
            return result;
        }
    }
}
