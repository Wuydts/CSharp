using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";
           

            string text = "Hello! My number is 12314";
            regExp(pattern, text);

            pattern = @"\d{5}";
            regExp(pattern, text);

            pattern = @"Hello";
            regExp(pattern, text);


        }

        private static void regExp(string pattern, string text)
        {
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(text);
            Console.WriteLine("{0} hits found: \n {1} ", match.Count, text);

            foreach (Match hit in match)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }
        }
    }
}
