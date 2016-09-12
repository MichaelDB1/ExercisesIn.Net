using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Controller
    {
        IView View;
        ComputePI Model;

        public Controller(IView theView, ComputePI theModel)
        {
            View = theView;
            Model = theModel;
        }

        public void Go()
        {
            View.Start();
            Model.SetMax(100000);
            Model.CalcPie();
            View.Show("The Value of Pie calculated on compute PI is " + Model.GetSum());
            View.Show("The Calculate value of compute pi minus Math Pi is " + Model.ComputePi());
            View.Stop();

        }
    }
}
