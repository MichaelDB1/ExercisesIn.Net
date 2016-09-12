using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Controller
    {
        View View;
        TestPalinDrome Model;

        public Controller(View theView, TestPalinDrome theModel)
        {
            View = theView;
            Model = theModel;
        }

        public void Go()
        {
            View.Start();
            String aString = View.GetSting("Please enter a number to test if its a palindrome");
            Model.GetMyString(aString);
            View.Show(Model.GetmyLength());
            View.Show(Model.TestString());
            View.Show("The string " + aString + " " + Model.testPalin());
            View.Stop();
        }
    }
}
