namespace SelfCSharp.Chap02
{
    internal class ToString
    {
        static void Main(string[] args)
        {
            int i = 13;
            double d = 1.23;
            Console.WriteLine(i.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(Convert.ToString(i, 16));
        }
    }
}
