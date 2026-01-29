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
            [CallerArgumentExpression("msg")] string arg = "")
        {
            Console.WriteLine($"From: {file}/{member} {line}行目 Args: {arg}");
        }
        static void Main(string[] args)
        {
            ShowCaller("TEST");
        }
    }
}
