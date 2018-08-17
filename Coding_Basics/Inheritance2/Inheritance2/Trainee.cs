using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Trainee:Employee  
    {
        public int WorkingHours { get; set; }
        public int StudyHours { get; set; }


        public Trainee(int workingHours, int schoolHours, string name, string fname, int salary) : base(name, fname, salary)
        {
            WorkingHours = workingHours;
            StudyHours = schoolHours;
        }


        public void Learn()
        {
            Console.WriteLine("I am now studying for the next {0} hours.", StudyHours);
        }
        public void Work()
        {
            Console.WriteLine("I am now at work for {0} hours.", WorkingHours);
        }
    }
}
