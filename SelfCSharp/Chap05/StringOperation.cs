using System;
using System.Globalization;

namespace SelfCSharp.Chap05
{
    internal class StringOperation
    {
        static void Main(string[] args)
        {
            var str = string.Empty;
            var strResult = string.Empty;
            var isResult = false;
            var length = 0;

            //-------------------------------------------------------------------------------------------
            // サロゲートペア
            //-------------------------------------------------------------------------------------------
            str = "𠮟る";
            length = str.Length;
            Console.WriteLine($"str.Length：{length}");                                  // 結果：3

            var strInfo = new StringInfo(str);
            length = strInfo.LengthInTextElements;
            Console.WriteLine($"strInfo.LengthInTextElements：{length}");                // 結果：2

            length = new StringInfo(str).LengthInTextElements;
            Console.WriteLine($"new StringInfo(str).LengthInTextElements：{length}");    // 結果：2
            Console.WriteLine("--------------------------------------------------------------------------");


            //-------------------------------------------------------------------------------------------
            // 文字列がnull／空文字であるかを判定する
            //-------------------------------------------------------------------------------------------
            // 「null or 空文字」の判定
            str = "";
            isResult = String.IsNullOrEmpty(str);
            Console.WriteLine($"String.IsNullOrEmpty(str)：{isResult}");        // 結果：true

            //「null or 空文字 or 空白だけの文字列」の判定
            str = "   　　　";
            isResult = String.IsNullOrWhiteSpace(str);
            Console.WriteLine($"String.IsNullOrWhiteSpace(str)：{isResult}");   // 結果：true
            Console.WriteLine("--------------------------------------------------------------------------");


            //-------------------------------------------------------------------------------------------
            // Any「文字列に特定の条件を満たした文字が含まれるかを判定する」
            //-------------------------------------------------------------------------------------------
            // 文字列に数字が一つでも含まれるか判定する
            str = "WINGS2号";
            isResult = str.Any( ch => Char.IsDigit(ch) );
            Console.WriteLine($"str.Any( ch => Char.IsDigit(ch) )：{isResult}");   // 結果：true

            // ■Charクラスの主な判定メソッド
            //  Char.IsDigit()       ：10進数の数値か
            //  Char.IsNumber()      ：数字か（①②...、ⅠⅡ...などを含む）
            //  Char.IsLetter()      ：文字か
            //  Char.IsControl()     ：制御文字か
            //  Char.IsUpper()       ：大文字か
            //  Char.IsLower()       ：小文字か
            //  Char.IsWhiteSpace()  ：空白文字か

            // Allメソッド
            isResult = str.All(ch => Char.IsDigit(ch));
            Console.WriteLine($"str.All( ch => Char.IsDigit(ch) )：{isResult}");   // 結果：false


            //-------------------------------------------------------------------------------------------
            // 文字列は文字の配列として操作できる
            //-------------------------------------------------------------------------------------------
            str = "ウイングス";
            // 先頭の1文字
            Console.WriteLine($"str[0]：{str[0]}");  // 結果：ウ
            // 全ての文字を順に取得
            foreach( char ch in str )
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine("--------------------------------------------------------------------------");


            //-------------------------------------------------------------------------------------------
            // 文字列を整形する
            //-------------------------------------------------------------------------------------------
            str = string.Format( "① {0}は{1}、{2}歳です。", "サクラ", "女の子", 1 );
            Console.WriteLine(str);     // 結果：サクラは女の子、1歳です。

            str = string.Format( "② 名前は{0}です。{0}は元気です。", "サクラ", "女の子");
            Console.WriteLine(str);     // 結果：名前はサクラです。サクラは元気です。

            str = string.Format( "③ 名前は{0, 5}です。", "サクラ");
            Console.WriteLine(str);     // 結果：名前は  サクラです。

            str = string.Format( "④ 名前は{0, -5}です。", "サクラ");
            Console.WriteLine(str);     // 結果：名前はサクラ  です。

            str = string.Format( "⑤ 10進数で8桁：{0:d8}", 12345);
            Console.WriteLine(str);     // 結果：10進数で8桁：00012345

            str = string.Format( "⑥ 指数：{0:e2}", 12345);
            Console.WriteLine(str);     // 結果：指数：1.23e+004

            str = string.Format( "⑦ 指数(大文字)：{0:E2}", 12345);
            Console.WriteLine(str);     // 結果：指数(大文字)：1.23E+004

            str = string.Format( new CultureInfo("da-DK"), "⑧ 通貨(デンマーク)：{0:C}", 12345);
            Console.WriteLine(str);     // 結果：通貨(デンマーク)：12.345,00 kr.

            str = string.Format( "⑨ カスタム(0補完)：{0:0,000.000}", 1234.56);
            Console.WriteLine(str);     // 結果：カスタム(0補完)：1,234.560

            str = string.Format( "⑩ カスタム(補完なし)：{0:#,###.###}", 1234.56);
            Console.WriteLine(str);     // 結果：カスタム(補完なし)：1,234.56

            str = string.Format( "⑪ カスタム(複合)：{0, 13:0,000.000}", 1234.56);
            Console.WriteLine(str);     // 結果：カスタム(複合)：    1,234.560

            str = string.Format( "⑫ 日付：{0:D}", DateTime.Now);
            Console.WriteLine(str);     // 結果：日付：2025年11月26日

            var price = 1000;
            str = string.Format($"⑬ 価格：{price:C}");
            Console.WriteLine(str);     // 結果：\1,000

        }
    }
}
