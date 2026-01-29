namespace SelfCSharp.Chap10
{
    internal class ListExists
    {
        static void Main(string[] args)
        {
            var list = new List<string>{ "からすなぜ鳴くの", "からすは山に",
                "可愛い七つの", "子があるからよ" };
            Console.WriteLine(list.Exists(str => str.Length >= 7));
            Console.WriteLine(list.TrueForAll(str => str.Length < 10));
        }
    }
}
