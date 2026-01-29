namespace SelfCSharp.Chap05
{
    internal class SpanString
    {
        static void Main(string[] args)
        {
            var str = "WINGSプロジェクト";
            var sp = str.AsSpan(5, 5);
            //sp[2] = 'ゴ';
        }
    }
}
