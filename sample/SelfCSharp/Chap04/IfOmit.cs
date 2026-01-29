namespace SelfCSharp.Chap04
{
    internal class IfOmit
    {
        static void Main(string[] args)
        {
            var i = 1;
            if (i == 1)
                Console.WriteLine("変数iは1です。");
            else
                Console.WriteLine("変数iは1ではありません。");
        }
    }
}
