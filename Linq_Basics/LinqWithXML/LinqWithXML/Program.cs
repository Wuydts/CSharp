using System;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apply the old student structure to xml

            string studentsXML =
                @"<Students>
                    <Student>
                        <Name>Chris</Name>
                        <Age>27</Age>
                        <University> Dakota State University </University>
                        <Semester> 6 </Semester> 
                    </Student>
                    <Student>
                        <Name> Mashell </Name>
                        <Age> 25 </Age>
                        <University> Stanford University </University>
                        <Semester> 8 </Semester> 
                    </Student>
                    <Student>
                        <Name> Edyth </Name>
                        <Age> 21 </Age>
                        <University> Iowa State University </University>
                        <Semester> 1 </Semester> 
                    </Student>
                    <Student>
                        <Name> Frank </Name>
                        <Age> 18 </Age>
                        <University> Iowa State University </University>
                        <Semester> 10 </Semester> 
                    </Student>
                </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);


            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };
            foreach (var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from {2} is in his/her {3} semester", student.Name, student.Age, student.University, student.Semester);
            }

            Console.WriteLine("");
            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student {0} with age {1} from {2}", student.Name, student.Age, student.University);
            }
        }
    }
}
