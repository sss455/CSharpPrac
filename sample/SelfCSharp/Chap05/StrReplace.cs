namespace SelfCSharp.Chap05
{
    internal class StrReplace
    {
        static void Main(string[] args)
        {
            var str = "wingsは、執筆コミュニティです。wingsではメンバーを募集中です。";
            Console.WriteLine(str.Replace("wings", "WINGSプロジェクト"));
        }
    }
}
