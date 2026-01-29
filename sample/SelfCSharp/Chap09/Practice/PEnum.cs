namespace SelfCSharp.Chap09.Practice
{
    enum Weekday { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, All = 99 }

    internal class PEnum
    {
        static void Main(string[] args)
        {
            foreach (var name in Enum.GetValues(typeof(Weekday)))
            {
                Console.WriteLine($"{(int)name}：{name}");
            }
        }
    }
}
