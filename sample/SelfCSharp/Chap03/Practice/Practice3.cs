namespace SelfCSharp.Chap03.Practice
{
    internal class Practice3
    {
        static void Main(string[] args)
        {
            string? str = null;
            if (str != null && str.EndsWith(".zip"))
            {
                Console.WriteLine("拡張子は.zipです。");
            }
        }
    }
}
