using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    class Controller
    {
        View View;
        GardesAverage Model;

        public Controller(View theView, GardesAverage theModel)
        {
            View = theView;
            Model = theModel;
        }

        public void Go()
        {
            View.Start();
            int gradeCount = View.GetInt("Enter amount of students");
            int[] grades = new int[gradeCount];
            for (int i = 0; i < gradeCount; i++)
            {
                grades[i] = View.GetInt("Enter grade for student " + (i + 1) + " ...");
            }
            Model.getGrades(grades);
            Model.CalcAverage();
            View.Show(" The average is " + Model.getAverage());
            View.Stop();

        }
    }
}
