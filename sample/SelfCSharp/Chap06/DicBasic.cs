namespace SelfCSharp.Chap06
{
    internal class DicBasic
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["Sunflower"] = "ひまわり",
                ["Morning Glory"] = "あさがお"
            };

            Console.WriteLine(dic.Count);
            Console.WriteLine(dic.ContainsKey("Rose"));
            Console.WriteLine(dic.ContainsValue("バラ"));

            dic.TryGetValue("Rose", out var name);
            Console.WriteLine(name);

            dic.Add("Tulip", "チューリップ");
            dic["Sunflower"] = "向日葵";

            foreach (var key in dic.Keys)
            {
                Console.WriteLine($"{key}：{dic[key]}");
            }

            foreach (var d in dic.Values)
            {
                Console.WriteLine(d);
            }

            dic.Remove("Rose");

            foreach (var m in dic)
            {
                Console.WriteLine($"{m.Key}：{m.Value}");
            }
        }
    }
}
