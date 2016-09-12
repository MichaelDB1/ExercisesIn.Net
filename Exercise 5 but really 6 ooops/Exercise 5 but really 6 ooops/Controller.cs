using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_but_really_6_ooops
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
            int i = View.GetInt("Enter first low number");
            int j = View.GetInt("Enter secound Higher Number");

            Model.SetRaange(i, j);
            Model.CalculateSum();

            View.Show("Sum is equal to " + Model.GetSum());
            View.Show("Average is equal to " + Model.GetAverage());
            View.Stop();
        }
    }
}
