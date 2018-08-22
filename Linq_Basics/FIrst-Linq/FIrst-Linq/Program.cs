using System;
using System.Collections.Generic;
using System.Linq;

namespace FIrst_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            OddNumbers(numbers);

        }

        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd Numbers: ");

            // from -> to where is basically a foreach statement. The where is a filtering operator. and select is a projection operator. 
            // it decides what will be written in odd numbers. 

            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;
            Console.WriteLine(oddNumbers);

            foreach (int i in oddNumbers)
                Console.WriteLine(i);
        }
    }
}
