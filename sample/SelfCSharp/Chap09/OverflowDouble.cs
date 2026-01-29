namespace SelfCSharp.Chap09
{
    internal class OverflowDouble
    {
        static void Main(string[] args)
        {
            checked
            {
                var m = double.MaxValue;
                var n = double.Epsilon;
                Console.WriteLine(m * m);
                Console.WriteLine(n * n);
            }
        }
    }
}
