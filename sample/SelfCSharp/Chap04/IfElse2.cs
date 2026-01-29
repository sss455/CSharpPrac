namespace SelfCSharp.Chap04
{
    internal class IfElse2
    {
        static void Main(string[] args)
        {
            var i = 100;
            if (i > 30)
            //if (i > 30 && i <= 50)
            {
                Console.WriteLine("変数iは30より大きく、50以下です。");
            }
            else if (i > 50)
            {
                Console.WriteLine("変数iは50より大きいです。");
            }
            else
            {
                Console.WriteLine("変数iは30以下です。");
            }
        }
    }
}
