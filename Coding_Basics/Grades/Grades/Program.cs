using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            IGradeTracker book = CreateGradeBook();



         //   GetBookName(book);
            CreateGrades(book);
            SaveGrades(book);
            WriteResults(book);

        }

        private static IGradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        private static void WriteResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();

            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }

            writeResult("Highest: ", (int)stats.HighestGrade);
            writeResult("Lowest : ", (double)stats.LowestGrade);
            writeResult("Average: ", stats.AverageGrade);
            writeResult(stats.Description, stats.LetterGrade);
        }

        private static void SaveGrades(IGradeTracker book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputFile);
            }
        }

        private static void CreateGrades(IGradeTracker book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(IGradeTracker book)
        {
            try
            {
                Console.WriteLine("Enter a book name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null Reference. Something went wrong! :" + ex.Message);
            }
        }

        static void writeResult(string description, string result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }
       
        static void writeResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void writeResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2} ");
        }
        static void writeResult(string description, double result)
        {
            Console.WriteLine("{0}: {1:F2} ", description, result);
        }
    }
}
/* Commented out to work on flow control

            book.NameChanged += OnNameChanged;
            book.Name = "Chris's grade book";
            book.Name = null;
            book.Name = String.Empty;
            book.Name = "Christophers grade book";

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);


            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            writeResult("Highest: ", (int)stats.HighestGrade);
            writeResult("Lowest : ", (double)stats.LowestGrade);
            writeResult("Average: ", stats.AverageGrade);
            book.Name = "Chris Wuydts' grade book";

    */