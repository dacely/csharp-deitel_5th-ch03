using System;

namespace Ch03.Exercises
{
    public class E24_OddOrEven
    {
        public static void Run()
        {
            Console.Write("Enter an integer: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
                Console.WriteLine($"{x} is an even number");
            else
                Console.WriteLine($"{x} is an odd number");
        }
    }
}