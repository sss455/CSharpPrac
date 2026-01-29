using System;
using System.Runtime.Serialization.Formatters;

namespace SelfCSharp.Chap02
{
    internal class NullForgive
    {
        static void Main(string[] args)
        {

            //-------------------------------------------------
            // null免除演算子　C# 8.0以降
            //-------------------------------------------------
            string?[] format = { "2022-12-25 10:16:23" };
            var dt = DateTime.Parse(format[0]); // ←「変数formatがnull許容参照型の配列なので、その要素はnullである可能性がある」旨の警告が出る。
            Console.WriteLine(dt.ToString());

            //【従来】nullチェックする
            if (format[0] is { } item)
            {
                dt = DateTime.Parse(item);      // ← nullチェック後なら警告は出ない。
                Console.WriteLine(dt.ToString());
            }

            // ★ null免除演算子「!」
            dt = DateTime.Parse(format[0]!);    // ← null出ないことが明らかであるならば、null免除演算子「!」を付与することでコンパイラーに対してnull警告を免除してもらう。
            Console.WriteLine(dt.ToString());
        }
    }
}
