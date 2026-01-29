using System;

namespace SelfCSharp.Chap11
{
    internal class EventBasic
    {
        static void Main(string[] args)
        {
            // イベントハンドラーを追加
            var ev = new MyEvent();
            ev.KeyCommand += OnKeyCommand;

            // イベントが発生する処理を実行
            ev.Run();
        }
    
        // KeyCommandイベントのためのハンドラー
        static void OnKeyCommand(string data)
        {
            // コマンドに応じて処理を実行（大文字小文字は区別しない）
            switch (data.ToLower())
            {
                case "c":   // 現在時刻を表示
                    Console.WriteLine($"現在の日時は{DateTime.Now}");
                    break;
                case "x":   // 乱数表示
                    var r = new Random();
                    Console.WriteLine($"乱数は{r.Next()}");
                    break;
                case "h":   // ヘルプ
                    Console.WriteLine("何も入力せずに確定で終了します。");
                    break;
                default:
                    Console.WriteLine("認識できないコマンドです");
                    break;
            };
        }
    }
}
