using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Controller
    {
        IView View;
        SumAndAverage Model;
        public Controller(IView theView, SumAndAverage theModel)
        {
            View = theView;
            Model = theModel;
        }

        public void Go()
        {
            View.Start();
            int i = View.GetInt("Enter two Numbers to get the sum and average of all Odd numbers");
            int j = View.GetInt("Enter the secound Higher number");

            Model.SetRange(i, j);
            Model.CalculateSum();
            View.Show("Sum is Equal to " + Model.GetOddSum());
            View.Show("Average is Equal to " + Model.getAverage());
            View.Stop();

        }
    }
}
