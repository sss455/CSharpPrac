namespace SelfCSharp.Chap07
{
    internal class TupleSwap
    {
        static void Main(string[] args)
        {
            var x = 1;
            var y = 20;
            (y, x) = (x, y);

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
