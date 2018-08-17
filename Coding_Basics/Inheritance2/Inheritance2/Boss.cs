using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Boss:Employee 
    {
        public string CompanyCar { get; set; }

        public Boss(string companycar, string name, string fname, int salary):base(name, fname, salary)
        {
            CompanyCar = companycar;
        }

        public void Lead()
        {
            Console.WriteLine("My name is {0} {1} and I am a boss.", FirstName, Name);
        }
    }
}
