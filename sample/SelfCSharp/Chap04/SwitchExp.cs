namespace SelfCSharp.Chap04
{
    internal class SwitchExp
    {
        static void Main(string[] args)
        {
            var rank = "甲";
            //var rank = "丁";
            Console.WriteLine(rank switch
            {
                "甲" => "大変良いです。",
                "乙" => "良いです。",
                "丙" => "がんばりましょう。",
                _ => "???"
            });
        }
    }
}
