namespace SelfCSharp.Chap05
{
    internal class StrIndex
    {
        static void Main(string[] args)
        {
            var str = "にわにはにわにわとりがいる";
            Console.WriteLine(str.IndexOf("にわ"));
            Console.WriteLine(str.IndexOf("にも"));
            Console.WriteLine(str.LastIndexOf("にわ"));
            Console.WriteLine(str.IndexOf("にわ", 3));
            Console.WriteLine(str.LastIndexOf("にわ", 3));
            Console.WriteLine(str.IndexOf("にわ", 2, 5));
            Console.WriteLine(str.LastIndexOf("にわ", 5, 3));
            Console.WriteLine(str.IndexOf("にわ", 5, 10));
        }
    }
}
