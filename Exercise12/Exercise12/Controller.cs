using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Controller
    {
        IView View;
        HarmonicSum Model;

        public Controller(IView theView, HarmonicSum theModel)
        {
            View = theView;
            Model = theModel;
        }

        public void Go()
        {
            View.Start();
            int i = View.GetInt("Please enter a number to compute the Sum of a harmonic series left to right, then right to left followed by the differnce");
            Model.SetMax(i);
            Model.CalcLeft2Right();
            Model.CalcRight2Left();
            View.Show("Left to right is " + Model.GetLeft2Right());
            View.Show("Right to left is " + Model.GetRight2Left());
            View.Show("Difference between the two is " + Model.GetDifference());
            View.Stop();
        }
    }
}
