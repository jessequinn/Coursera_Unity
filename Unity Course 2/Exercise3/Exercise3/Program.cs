using System;
using System.Collections.Generic;

namespace Exercise3
{
    /// <summary>
    /// Exercise 3 solution
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Practice with for loops
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            // populate list
            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }

            // print list
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            // remove even numbers
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers.RemoveAt(i);
                }
            }

            // print list
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            // bad removal
            numbers.Clear();
            for (int i = 1; i <= 5; i++)
            {
                numbers.Add(i);
            }
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1 ||
                    numbers[i] == 2 ||
                    numbers[i] == 3)
                {
                    numbers.RemoveAt(i);
                }
            }
            
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}
