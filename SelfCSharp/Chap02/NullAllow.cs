using System;

namespace SelfCSharp.Chap02
{
    internal class NullAllow
    {

        static void Main(string[] args)
        {
            // ★null許容型（Nullable型）
            int? num1 = 108;
            int? num2 = null;
            Nullable<int> num3 = null;  // null許容型の「データ型?」という表現は、「Nullable<データ型>」の省略表現。

            // null許容型と、本来の値型とは、相互変換が可能。
            int n1 = 108;
            int? n2 = n1;   // 値型からnull許容型へは暗黙的に変換が可能。

            int? n3 = 108;
            int n4 = (int)n3;  // null許容型から値型への変換は、明示的なキャストが必要。

            int? n5 = null;
            //int  n6 = (int)n5;    // ←InvalidOperationException例外（エラー）


            // p.73～ null許容参照型 C# 8.0以降
            // p.74 (1)
            //string str = null;  // ←エラーではなくあくまで警告
            string? str = null;
            Console.Write(str);

            // #nulableディレクティブ（ファイル単位での禁止）
            #nullable enable    // Null許容を有効（有効化＝null禁止）
            #nullable disable   // Null許容を無効
        }
    }
}
