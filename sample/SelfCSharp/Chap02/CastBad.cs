namespace SelfCSharp.Chap02
{
    internal class CastBad
    {
        static void Main(string[] args)
        {
            int i = 128;
            sbyte b = (sbyte)i;
            Console.WriteLine(b);
        }
    }
}
