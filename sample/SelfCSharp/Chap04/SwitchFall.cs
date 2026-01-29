namespace SelfCSharp.Chap04
{
    internal class SwitchFall
    {
        static void Main(string[] args)
        {
            var drink = "ビール";
            switch (drink)
            {
                case "日本酒":
                case "ビール":
                case "ワイン":
                    Console.WriteLine("醸造酒です。");
                    break;
                case "ブランデー":
                case "ウイスキー":
                    Console.WriteLine("蒸留酒です。");
                    break;
            }
        }
    }
}
