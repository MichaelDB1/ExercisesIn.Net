using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Controller
    {
        IView View;
        SumAdnAveragecs Model;
        public Controller(IView theView, SumAdnAveragecs theModel)
        {
            Model = theModel;
            View = theView;
        }

        public void Go()
        {
            View.Start();
            int i = View.GetInt("Enter first low number for sum and average");
            int j = View.GetInt("Enter the higher number");
            Model.SetRange(i, j);
            Model.CalculateSum();
            View.Show("The sum is equal to " + Model.GetSum());
            View.Show("The average is equal to " + Model.GetAverage());

            View.Stop();
        }

    }
}
