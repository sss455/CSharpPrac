using System;

namespace SelfCSharp.Chap02
{
    internal class Const
    {
        static void Main(string[] args)
        {
            const double Tax = 1.1;
            int price = 1000;
            double sum = price * Tax;

            Console.WriteLine(sum);
        }
    }
}
