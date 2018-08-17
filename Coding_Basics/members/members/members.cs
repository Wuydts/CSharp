using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace members
{
    class members
    {
        // member - private field
        private string memberName;  
        private string jobTitle;
        private int salary;

        //member - public field
        public int age;
        public string JobTitle {
            get
            {
                return jobTitle;
            }
             set
            {
                jobTitle = value;
            }
        }

        //public member Method - can be called from other classes.
        //methods inside of a class are members

        public void Introduction(bool isFriend)
        {
            if (isFriend)
                sharingPrivate();
            else
                Console.WriteLine("Hi my name is {0}, and my job title is {1}. I am {2} years old", memberName, jobTitle, age);
        }

        private void sharingPrivate()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        //member constructor
        public members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 56000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor
        ~members()
        {
            //cleanup
            Console.WriteLine("Deconstruction of object");
        }

    }
}
