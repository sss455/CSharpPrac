namespace SelfCSharp.Chap04
{
    internal class WhileDo
    {
        static void Main(string[] args)
        {
            var i = 1;
            do
            {
                Console.WriteLine($"{i}番目のループです。");
                i++;
            }
            while (i < 6);
        }
    }
}
