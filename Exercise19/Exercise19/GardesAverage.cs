using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    class GardesAverage
    {
        protected int[] Grades;
        protected int Sum;
        protected int GradeLength;
        protected double GradesAverage;
    

        public void getGrades(int[] grades)
        {
            Grades = grades;
            GradeLength = Grades.Length;
        }


        public void CalcAverage()
        {
            
            foreach (int Grade in Grades)
            {
                Sum += Grade;
            }                      
        }


        public double getAverage()
        {
            return GradesAverage = (double)Sum / Grades.Length;
        }
    }

}
