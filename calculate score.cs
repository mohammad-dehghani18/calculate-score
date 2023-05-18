using System;
using System.Runtime.CompilerServices;

namespace taklif
{
    class Test
    {
        public static void Main()
        {
            Console.Write("please enter midterm score: ");
            double a = Convert.ToInt32 (Console.ReadLine ());
            Console.Write("please enter final score: ");
            double b = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine("score = {0}",calc (a, b));
            if (calc(a, b) >= 10)
            {
                Console.WriteLine("passed");
            }
            else
            { 
                Console.WriteLine("failed");
            }
        }

        private static double calc (double a, double b)
        {
            double result = 0.35 * a + 0.65 * b;
            return result;
        }
    }
}