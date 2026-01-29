using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap10.Delegate3
{
    // string型の引数を受け取り、string型の値を返すデリゲート
    delegate string OutputProcess(string str);

    internal class DelegateMultiResult
    {
        // 配列要素の処理方法をデリゲート経由で受け取れるように
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (string value in data)
            {
                Console.WriteLine(output(value));
            }
        }

        // デリゲート「OutputProcess型」に対応したメソッド
        // 与えられた文字列をブラケットでくくったものを出力
        static string AddQuote(string data)
        {
            return $"[{data}]";
        }

        // デリゲート「OutputProcess型」に対応したメソッド
        // 与えられた文字列の先頭4文字を出力
        static string Front4(string data)
        {
            return data.Substring(0,4);
        }

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };

            var dr = new DelegateMultiResult();

            // デリゲートに、他クラスのメソッドを代入
            OutputProcess proc = AddQuote;
            proc += Front4;

            dr.ArrayWalk(data, proc);
        }
    }
}
