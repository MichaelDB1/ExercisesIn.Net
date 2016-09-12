using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Controller
    {
        IView View;
        PrintWord Printer;
        public Controller(IView theView, PrintWord thePrinter)
        {
            View = theView;
            Printer = thePrinter;

        }

        public void Go()
        {
            View.Start();
            int i = Convert.ToInt16(View.GetString("Enter a number and get the word back between 1-9"));
            View.Show(Printer.NumbCheck(i));
            View.Show(Printer.SecoundNumbCheck(i));
            View.Stop();
        }
    }
}
