using System;

namespace SelfCSharp.Chap10
{
    // デリゲートを定義
    delegate void Process(string str);

    internal class DelegateBasic
    {
        static void Run(string s)
        {
            Console.WriteLine($"{s}走ります。");
        }

        static void Main(string[] args)
        {
            var process = new Process(Run);
            // Process p = Run; // 省略形
            process("ちょこちょこ");
        }
    }
}
