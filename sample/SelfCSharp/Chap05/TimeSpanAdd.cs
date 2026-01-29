namespace SelfCSharp.Chap05
{
    internal class TimeSpanAdd
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2022, 02, 15, 13, 17, 23);
            var span = new TimeSpan(3, 15, 30, 0);
            Console.WriteLine(dt.Add(span));
        }
    }
}
