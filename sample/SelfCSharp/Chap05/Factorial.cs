using System.Numerics;

namespace SelfCSharp.Chap05
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            //long result = 1;
            BigInteger result = 1;
            for (var i = 1; i < 26; i++)
            {
                result *= i;
                Console.WriteLine(result);
            }

        }
    }
}
