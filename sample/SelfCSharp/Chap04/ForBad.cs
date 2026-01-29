namespace SelfCSharp.Chap04
{
    internal class ForBad
    {
        static void Main(string[] args)
        {

            int i;
            for (i = 1; i < 6; i++)
            {
                Console.WriteLine($"{i}番目のループです。");
            }
        }
    }
}
