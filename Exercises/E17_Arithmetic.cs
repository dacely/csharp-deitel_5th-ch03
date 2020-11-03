using System;

namespace Ch03.Exercises
{
    public class E17_Arithmetic
    {
        public static void Run()
        {
            Console.Write("Enter first integer: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Enter third integer: ");
            int z = int.Parse(Console.ReadLine());

            int sum = x + y + z;
            int average = sum / 3;
            int product = x * y * z;
            int smallest = x;
            int largest = x;

            if (y < smallest)
                smallest = y;

            if (z < smallest)
                smallest = z;

            if (y > largest)
                largest = y;

            if (z > largest)
                largest = z;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Avgerage: {average}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Smallest: {smallest}");
            Console.WriteLine($"Largest: {largest}");
        }
    }
}