namespace SelfCSharp.Chap02
{
    internal class TransBad
    {
        static void Main(string[] args)
        {
            int i = 16777217;
            float f = i;
            Console.WriteLine(f);
        }
    }
}
