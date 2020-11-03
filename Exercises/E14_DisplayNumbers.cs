using System;
using System.Collections.Generic;
using System.Text;

namespace Ch03.Exercises
{
    class E14_DisplayNumbers
    {
        public static void Run()
        {
            Console.WriteLine(" 1 2 3 4");
            Console.Write(" 1");
            Console.Write(" 2");
            Console.Write(" 3");
            Console.Write(" 4\n");
            Console.WriteLine($" {1} {2} {3} {4}");
            Console.WriteLine(" {0} {1} {2} {3}", 1, 2, 3, 4);
        }
    }
}
