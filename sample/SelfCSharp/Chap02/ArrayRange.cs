namespace SelfCSharp.Chap02
{
    internal class ArrayRange
    {
        static void Main(string[] args)
        {
            var list = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(string.Join(" ", list[1..3]));
            Console.WriteLine(string.Join(" ", list[..2]));
            Console.WriteLine(string.Join(" ", list[2..]));
            Console.WriteLine(string.Join(" ", list[^2]));
            Console.WriteLine(string.Join(" ", list[1..^1]));
            Console.WriteLine(string.Join(" ", list[1..1]));
        }
    }
}
