using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Controller
    {
        IView View;
        SumOf7 Model;

        public Controller(IView theView, SumOf7 theModel)
        {
            View = theView;
            Model = theModel;
        }

        public void Go()
        {
            View.Start();
            int i = View.GetInt("Enter two numbers for the sum of numbers divisible by 7 lowest first");
            int j = View.GetInt("Now the Secound higher number");

            Model.SetRange(i, j);
            Model.Calculate7Sum();
            View.Show("Sum is equal to " + Model.Get7Sum());
            View.Show("Average is equal to " + Model.GetAverage());
            View.Stop();
        }
    }
}
