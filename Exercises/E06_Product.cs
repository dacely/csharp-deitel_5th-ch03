using System;
using System.Collections.Generic;
using System.Text;

namespace Ch03.Exercises
{
    class E06_Product
    {
        public static void Run()
        {
            int x;
            int y;
            int z;
            int result;

            Console.Write("Enter first integer: ");
            x = int.Parse(Console.ReadLine());
            
            Console.Write("Enter second integer: ");
            y = int.Parse(Console.ReadLine());
            
            Console.Write("Enter third integer: ");
            z = int.Parse(Console.ReadLine());

            result = x * y * z;
            Console.Write($"Product is {result}");
        }
    }
}
