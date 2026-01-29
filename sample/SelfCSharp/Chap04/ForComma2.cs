namespace SelfCSharp.Chap04
{
    internal class ForComma2
    {
        static void Main(string[] args)
        {
            for (int i = 1, j = 1; i < 6; i++, j++)
            {
                Console.WriteLine(i * j);
            }
        }
    }
}
