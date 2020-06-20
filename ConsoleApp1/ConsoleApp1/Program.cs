using System;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int mystery = rand.Next(21);
            int mystery2 = rand.Next(101);
            int mystery3 = rand.Next(1001);

            Boolean running = true;

            Console.WriteLine("Level 1: 0 to 20");
            Console.WriteLine("Level 2: 0 to 100");
            Console.WriteLine("Level 3: 0 to 1000");

            Console.WriteLine("enter the level of difficulty ");
            int entry = Convert.ToInt32(Console.ReadLine());

            if (entry == 1)
            {
                Console.WriteLine("The simplest of course !");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();

                while (running)
                {
                    Console.WriteLine("Enter a number between 0 and 20");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer < mystery)
                    {
                        Console.WriteLine("It's more");
                    }
                    else if (answer > mystery)
                    {
                        Console.WriteLine("It's less");
                    }
                    else
                    {
                        Console.WriteLine("You won !");
                        running = false;
                    }
                }
            }

            if (entry == 2)
            {
                Console.WriteLine("It's starting to look pretty good !");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();

                while (running)
                {
                    Console.WriteLine("Enter a number between 0 and 100");
                    int answer2 = Convert.ToInt32(Console.ReadLine());

                    if (answer2 < mystery2)
                    {
                        Console.WriteLine("It's more");
                    }
                    else if (answer2 > mystery2)
                    {
                        Console.WriteLine("It's less");
                    }
                    else
                    {
                        Console.WriteLine("You won !");
                        running = false;
                    }

                    
                }
            }

            if (entry == 3)
            {
                Console.WriteLine("Good luck with that one !");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();

                while (running)
                {
                    Console.WriteLine("Enter a number between 0 and 1000");
                    int answer3 = Convert.ToInt32(Console.ReadLine());

                    if (answer3 < mystery3)
                    {
                        Console.WriteLine("It's more");
                    }
                    else if (answer3 > mystery3)
                    {
                        Console.WriteLine("It's less");
                    }
                    else
                    {
                        Console.WriteLine("You won !");
                        running = false;
                    }
                }
            }

        }
    }
}
