using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    class Controller
    {
        IView View;
        GardeStatistics Model;

        public Controller(IView theView, GardeStatistics theModel)
        {
            View = theView;
            Model = theModel;
        }

        public void Go()
        {
            View.Start();
            int gradeCount = View.GetInt("Enter the amount of students");
            while(gradeCount < 1)
            {
                gradeCount = View.GetInt("You must enter a number of students greater than Zero");
            }

            int[] grades = new int[gradeCount];
            for (int i = 0; i < gradeCount; i++)
            {
                grades[i] = View.GetInt("Enter the grade for student " + (i + 1) + "....");
                while(grades[i] > 100 || grades[i] <= 0)
                {
                    grades[i] = View.GetInt("The Grade for student " + (i + 1) + " must be a number between 1 and 100....");
                }
            }          
            
            Model.getGrades(grades);
            Model.CalculateAverage();
            View.Show(" The average is " + Model.GetAverage());
            View.Show(" The Minimum is " + Model.GetMin());
            View.Show(" The Maximum is " + Model.GetMax());
            View.Show(" The mean is " + Model.getMean());
            View.Show(" The standard deviation is " + Model.GetStandardDeviation());

            View.Stop();
        }
    }
}
