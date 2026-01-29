namespace SelfCSharp.Chap09
{
    internal class ThrowExp
    {
        static void Main(string[] args)
        {
            var i = -10;
            Console.WriteLine(i > 0 ? i :
              throw new Exception("iは正数でなければいけません。"));

            //var str = "山田";
            ////string? str = null;
            //Console.WriteLine(str ?? throw new Exception("変数strがnullです。"));

            //void Hoge() => throw new NotSupportedException("未実装です。");
            //Hoge();

            //i > 0 ? null : throw new Exception("...");
        }
    }
}
