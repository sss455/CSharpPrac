using System;

namespace SelfCSharp.Chap11
{
    internal class ThreadBasic
    {
        static void Main(string[] args)
        {
            // タスクを開始
            Task t1 = Task.Run(() => Count(1));
            Task t2 = Task.Run(() => Count(2));
            Task t3 = Task.Run(() => Count(3));

            // タスクの終了まで待機
            t1.Wait();
            t2.Wait();
            t3.Wait();

            Console.WriteLine("全ての処理が終了しました。");
        }

        // スレッドの実処理（デリゲートに対応する引数付きのCountメソッド）
        static void Count(int n)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Thread{n}: {i}");
            }
        }
    }
}
