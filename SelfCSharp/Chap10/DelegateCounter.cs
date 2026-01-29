using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap10.Delegate
{
    internal class DelegateCounter
    {
        // 配列要素の処理方法をデリゲート経由で受け取れるように
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (string value in data)
            {
                output(value);
            }
        }

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };

            var dc = new DelegateCounter();
            var c = new Counter();

            // デリゲートに、他クラスのメソッドを代入
            OutputProcess proc = c.AddLength;
            //var proc = new OutputProcess(c.AddLength);

            dc.ArrayWalk(data, proc);
            Console.WriteLine(c.Result);

            dc.ArrayWalk(data, c.AddLength); // 引数に直接AddQuoteを引き渡すことも可能
            Console.WriteLine(c.Result);

        }
    }

    // 文字列長をカウントするためのCounterクラス
    internal class Counter
    {
        public int Result { get; private set; }

        // デリゲート「OutputProcess型」に対応したメソッド（他クラス）
        public void AddLength(string value)
        {
            Result += value.Length;
        }
    }
    
}
