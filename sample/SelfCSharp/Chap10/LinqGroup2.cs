namespace SelfCSharp.Chap10
{
    internal class LinqGroup2
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     group new { Title = b.Title, Price = b.Price }
                     by b.Publisher;

            //メソッド構文
            //var bs = AppTables.Books
            //         .GroupBy(b => b.Publisher,
            //            b => new { Title = b.Title, Price = b.Price });

            foreach (var b in bs)
            {
                Console.WriteLine($"［{b.Key}］");
                foreach (var t in b)
                {
                    Console.WriteLine($"{t.Title}（{t.Price}円）");
                    //Console.WriteLine(t);
                }
            }
        }
    }
}
