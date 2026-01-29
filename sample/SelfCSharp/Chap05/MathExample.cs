namespace SelfCSharp.Chap05
{
    internal class MathExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(-100));
            Console.WriteLine(Math.Max(6, 3));
            Console.WriteLine(Math.Min(6, 3));
            Console.WriteLine(Math.Ceiling(1234.56));
            Console.WriteLine(Math.Floor(1234.56));
            Console.WriteLine(Math.Round(1234.56, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Sqrt(10000));
            Console.WriteLine(Math.Pow(2, 4));
            Console.WriteLine(Math.Sign(-100));
            Console.WriteLine(Math.Cos(Math.PI / 180 * 60));
            Console.WriteLine(Math.Sin(Math.PI / 180 * 30));
            Console.WriteLine(Math.Tan(Math.PI / 180 * 45));
            Console.WriteLine(Math.Log(125, 5));
            Console.WriteLine(Math.Log10(100));
        }
    }
}
