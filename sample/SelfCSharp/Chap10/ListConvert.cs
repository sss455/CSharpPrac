namespace SelfCSharp.Chap10
{
    internal class ListConvert
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "からすなぜ鳴くの", "からすは山に",
                 "可愛い七つの", "子があるからよ" };
            var result = list.ConvertAll(str => str.Substring(0, 5));

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
