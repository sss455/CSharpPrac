using System;
using System.Diagnostics;

namespace SelfCSharp.Chap11
{
    internal class AttrConditional
    {
        // シンボルDEBUGが存在する場合にだけ実行されるメソッド
        [Conditional("DEBUG")]
        static void Message()
        {
            Console.WriteLine("デバッグ時にだけ表示します。");
        }


        static void Main(string[] args)
        {
            Message();
            Console.WriteLine("終了しました。");
        }
    }
}
