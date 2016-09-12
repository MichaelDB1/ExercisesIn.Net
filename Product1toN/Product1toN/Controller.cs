using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product1toN
{
    class Controller
    {
        IView View;
        Product1toN Model;

        public Controller(IView theView, Product1toN theModel)
        {
            View = theView;
            Model = theModel;
        }

        public void Go()
        {
            View.Start();
            int i = View.GetInt("Enter the lower number of the product Range");
            int j = View.GetInt("Enter the higher number of the product Range");
            Model.SetRange(i, j);
            Model.CalcSum();
            View.Show("Product of numbers is equal to " + Model.GetSum());
            View.Show(Model.GetMin());
            View.Show(Model.GetMax());
            int k = View.GetInt("Enter the lower number of the product Range");
            int l = View.GetInt("Enter the higher number of the product Range");
            Model.SetRange(k, l);
            Model.Reset();
            Model.CalcSum();
            View.Show("Product of numbers is equal to " + Model.GetSum());
            View.Show(Model.GetMin());
            View.Show(Model.GetMax());
            int m = View.GetInt("Enter the lower number of the product Range");
            int n = View.GetInt("Enter the higher number of the product Range");
            Model.SetRange(m, n);
            Model.Reset();
            Model.CalcSum();
            View.Show("Product of numbers is equal to " + Model.GetSum());
            View.Show(Model.GetMin());
            View.Show(Model.GetMax());
            View.Stop();

        }
    }
}
