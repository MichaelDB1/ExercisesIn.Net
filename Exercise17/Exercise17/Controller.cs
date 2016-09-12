using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Controller
    {
        IView View;
        PhoneKeyPad Model;

        public Controller(IView theView, PhoneKeyPad theModel)
        {
            View = theView;
            Model = theModel;
        }

        public void Go()
        {
            View.Start();
            String aString = View.GetString("Please enter a string for the phone key result");
            Model.GetMyString(aString);
            Model.CalcDigits();
            View.Show("The Phone digits for " + aString + " are " + Model.GetDigits());
            View.Stop();
        }
    }
}
