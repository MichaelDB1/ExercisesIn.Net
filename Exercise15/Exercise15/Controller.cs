using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Controller
    {
        IView View;
        Tribonaccics Model;

        public Controller(IView theView, Tribonaccics theModel)
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
            View.Show("The first " + i + " Fibs are " + Model.GetTribs());
            View.Show("The average of these is " + Model.GetAverage());
            View.Stop();
        }
    }
}
