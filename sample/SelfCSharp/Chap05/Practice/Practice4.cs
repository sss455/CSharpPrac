namespace SelfCSharp.Chap05.Practice
{
    internal class Practice4
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(5, 3));
            Console.WriteLine(Math.Abs(-12));
            var data = new[] { 105, 18, 25, 30 };
            Array.Sort(data);
            Console.WriteLine(string.Join("、", data));
        }
    }
}
