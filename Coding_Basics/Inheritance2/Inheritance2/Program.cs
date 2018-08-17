using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee michael = new Employee("James", "Michael", 40000);
            michael.Work();
            michael.Pause();

            Boss Chuck = new Boss("Ferrari", "Norris", "Chuck", 9001);
            Chuck.Lead();

            Trainee Mashell = new Trainee(32, 16, "Sebby", "Mashell", 32000);
            Mashell.Learn();
            Mashell.Work();


        }
    }
}
