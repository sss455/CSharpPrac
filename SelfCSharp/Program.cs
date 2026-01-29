using System;
using System.Text;

namespace SelfCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("あなたの名前は？");
            string? name = Console.ReadLine();
            Console.WriteLine($"こんにちは、{name}さん！");
        }
    }
}
