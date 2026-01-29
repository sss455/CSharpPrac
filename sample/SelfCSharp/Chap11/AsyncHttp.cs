using System.Net;

namespace SelfCSharp.Chap11
{
    internal class AsyncHttp
    {
        //static async Task Main(string[] args)
        //{
        //    var client = new HttpClient();
        //    var result = await client.GetStringAsync(
        //        "https://codezine.jp/");
        //    Console.WriteLine(result);
        //}

        //ダミーのMainメソッド（従来の非同期通信）
        static void Main(string[] args)
        {
            var client = new WebClient();
            client.DownloadStringCompleted += (sender, e) =>
            {
                Console.WriteLine(e.Result);
            };

            client.DownloadStringAsync(new Uri("https://codezine.jp/"));
            Console.ReadLine();
        }
    }
}
