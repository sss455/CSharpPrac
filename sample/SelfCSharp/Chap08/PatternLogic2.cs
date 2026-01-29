namespace SelfCSharp.Chap08
{
    internal class PatternLogic2
    {
        static void Main(string[] args)
        {
            var drink = "ビール";

            Console.WriteLine(drink switch
            {
                "日本酒" or "ビール" or "ワイン" => "醸造酒です。",
                "ブランデー" or "ウィスキー" => "蒸留酒です。",
                _ => "不明"
            });
        }
    }
}
