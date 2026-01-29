using System;

namespace SelfCSharp.Chap11
{
    internal class ThreadClassic
    {
        static void Main(string[] args)
        {
            // スレッドを生成 
            Thread t1 = new Thread(Count);
            Thread t2 = new Thread(Count);
            Thread t3 = new Thread(Count);

            // スレッドを開始
            t1.Start(1);
            t2.Start(2);
            t3.Start(3);

            // スレッド終了まで待機
            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("全ての処理が終了しました。");
        }

        // スレッドの実処理（デリゲートに対応する引数付きのCountメソッド）
        static void Count(object? n)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Thread{n}: {i}");
            }
        }
    }
}
