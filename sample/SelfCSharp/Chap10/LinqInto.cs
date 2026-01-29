namespace SelfCSharp.Chap10
{
    internal class LinqInto
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     group b by b.Publisher into pubs
                     where pubs.Average(b => b.Price) >= 3500
                     select new
                     {
                         Published = pubs.Key,
                         AveragePrice = pubs.Average(b => b.Price)
                     };

            //メソッド構文
            //var bs = AppTables.Books
            //         .GroupBy(b => b.Publisher)
            //         .Where(pubs => pubs.Average(b => b.Price) >= 3500)
            //         .Select(pubs => new
            //         {
            //             Published = pubs.Key,
            //             AveragePrice = pubs.Average(b => b.Price)
            //         });

            foreach (var b in bs)
            {
                Console.WriteLine($"{b.Published} {b.AveragePrice}円");
            }
        }
    }
}
