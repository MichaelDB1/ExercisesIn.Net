using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
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
            int i = View.GetInt("Enter first lowest number");
            int j = View.GetInt("Enter secound higher Number");

            Model.SetRange(i, j);
            Model.CalculateSum();
            View.Show("Sum is Equal to " + Model.GetSum());
            View.Show("Count is Equal to " + Model.GetCount());
            View.Show("Average is equal to " + Model.GetAverage());
            View.Stop();

            
        }
    }
}
