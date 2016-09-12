using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class Controller
    {
        Iview View;
        ReverseString Model;

        public Controller(Iview theView, ReverseString theModel)
        {
            View = theView;
            Model = theModel;
        }

        public void Go()
        {
            View.Start();
            String theString = View.GetString("Please enter a string so it can be reversed");
            Model.GetMyString(theString);
            Model.ReverseMyString();
            View.Show("The reverse of the string " + theString + " Is " + Model.getTheReverse());
            View.Stop();

        }
    }
}
