using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//     https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/standard-query-operators-overview
namespace Linq___University_Manager
{
    public class UniversityManager 
    {
        public List<University> universities;
        public List<Student> students;

        //Constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Stanford University" });
            universities.Add(new University { Id = 2, Name = "Dakota State University" });

            students.Add(new Student { Id = 1,  Name = "Christopher", Major = "Computer Science", Age = 27, UniversityId = 2 });
            students.Add(new Student { Id = 2,  Name = "Carla", Major = "Computer Science", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3,  Name = "Mashell", Major = "Math", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4,  Name = "Robert", Major = "English", Age = 35, UniversityId = 1 });
            students.Add(new Student { Id = 5,  Name = "Geroge", Major = "Network Security", Age = 20, UniversityId = 2 });
            students.Add(new Student { Id = 6,  Name = "Alex", Major = "Computer Science", Age = 27, UniversityId = 2 });
            students.Add(new Student { Id = 7,  Name = "Ruppert", Major = "Computer Science", Age = 23, UniversityId = 1 });
            students.Add(new Student { Id = 8,  Name = "Ashlyn", Major = "Math", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 9,  Name = "Gina", Major = "English", Age = 18, UniversityId = 1 });
            students.Add(new Student { Id = 10, Name = "Jose", Major = "Network Security", Age = 20, UniversityId = 2 });
        }

        public void Majors()
        {
            //      name of what I want  | similar to a foreach|   where (What I am looking for)            | select statement to choose them
            IEnumerable<Student> majors = from student in students where student.Major == "Computer Science" select student;

            foreach(Student student in majors)
            {
                student.Print();
            }
        }

        public void Age()
        {
            IEnumerable<Student> age = from student in students where student.Age > 20 select student;

            foreach(Student student in age)
            {
                student.Print();
            }
        }

        public void SortStudentsByMajor ()
        {
            var sortedMajor = from student in students orderby student.Major select student;

            Console.WriteLine("Students sorted by Major:");
            foreach(Student student in sortedMajor)
            {
                student.Print();
            }
        }

        public void AllStudentsFromDSU()
        {
            IEnumerable<Student> dsuStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Name == "Dakota State University"
                                               select student;

            Console.WriteLine("Students from Dakota State University");
            foreach(Student student in dsuStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromThatUniversity(int Id)
        {
            IEnumerable<Student> myStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Id == Id
                                               select student;

            Console.WriteLine("Students from: {0}", Id);
            foreach (Student student in myStudents)
            {
                student.Print();
            }

        }

        public void StudentAndUniversityNameCollection()
        {
            // fetch all students and their university, order them by their name and put their names in a new object together with the names of their university.
            var newCollection = from student in students
                                join university in universities
                                on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

           
            Console.WriteLine("New Collection: ");
            foreach(var col in newCollection)
            {
                Console.WriteLine("Student {0} from {1}", col.StudentName, col.UniversityName);
            }
        }
        

    }
}
