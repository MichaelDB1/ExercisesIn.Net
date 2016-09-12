using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class ReverseString
    {
        String MyString;
        String ReversedString = "";
        int MyStringLenth;

        public void GetMyString(String theString)
        {
            MyString = theString;
            MyStringLenth = MyString.Length;
        }

        public void ReverseMyString()
        {
            for (int i = MyStringLenth - 1; i >= 0; i--)
            {
                ReversedString = ReversedString + MyString[i];
            }
        }

        public String getTheReverse()
        {
            return ReversedString;
        }
    }
}
