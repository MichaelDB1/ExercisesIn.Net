using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Exercise21Test;

namespace Exercise21
{
    class Controller
    {
        IView View;
        reverseArray Model;
       // ReverseArrayTest Tester;

        public Controller(IView theView, reverseArray theModel/*, ReverseArrayTest theTester*/)
        {
            View = theView;
            Model = theModel;
          /*  Tester = theTester;*/
        }

        public void Go()
        {
            View.Start();
           /* int[] TestArray = new int[5] { 12, 56, 34, 79, 26 };
            Model.GetArray(TestArray);
            Model.ReverseArray();
            Tester.GetArray(Model.getReversedArray());
            Tester.TestReverseArray();*/

            int[] AnArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                AnArray[i] = View.GetInt("Enter five numbers between 1 and 100 into an array");
                while(AnArray[i] > 100 || AnArray[i] <= 0)
                {
                    AnArray[i] = View.GetInt("That wasn't a number between 1 and 100 please enter again");
                }
            }
            Model.GetArray(AnArray);
            Model.ReverseArray();
            View.Show("The array reversed is " + Model.getReversed());
            int[] TestingArray = Model.getReversedArray();



            View.Stop();
        }
    }
}
