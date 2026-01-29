namespace SelfCSharp.Chap05
{
    internal class TimeAdd
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2022, 02, 15, 13, 17, 23);
            Console.WriteLine(dt.AddYears(10));
            Console.WriteLine(dt.AddMonths(-3));
            Console.WriteLine(dt.AddDays(20));
            Console.WriteLine(dt.AddHours(5));
            Console.WriteLine(dt.AddMinutes(-20));
            Console.WriteLine(dt.AddSeconds(45));
        }
    }
}
