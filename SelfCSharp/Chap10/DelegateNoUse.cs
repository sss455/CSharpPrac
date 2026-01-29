using System;

namespace SelfCSharp.Chap10
{
    internal class DelegateNoUse
    {
        // 文字列配列の内容をブラケット付きで出力
        void ArrayWalk(string[] data)
        {
            foreach (var value in data)
            {
                Console.WriteLine($"[{value}]");
            }
        }

        static void Main(string[] args)
        {
            // 文字列配列data の内容を順に出力
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var nu = new DelegateNoUse();
            nu.ArrayWalk(data);
        }
    }
}
