using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Controller
    {
        IView View;
        Fibonacci Model;

        public Controller(IView theView, Fibonacci theModel)
        {
            View = theView;
            Model = theModel;
        }

        public void Go()
        {
            View.Start();
            int i = View.GetInt("please enter a number to calculate the fib of it");
            Model.SetMax(i);
            Model.CalculateMyFib();
            View.Show("The first " + i + " Fibs are " + Model.GetFibs());
            View.Show("The average of these is " + Model.GetAverage());
            View.Stop();
        }
    }
}
