using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
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
            int i = View.GetInt("Enter Two Numbers to Get the sum and average of joined numbers, lowest first");
            int j = View.GetInt("Secound Number");

            Model.SetRange(i, j);
            Model.CalculateSum();
            View.Show("Sum Is Equal to " + Model.GetSum());
            View.Show("Average is Equal to " + Model.GetAverage());
            View.Stop();
        }
    }
}
