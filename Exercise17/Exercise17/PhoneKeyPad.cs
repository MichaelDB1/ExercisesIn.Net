using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class PhoneKeyPad
    {
        String MyString;
        int MyStringlength;
        StringBuilder Sb = new StringBuilder();

        public void GetMyString(String theString)
        {
            MyString = theString;
            MyString = MyString.ToLower();
            MyStringlength = MyString.Length;
        }

        public void CalcDigits()
        {
            for (int i = MyStringlength -1; i>= 0; i--)
            {
                Char myChar = MyString[i];
                if (myChar == 'a' || myChar == 'b' || myChar == 'c')
                {
                    Sb.Append(2);
                }
                if (myChar == 'd' || myChar == 'e' || myChar == 'f')
                {
                    Sb.Append(3);
                }
                if (myChar == 'g' || myChar == 'h' || myChar == 'i')
                {
                    Sb.Append(4);
                }
                if (myChar == 'j' || myChar == 'k' || myChar == 'l')
                {
                    Sb.Append(5);
                }
                if (myChar == 'm' || myChar == 'n' || myChar == 'o')
                {
                    Sb.Append(6);
                }
                if (myChar == 'p' || myChar == 'q' || myChar == 'r' || myChar == 's')
                {
                    Sb.Append(7);
                }
                if (myChar == 't' || myChar == 'u' || myChar == 'v')
                {
                    Sb.Append(8);
                }
                if (myChar == 'w' || myChar == 'x' || myChar == 'y' || myChar == 'z')
                {
                    Sb.Append(9);
                }
            }
        }

        public StringBuilder GetDigits()
        {
            return Sb;
        }
    }
}
