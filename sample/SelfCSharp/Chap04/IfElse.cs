namespace SelfCSharp.Chap04
{
    internal class IfElse
    {
        static void Main(string[] args)
        {
            var i = 100;
            if (i > 50)
            {
                Console.WriteLine("変数iは50より大きいです。");
            }
            else if (i > 30)
            {
                Console.WriteLine("変数iは30より大きく、50以下です。");
            }
            else
            {
                Console.WriteLine("変数iは30以下です。");
            }
        }
    }
}
