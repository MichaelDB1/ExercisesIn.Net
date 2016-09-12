using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Controller
    {
        IView View;
        CheckNumber Checker;
        public Controller(IView theView, CheckNumber theChecker)
        {
            View = theView;
            Checker = theChecker;
        }

        public void Go()
        {
            View.Start();
            int i = Convert.ToInt16(View.GetString("What Number do you want to Check?"));
            View.Show(Checker.NumCheck(i));
            View.Stop();
        }
    }
}
