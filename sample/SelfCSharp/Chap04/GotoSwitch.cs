namespace SelfCSharp.Chap04
{
    internal class GotoSwitch
    {
        static void Main(string[] args)
        {
            var rank = "甲";

            switch (rank)
            {
                case "甲":
                    Console.WriteLine("大変良いです。");
                    goto case "丙";
                case "乙":
                    Console.WriteLine("良いです。");
                    goto case "丙";
                case "丙":
                    Console.WriteLine("合格です。");
                    break;
                case "丁":
                    Console.WriteLine("がんばりましょう。");
                    break;
                default:
                    Console.WriteLine("？？？");
                    break;
            }
        }
    }
}
