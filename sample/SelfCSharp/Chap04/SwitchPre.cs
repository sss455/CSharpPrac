namespace SelfCSharp.Chap04
{
    internal class SwitchPre
    {
        static void Main(string[] args)
        {
            var rank = "甲";

            if (rank == "甲")
            {
                Console.WriteLine("大変良いです。");
            }
            else if (rank == "乙")
            {
                Console.WriteLine("良いです。");
            }
            else if (rank == "丙")
            {
                Console.WriteLine("がんばりましょう。");
            }
            else
            {
                Console.WriteLine("？？？");
            }
        }
    }
}
