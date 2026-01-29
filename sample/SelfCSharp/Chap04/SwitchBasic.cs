namespace SelfCSharp.Chap04
{
    internal class SwitchBasic
    {
        static void Main(string[] args)
        {
            var rank = "甲";

            switch (rank)
            {
                case "甲":
                    Console.WriteLine("大変良いです。");
                    break;

                case "乙":
                    Console.WriteLine("良いです。");
                    break;

                case "丙":
                    Console.WriteLine("がんばりましょう。");
                    break;

                default:
                    Console.WriteLine("？？？");
                    break;
            }
        }
    }
}
