using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq___University_Manager
{
    class Program
    {
        static void Main(string[] args)
        {

            UniversityManager um = new UniversityManager();
            //  um.Majors();
            //Console.WriteLine("");
            //  um.Age();
            //Console.WriteLine("");
            um.SortStudentsByMajor();
            Console.WriteLine("");
            um.AllStudentsFromDSU();
            Console.WriteLine("");

            try
            {
                Console.WriteLine("What University do you want to search? 1: Stanford University Or 2: Dakota State University");
                string input = Console.ReadLine();
                int inputAsInt = Convert.ToInt32(input);

                um.AllStudentsFromThatUniversity(inputAsInt);
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid value");
            }

        }
    }

   



  
   

}
