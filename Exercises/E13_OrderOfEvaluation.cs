using System;
using System.Collections.Generic;
using System.Text;

namespace Ch03.Exercises
{
    class E13_OrderOfEvaluation
    {
        public static void Run()
        {
            int x = 7 + 3 * 6 / 2 - 1; // 15
            Console.WriteLine(x);

            x = 2 % 2 + 2 * 2 - 2 / 2; // 3
            Console.WriteLine(x);

            x = (3 * 9 * (3 + (9 * 3 / (3)))); // 324
            Console.WriteLine(x);
        }
    }
}
