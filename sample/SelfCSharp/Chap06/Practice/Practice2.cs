namespace SelfCSharp.Chap06.Practice
{
    internal class Practice2
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>()
            {
                ["lettuce"] = "レタス",
                ["spinach"] = "ホウレンソウ",
                ["cucumber"] = "キュウリ"
            };
            dic["cucumber"] = "胡瓜";
            dic.Add("cabbage", "キャベツ");
            dic.Remove("spinach");
            foreach (var m in dic)
            {
                Console.WriteLine($"{m.Key}：{m.Value}");
            }
        }
    }
}
