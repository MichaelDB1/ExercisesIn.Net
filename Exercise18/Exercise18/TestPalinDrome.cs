using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class TestPalinDrome
    {
        string StartString;
        int MyStringLength;

        public void GetMyString(string myString)
        {
            StartString = myString;
            StartString = StartString.ToLower();
            MyStringLength = StartString.Length;
        }

        public int GetmyLength()
        {
            return MyStringLength;
        }

        public string TestString()
        {
            return StartString;
        }

        public String testPalin()
        {
            int front = 0;
            int back = MyStringLength -1;
            while (front < back)
            {
                char theFront = StartString[front];
                char theback = StartString[back];
                if (char.IsLetter(theFront) && char.IsLetter(theback)){
                    if (theFront != theback)
                    {
                        return " Is not a PalinDrome";
                    }
                }
                if (char.IsLetter(theFront))
                {
                    front += 1;
                }
                else
                {
                    front += 2;
                }
                if (char.IsLetter(theback))
                {
                    back -= 1;
                }
                else
                {
                    back -= 2;
                }
            }
            return " Is a Palindrome";

            }
        }
    }

