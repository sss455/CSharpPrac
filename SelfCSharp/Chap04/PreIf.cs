#define DEBUG


namespace SelfCSharp.Chap04
{
    internal class PreIf
    {
        static void Main(string[] args)
        {
            //...中略...
#if DEBUG
            Console.WriteLine("デバッグ時にだけ表示します。");
#endif
            Console.WriteLine("常に表示します。");
        }
    }
}
