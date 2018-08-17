using System;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int ? num1 = null;
            int ? num2 = 1337;

            double ? num3 = new Double?();

            bool ? boolval = new bool?();

            Console.WriteLine("Our nullable numbers are: {0}, {1}, {2} ", num1, num2, num3);
            Console.WriteLine("The nullable boolean value is {0} ", boolval);
        }
    }
}
