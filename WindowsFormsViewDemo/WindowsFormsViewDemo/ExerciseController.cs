using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsViewDemo
{
    abstract public class ExerciseController
    {
        public ExerciseController( IView view)
        {
            View = view;
        }
        protected IView View;
        abstract public void Go();
    }
}
