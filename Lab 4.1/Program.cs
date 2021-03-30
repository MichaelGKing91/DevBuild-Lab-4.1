using System;

namespace Lab_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int useIndex = 0;
            string another = "";
            do
            {
                useIndex++;
                int die1 = 0;
                int die2 = 0;
                Console.Write("Roll the dice? (Y/N) ");
                string rollYN = Console.ReadLine().ToLower();
                if (rollYN == "y" || rollYN == "yes")
                {
                    die1 = NewRandom();
                    die2 = NewRandom();
                }
                Console.WriteLine();
                Console.WriteLine($"Roll {useIndex}: ");
                PrintFormattedValues(die1, die2);

                Console.Write("Go again? (Y/N) ");
                another = Console.ReadLine().ToLower();
            } while (another == "y");
        }

        static int NewRandom()
        {
            Random myRand = new Random();
            int num = myRand.Next(1, 7);

            return num;
        }

        static void PrintFormattedValues(int v1, int v2)
        {
            int total = v1 + v2;
            if (total == 7 || total == 11)
            {
                Console.WriteLine($"You rolled a {v1} and {v2} ({total} total)");
                Console.WriteLine("You win!");
            }
            else if (v1 == 1 && v2 == 1)
            {
                Console.WriteLine($"You rolled a {v1} and {v2} ({total} total)");
                Console.WriteLine("Snake eyes!");
                Console.WriteLine("Craps!");
            }
            else if ((v1 == 1 && v2 == 2) || (v1 == 2 && v2 == 1))
            {
                Console.WriteLine($"You rolled a {v1} and {v2} ({total} total)");
                Console.WriteLine("Ace Duece!");
                Console.WriteLine("Craps!");
            }
            else if (v1 == 6 && v2 == 6)
            {
                Console.WriteLine($"You rolled a {v1} and {v2} ({total} total)");
                Console.WriteLine("Box cars!");
                Console.WriteLine("Craps!");
            }
            else
            {
                Console.WriteLine($"You rolled a {v1} and {v2} ({total} total)");
                Console.WriteLine("Sorry, you lose.");
            }
        }

    }
}
