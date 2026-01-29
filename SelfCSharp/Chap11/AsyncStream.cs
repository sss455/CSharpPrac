using System;
using System.Threading.Tasks;

namespace SelfCSharp.Chap11
{
    internal class AsyncStream
    {
        // 非同期イテレーター経由で結果を列挙
        static async Task Main(string[] args)
        {
            await foreach(var result in fetchAsync())
            {
                Console.WriteLine(result.Substring(0, 5000));
                Console.WriteLine("-----------------------");
            }
        }



        private static async IAsyncEnumerable<string> fetchAsync()
        {
            // アクセス先のサイトを列挙
            var list = new[]
            {
                "https://codezine.jp",
                "https://www.shoeisha.co.jp",
                "https://wings.msn.to/",
            };

            var client = new HttpClient();

            foreach (var url in list)
            {
                var result = await client.GetStringAsync(url);
                yield return result;
            }
        }
    }
}
