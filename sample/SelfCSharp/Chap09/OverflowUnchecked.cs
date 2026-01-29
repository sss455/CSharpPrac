namespace SelfCSharp.Chap09
{
    internal class OverflowUnchecked
    {
        static void Main(string[] args)
        {
            var i = int.MaxValue;
            Console.WriteLine(unchecked(++i));
        }
    }
}
