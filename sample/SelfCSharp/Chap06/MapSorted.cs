namespace SelfCSharp.Chap06
{
    internal class MapSorted
    {
        static void Main(string[] args)
        {
            var sd = new SortedDictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["Sunflower"] = "ひまわり",
                ["Morning Glory"] = "あさがお"
            };

            foreach (var key in sd.Keys)
            {
                Console.WriteLine($"{key}：{sd[key]}");
            }
        }
    }
}
