namespace SelfCSharp.Chap03
{
    internal class CalcDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Floor((0.7M + 0.1M) * 10M));
            Console.WriteLine(0.2M * 3M == 0.6M);

            Console.WriteLine((2 * 3) / 10d == 0.6);
        }
    }
}
