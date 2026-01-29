using System;
using System.Diagnostics;

namespace SelfCSharp.Chap11
{
    internal class AscyncResult
    {
        static void Main(string[] args)
        {
            // 非同期処理の呼び出し
            Task<TimeSpan> t = RunAsync();

            // 非同期メソッドの終了待ち
            while (!t.IsCompleted)
            {
                // 200ミリ秒待機
                t.Wait(200);
                Console.Write(".");
            }
            Console.WriteLine(t.Result);
        }

        // 戻り値のある非同期メソッド
        static async Task<TimeSpan> RunAsync()
        {
            Stopwatch watch = Stopwatch.StartNew();
            // 10秒待機
            await Task.Delay(10000);
            watch.Stop();

            return watch.Elapsed;
        }
    }
}
