namespace SelfCSharp.Chap10
{
    internal class ListFind
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "からすなぜ鳴くの", "からすは山に",
                "可愛い七つの", "子があるからよ" };
            var result = list.Find(str => str.StartsWith("からす"));
            Console.WriteLine(result);
        }
    }
}
