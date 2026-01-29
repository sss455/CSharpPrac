namespace SelfCSharp.Chap10
{
    internal class LinqGroupMulti
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     group b by new
                     {
                         Publisher = b.Publisher,
                         PublishYear = b.Published.Year
                     };

            //メソッド構文
            //var bs = AppTables.Books
            //         .GroupBy(b => new {
            //             Publisher = b.Publisher,
            //             PublishYear = b.Published.Year
            //         });


            foreach (var b in bs)
            {
                Console.WriteLine($"［{b.Key.Publisher}－{b.Key.PublishYear}年］");
                foreach (var t in b)
                {
                    Console.WriteLine(t.Title);
                }
            }
        }
    }
}
