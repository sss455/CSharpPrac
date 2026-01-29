namespace SelfCSharp.Chap05
{
    internal class StrContains
    {
        static void Main(string[] args)
        {
            var str = "WINGSプロジェクト";

            Console.WriteLine(str.Contains("プロ"));
            Console.WriteLine(str.StartsWith("WINGS"));
            Console.WriteLine(str.EndsWith("WINGS"));

            Console.WriteLine(str.IndexOf("プロ") > 0);
            Console.WriteLine(str.IndexOf("WINGS") == 0);
        }
    }
}
