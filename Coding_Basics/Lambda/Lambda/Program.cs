using System;
using System.Collections.Generic;

namespace Lambda
{
    /* Lambda expression is an anonymous function that can be used to create delegates or expression tree types. 
     * You can write local functions that can be passed as arguments or returned as the value of a function call. 
     * Lambda expressions are particularly helpful for writing LINQ query expressions. 
     * Usually looks like Parameter => Expression / Statement block
   */


    //Creation of delegate
    public delegate int SomeMath(int i);
    public delegate bool Compare(int i, Number n);


    class Program
    {
        static void Main(string[] args)
        {
            DoSomething();
        }
        
        public static void DoSomething()
        {
            SomeMath math = new SomeMath(Square);
            Console.WriteLine(math(8));


            math = new SomeMath(TimesTen);
            Console.WriteLine(math(8));

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = list.FindAll(delegate (int i)
                {
                    return (i % 2 == 0);

                });
            foreach (int even in evenNumbers)
            {
                Console.WriteLine(even + " is an even number");
            }

            List<int> oddNumbers = list.FindAll(delegate (int i)
            {
                return (i % 2 == 1);

            });
            foreach (int odd in oddNumbers)
            {
                Console.WriteLine(odd + " is an odd number");
            }



            Console.WriteLine("Lambda Expression Below: \n");

            List<int> oddNumbers2 = list.FindAll(i => i % 2 == 1);
            oddNumbers2.ForEach(i => Console.WriteLine(i));

            List<int> evenNumbers2 = list.FindAll(i => i % 2 == 0);
            evenNumbers2.ForEach(i =>
            {
                Console.WriteLine("Even Number");
                Console.WriteLine(i);
            }

            );

            math = new SomeMath(x => x * x);
            Console.WriteLine(math(10));

            Compare comp = (a, number) => a == number.n;
            Console.WriteLine(comp(5, new Number { n = 5 }));

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        
        public static int Square (int i)
        {
            return i * i;
        }

        public static int TimesTen(int i)
        {
            return i * 10;
        }
       
    }

    public class Number
    {
        public int n { get; set; }
    }
  
}
