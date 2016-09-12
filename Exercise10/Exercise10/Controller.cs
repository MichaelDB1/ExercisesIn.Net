using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Controller
    {
        IView View;
        SumSquare Model;

        public Controller(IView theView, SumSquare theModel)
        {
            View = theView;
            Model = theModel;
        }

        public void Go()
        {
            View.Start();
            int i = View.GetInt("Please enter two numbers to get the squared sum of all number between the two lowest first");
            int j = View.GetInt("Now please enter the secound higher number");
            Model.SetRange(i, j);
            Model.CalculateSquaredSum();
            View.Show("Sum is Equal to " + Model.GetSum());
            View.Stop();
        }
    }
}
