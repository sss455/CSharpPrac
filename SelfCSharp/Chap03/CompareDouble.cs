using System;

namespace SelfCSharp.Chap03
{
    internal class CompareDouble
    {
        public CompareDouble() 
        {
            const double EPSILON = 0.00001;
            double x = 0.2 * 3;
            double y = 0.6;
            Console.WriteLine(Math.Abs(x-y) <  EPSILON);
            Console.WriteLine(x - y < EPSILON);

            decimal i = 0.2M * 3M;
            decimal j = 0.6M;
            Console.WriteLine(i - j == 0);

            double n = 0.2 * 3;
            double m = 0.6;
            Console.WriteLine(n - m == 0);
        }

        static void Main(string[] args)
        {
            new CompareDouble();
        }
    }
}
