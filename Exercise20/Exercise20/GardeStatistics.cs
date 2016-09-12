using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    class GardeStatistics
    {
        protected int[] Grades;
        protected int Sum;
        protected int GradeLength;
        protected double GradesAverage;
        protected double StdDevHolder;

        public void getGrades(int[] grades)
        {
            Grades = grades;
            GradeLength = Grades.Length;
        }

        public void CalculateAverage()
        {
            foreach (int Grade in Grades)
            {
                Sum += Grade;
            }
        }

        public double GetAverage()
        {
            return GradesAverage = (double)Sum / GradeLength;
        }

        public int GetMin()
        {
            int Min = 100;
            foreach (int Grade in Grades)
            {
                if (Min > Grade){
                    Min = Grade;
                }
            }
            return Min;
        }

        public int GetMax()
        {
            int Max = 0;
            foreach (int Grade in Grades)
            {
                if (Max < Grade)
                {
                    Max = Grade;
                }
            }
            return Max;
        }

        public double getMean()
        {
            double Mean = (double)Sum / GradeLength;
            return Mean;
        }

        public double GetStandardDeviation()
        {
            double Mean = (double)Sum / GradeLength;
            foreach (int Grade in Grades)
            {
                if (Grade < Mean)
                {
                    StdDevHolder += ((Mean - Grade)*(Mean - Grade));
                }
                if (Grade > Mean)
                {
                    StdDevHolder += ((Grade - Mean) * (Grade - Mean));
                }            
            }
            double n = (double)StdDevHolder / GradeLength;
            double StandardDev = Math.Sqrt((double)n);
            return StandardDev;
        }


    }
}
