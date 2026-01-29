namespace SelfCSharp.Chap06
{
    internal class CollectionInitializeIndex
    {
        static void Main(string[] args)
        {
            //var flower = new Dictionary<string, string>() {
            //    { "Rose", "バラ" },
            //    { "Sunflower", "ひまわり" },
            //    { "Morning Glory", "あさがお" }
            //};

            var flower = new Dictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["Sunflower"] = "ひまわり",
                ["Morning Glory"] = "あさがお"
            };

            foreach (var m in flower)
            {
                Console.WriteLine($"{m.Key}：{m.Value}");
            }
        }
    }
}
