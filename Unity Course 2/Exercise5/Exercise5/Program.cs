using System;

namespace Exercise5
{
    /// <summary>
    /// Exercise 5 solution
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Practice with while loops
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {
            // loop until user wants to quit
            int choice = 0;
            while (choice != 4)
            {
                // print menu
                Console.WriteLine("**************");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 – New Game");
                Console.WriteLine("2 – Load Game");
                Console.WriteLine("3 – Options");
                Console.WriteLine("4 – Quit");
                Console.WriteLine("**************");
                Console.WriteLine();

                // prompt for and get choice
                Console.Write("Enter your choice (1, 2, 3 or 4): ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // Problem 2
                /*
                while (choice < 1 ||
                       choice > 4)
                {
                    Console.WriteLine("Choice must be 1, 2, 3, or 4!");
                    Console.Write("Enter your choice (1, 2, 3 or 4): ");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }

                // print message using if statement
                if (choice == 1)
                {
                    Console.WriteLine("Creating new game ...");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Loading game ...");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Setting options ...");
                }
                Console.WriteLine();
                */

                // Problem 3
                // print message using if statement
                if (choice == 1)
                {
                    Console.WriteLine("Creating new game ...");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Loading game ...");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Setting options ...");
                }
                else if (choice < 1 || 
                    choice > 4)
                {
                    Console.WriteLine("Choice must be 1, 2, 3, or 4!");
                }
                Console.WriteLine();

            }

        }
    }
}
