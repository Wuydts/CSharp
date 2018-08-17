using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool exit = false;
                do
                {
                    ClearScreen();
                    var num = CommandAndRead();
                    if (num.Equals(-1))
                        exit = true;

                    else if (num.Equals(-2))
                        exit = false;

                    else if (num.Equals(-3))
                        exit = false;

                    else if (num.Equals(1))
                        exit = false;
                    else
                    {
                        Console.WriteLine("Unkown error... Press any key to exit program safely.");
                        Console.ReadLine();
                        ClearScreen();
                        exit = true;
                    }



                } while (!exit);
            }
            catch(NullReferenceException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }


        private static int CommandAndRead()
        {
            try
            {
                Console.WriteLine("Enter a number between 0 - 20. If you wish to exit type -1");
                string num = (Console.ReadLine());

                int checker = ValidChecker(num);

                if (checker.Equals(-1))
                {
                    Console.WriteLine("GoodBye... Press anykey to Exit");
                    Console.ReadLine();
                    return -1;
                }

                else if (checker.Equals(-2))
                {
                    Console.WriteLine("Please enter a valid number this time. Press anykey to continue");
                    Console.ReadLine();
                    ClearScreen();
                    return -2;


                }
                else if (checker.Equals(-3))
                {
                    Console.WriteLine("Make sure you enter a valid number between 0 - 20 OR -1 to Exit.... Press any key to continue");
                    Console.ReadLine();
                    ClearScreen();
                    return -3;
                }

                else if (checker.Equals(-4))
                {
                    Console.WriteLine("Unkown error. Press anykey to exit the program.");
                    Console.ReadLine();
                    return -1;
                }

                else if (checker.Equals(1))
                {
                    Console.WriteLine("You entered the valid number of {0}", num);
                    Console.WriteLine("press any key to continue.");
                    Console.ReadLine();
                    ClearScreen();
                    return 1;
                }

                return -1;
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private static int ValidChecker(string num)
        {
            try
            {
                foreach (var ch in num)
                {
                    if (!char.IsDigit(ch) && !ch.Equals('-')) // Is not a digit. 
                    {
                        Console.WriteLine("You did not enter a number. Returning to main menu.");
                        return -2;
                    }

                }

                if (int.Parse(num).Equals(-1)) //Is a Number but user wants to exit program
                    return -1;

                else if (int.Parse(num) < -1 || int.Parse(num) > 20) // Is a number but not a valid one.
                {
                    Console.WriteLine("You did not enter a valid number between 0 and 20. Returning to main menu");
                    return -3;
                }

                else if (int.Parse(num) >= 0 && int.Parse(num) <= 20) //Is valid number.
                    return 1;

                return -4; // Unkown error
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        private static void ClearScreen() // simple clear screen method... just inputs a bunch a blank new lines.
        {
            try
            {
                for (int i = 0; i <= 50; i++)
                    Console.WriteLine("");
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
