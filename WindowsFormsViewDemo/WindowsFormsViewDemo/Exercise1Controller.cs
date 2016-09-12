using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsViewDemo
{
    public class Exercise1Controller : ExerciseController
    {
        public Exercise1Controller(IView view) : base( view) { }

        public override void Go()
        {
            string s;
            int n;
            s = View.In("How Many?");
            n = Int32.Parse(s);
            for (int i = 1; i <= n; i++)
            { View.Out("" + i); }
        }
    }
}
