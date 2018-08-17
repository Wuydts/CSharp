using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string firstname, int salary)
        {
            Name = name;
            FirstName = firstname;
            Salary = salary;
        }

        public Employee() { Name = "Default LName"; FirstName = "Default Fname"; Salary = 50000; }

        public void Work()
        {
            Console.WriteLine("I am working");
        }
        public void Pause()
        {
            Console.WriteLine("I am not working");
        }
    }
}
