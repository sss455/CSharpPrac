namespace SelfCSharp.Chap02
{
    internal class Parse
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Int32.Parse("108"));
            Console.WriteLine(Single.Parse("0.1413"));
            Console.WriteLine(Int32.Parse("FF",
                System.Globalization.NumberStyles.HexNumber));
            Console.WriteLine(Double.Parse("0.653e2"));
            Console.WriteLine(Convert.ToInt32("1010", 2));
        }
    }
}
