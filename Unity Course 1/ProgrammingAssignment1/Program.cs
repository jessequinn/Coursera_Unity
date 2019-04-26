using System;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// A program that calculates the distance of two points and the arctangent
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome, this program will calculate the distance between two points and the angle between those points.");
            
            Console.Write("Please provide the first point (x1): ");
            float x1 = float.Parse(Console.ReadLine());

            Console.Write("Please provide the first point (y1): ");
            float y1 = float.Parse(Console.ReadLine());
        
            Console.Write("Please provide the second point (x2): ");
            float x2 = float.Parse(Console.ReadLine());

            Console.Write("Please provide the second point (y2): ");
            float y2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("The first point is (x1,y1): " + x1 + "," + y1);
            Console.WriteLine("The second point is (x2,y2): " + x2 + "," + y2);

            float dx = x2 - x1;
            float dy = y2 - y1;

            float distance = (float)Math.Sqrt(dx*dx + dy*dy);
            Console.WriteLine("The distance between those two points is: " + distance);

            float radians = (float)Math.Atan2(dy, dx);
            Console.WriteLine("The arctangent of an angle by the x-axis and to the second point is: " + radians * (180/(float)Math.PI) + " degrees");
        }
    }
}