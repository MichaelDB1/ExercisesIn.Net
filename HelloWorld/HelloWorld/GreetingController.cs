using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class GreetingController
    {
        IView View;
        Greeter Greeter;
        public GreetingController(IView theView, Greeter theGreeter)
        {
            View = theView;
            Greeter = theGreeter;
        }
        public void Go()
        {
            View.Start();
            Greeter.SetName(View.GetString("What is your name?"));
            View.Show(Greeter.Greet());
            View.Stop();
        }
    }
}
