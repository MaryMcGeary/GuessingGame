using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int randomNumber = NewNumber(1, 11);
                int count = 1;
                while (true)
                {
                    Console.Write("Enter a number between 1 and 10, or enter 0 to quit:");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        return;
                    else if (input < randomNumber)
                    {
                        Console.WriteLine("Guess Higher!");
                        ++count;
                        continue;
                    }
                    else if (input > randomNumber)
                    {
                        Console.WriteLine("Guess Lower!");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Yay! Good Guess! The number was {0}!",
                                           randomNumber);
                        Console.WriteLine("It took you {0} {1}.\n", count,
                                           count == 1 ? "try" : "tries");
                        break;
                    }
                }
            }
        }
        static int NewNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
