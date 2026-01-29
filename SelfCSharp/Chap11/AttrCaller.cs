using System;
using System.Runtime.CompilerServices;

namespace SelfCSharp.Chap11
{
    internal class AttrCaller
    {
        public static void ShowCaller(
            string msg,
            [CallerFilePath] string file = "",
            [CallerMemberName] string member = "",
            [CallerLineNumber] int line = 0,
            [CallerArgumentExpression("msg")] string arg = ""
            )
        {
            Console.WriteLine($"CallerFilePath：{file}");
            Console.WriteLine($"CallerMemberName：{member}メソッド");
            Console.WriteLine($"CallerLineNumber：{line}行目");
            Console.WriteLine($"CallerArgumentExpression(\"msg\")：{arg}");
        }


        static void Main(string[] args)
        {
            ShowCaller("TEST");
        }
    }
}
