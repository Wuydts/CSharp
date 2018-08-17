using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            grades = new List<float>();
        }
        public override void AddGrade(float grade)
        {
            grades.Add(grade);


        }
     
       
        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }

        protected List<float> grades;


        public override GradeStatistics ComputeStatistics()
        {



            GradeStatistics stats = new GradeStatistics();


            float sum = 0;
            foreach (var grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;

            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public override void WriteGrades(TextWriter destination)
        {
            for (int i = grades.Count; i > 0; i--)
            {
                destination.WriteLine(grades[i - 1]);
            }
        }
    }
}
