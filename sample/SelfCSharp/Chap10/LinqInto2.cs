namespace SelfCSharp.Chap10
{
    internal class LinqInto2
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     group b by new
                     {
                         PublishYear = b.Published.Year,
                         PublishMonth = b.Published.Month
                     } into pubs
                     orderby pubs.Key.PublishYear, pubs.Key.PublishMonth
                     select pubs;

            //メソッド構文
            //var bs = AppTables.Books
            //         .GroupBy(b => new
            //         {
            //             PublishYear = b.Published.Year,
            //             PublishMonth = b.Published.Month
            //         })
            //         .OrderBy(pubs => pubs.Key.PublishYear)
            //         .ThenBy(pubs => pubs.Key.PublishMonth);

            foreach (var b in bs)
            {
                Console.WriteLine($"［{b.Key.PublishYear}年－{b.Key.PublishMonth}月］");
                foreach (var t in b)
                {
                    Console.WriteLine(t.Title);
                }
            }
        }
    }
}
