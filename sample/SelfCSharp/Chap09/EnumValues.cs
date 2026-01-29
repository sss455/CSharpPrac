namespace SelfCSharp.Chap09
{
    internal class EnumValues
    {
        static void Main(string[] args)
        {
            foreach (var name in Enum.GetValues(typeof(Season)))
            {
                Console.WriteLine($"{(int)name}：{name}");
            }
        }
    }
}
