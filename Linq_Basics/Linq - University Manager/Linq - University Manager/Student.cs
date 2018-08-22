using System;
using System.Collections.Generic;
using System.Text;

namespace Linq___University_Manager
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public int Age { get; set; }

        //Foreign Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student Name: {0}. Id: {1}. Age: {2}. Major: {3}. From University {4}.", Name, Id, Age, Major, UniversityId);
        }

    }
}
