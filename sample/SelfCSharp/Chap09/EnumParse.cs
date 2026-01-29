namespace SelfCSharp.Chap09
{
    internal class EnumParse
    {
        static void Main(string[] args)
        {
            var str = (Season)Enum.Parse(typeof(Season), "Summer");
            var num = (Season)Enum.Parse(typeof(Season), "1");
            Console.WriteLine($"{str} - {str.GetType()}");
            Console.WriteLine($"{num} - {num.GetType()}");

            var success = Enum.TryParse("Summer", out Season s);
            Console.WriteLine(success ? $"{s}" : "変換失敗");
        }
    }
}
