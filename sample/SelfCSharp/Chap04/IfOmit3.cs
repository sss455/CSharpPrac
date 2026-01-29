namespace SelfCSharp.Chap04
{
    internal class IfOmit3
    {
        static void Main(string[] args)
        {
            var i = 1;
            var j = 0;
            if (i == 1)
            {
                if (j == 1)
                {
                    Console.WriteLine("変数i、jは1です。");
                }
            }
            else
            {
                Console.WriteLine("変数iは1ではありません。");
            }
        }
    }
}
