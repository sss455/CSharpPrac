namespace SelfCSharp.Chap07
{
    internal class RefForeach
    {
        static void Main(string[] args)
        {
            var list = new[] { 1, 2, 3, 4, 5 };
            foreach (ref var value in list.AsSpan())
            {
                value *= value;
            }
            Console.WriteLine(string.Join(",", list));
        }
    }
}
