using System;

namespace Ch03.Exercises
{
    public class E16_ComparingIntegers
    {
        public static void Run()
        {
            Console.Write("Enter first integer: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int y = int.Parse(Console.ReadLine());

            if (x > y)
                Console.WriteLine($"{x} is larger");
            else if (y > x)
                Console.WriteLine($"{y} is larger");
            else
                Console.WriteLine("This numbers are equal");
        }
    }
}