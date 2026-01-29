using System;

namespace SelfCSharp.Chap11
{
    internal class AsyncHttp
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://codezine.jp/");
            Console.WriteLine(result);
        }
    }
}
