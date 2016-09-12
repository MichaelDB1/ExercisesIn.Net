using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Controller
    {
        IView View;
        CheckMark Marker;
        public Controller(IView theView, CheckMark theMarker)
        {
            View = theView;
            Marker = theMarker;
        }
       

        public void Go()
        {
            View.Start();
            int i = Convert.ToInt32(View.GetString("What Mark did you get?"));
            View.Show(Marker.Checker(i));
            View.Stop();
            
        }
    }
}
