using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap10
{
    // string型の引数を受け取り、戻り値はvoidであるデリゲート
    delegate void OutputProcess(string str);

    internal class DelegateUse
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
        static void AddQuote(string data)
        {
            Console.WriteLine($"[{data}]");
        }

        static void Main(string[] args)
        {
            // 文字列配列data の内容を順に出力
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };

            var du = new DelegateUse();

            // デリゲートにメソッドを代入
            OutputProcess proc = AddQuote;
            //var proc = new OutputProcess(AddQuote);

            du.ArrayWalk(data, proc);
            Console.WriteLine();
            du.ArrayWalk(data, AddQuote); // 引数に直接AddQuoteを引き渡すことも可能

        }
    }
    
}
