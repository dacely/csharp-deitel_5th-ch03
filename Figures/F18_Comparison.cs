using System;
using System.Collections.Generic;
using System.Text;

namespace Ch03.Figures
{
    class F18_Comparison
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

            if (number1 == number2)
                Console.WriteLine($"{number1} == {number2}");

            if (number1 != number2)
                Console.WriteLine($"{number1} != {number2}");

            if (number1 > number2)
                Console.WriteLine($"{number1} > {number2}");

            if (number1 < number2)
                Console.WriteLine($"{number1} < {number2}");

            if (number1 >= number2)
                Console.WriteLine($"{number1} >= {number2}");

            if (number1 <= number2)
                Console.WriteLine($"{number1} <= {number2}");
        }
    }
}
