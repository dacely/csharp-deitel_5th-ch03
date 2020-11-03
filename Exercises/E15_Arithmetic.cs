using System;
using System.Collections.Generic;
using System.Text;

namespace Ch03.Exercises
{
    class E15_Arithmetic
    {
        public static void Run()
        {
            int number1;
            int number2;
            int sum;

            Console.Write("Enter first integer: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Product is {number1 * number2}");
            Console.WriteLine($"Quotient is {number1 / number2}");
            Console.WriteLine($"Difference is {number1 - number2}");
        }
    }
}
