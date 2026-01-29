namespace SelfCSharp.Chap04.Practice
{
    internal class Practice3
    {
        static void Main(string[] args)
        {
            foreach (var tmp in args)
            {
                int i = Int32.Parse(tmp);
                Console.WriteLine(i * 1.5);
            }

        }
    }
}
