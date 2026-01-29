using System;
using System.Net;

namespace SelfCSharp.Chap11
{
    internal class AsyncHttpOld
    {
        static async Task Main(string[] args)
        {
            var client = new WebClient();
            // 通信完了時の処理
            client.DownloadStringCompleted += (sender, e) =>
            {
                Console.WriteLine(e.Result);
            };

            // 非同期通信を開始
            client.DownloadStringAsync(new Uri("http://codezine.j/"));
            Console.ReadLine(); // 非同期待ちのために入力待機
        }
    }
}
