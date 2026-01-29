using System;

namespace SelfCSharp.Chap11
{
    internal class EventUse
    {
        static void Main(string[] args)
        {
            var ev = new MyEvent();
            ev.KeyCommand += OnKeyCommand;
            ev.KeyCommand -= OnKeyCommand;
            // ev.KeyCommand = OnKeyCommand;    // コンパイルエラー
            // ev.KeyCommand("x");              // コンパイルエラー

            // eventキーワードを外した場合、①②いずれも有効なコードと認識される
            var dg = new MyDelegate();
            dg.KeyCommand += OnKeyCommand;
            dg.KeyCommand -= OnKeyCommand;
            dg.KeyCommand = OnKeyCommand;    // ①「＝」演算子による操作
            dg.KeyCommand("x");              // ②イベント（デリゲート）の直接の呼び出し
        }

        static void OnKeyCommand(string data)
        {
            switch (data.ToLower())
            {
                case "c":
                    Console.WriteLine($"現在の日時は{DateTime.Now}");
                    break;
                case "x":
                    var r = new Random();
                    Console.WriteLine($"乱数は{r.Next()}");
                    break;
                case "h":
                    Console.WriteLine("何も入力せずに確定で終了します。");
                    break;
                default:
                    Console.WriteLine("認識できないコマンドです");
                    break;
            }
            ;
        }
    }
}
