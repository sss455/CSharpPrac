using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap10.Delegate2
{
    internal class DelegateMulti
    {
        // 配列要素の処理方法をデリゲート経由で受け取れるように
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (string value in data)
            {
                output(value);
            }
        }

        // デリゲート「OutputProcess型」に対応したメソッド
        // 与えられた文字列をブラケットでくくったものを出力
        static void AddQuote(string data)
        {
            Console.WriteLine($"[{data}]");
        }

        // デリゲート「OutputProcess型」に対応したメソッド
        // 与えられた文字列の先頭4文字を出力
        static void Front4(string data)
        {
            Console.WriteLine(data.Substring(0,4));
        }

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };

            var dm = new DelegateMulti();

            // デリゲートに、他クラスのメソッドを代入
            OutputProcess? proc = AddQuote;
            proc += Front4;
            //proc -= Front4; // 登録済みのメソッドを解除

            dm.ArrayWalk(data, proc!);
        }
    }
}
