using System;
using System.Runtime.CompilerServices;

namespace SelfCSharp.Chap11
{
    internal class LockBasic
    {
        // カウンター
        public int Count { get; private set; } = 0;

        // ロック対象のオブジェクト ★追加★
        object lockobj = new object();

        // メインの処理（50万個のスレッドを実行）
        static void Main(string[] args)
        {
            const int TaskNum = 500000; // タスクの個数
            var ts = new Task[TaskNum];
            var tb = new LockBasic();

            // タスクを起動
            for (int i = 0; i < TaskNum; i++)
            {
                ts[i] = Task.Run(() => tb.Increment());
            }

            // 各タスクの終了まで待機
            for (int i = 0; i < TaskNum; i++)
            {
                ts[i].Wait();
            }

            Console.WriteLine(tb.Count);
        }

        // LockBasicBadクラスのカウンターをインクリメント
        void Increment()
        {
            lock (lockobj) // ★追加★
            {
                this.Count++;
            }          
        }
    }
}
