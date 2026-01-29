namespace SelfCSharp.Chap10
{
    internal class LinqQuery
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     where b.Price < 3000
                     select b.Title;

            //var bs = from b in AppTables.Books
            //         where b.Price < 3000
            //         select new { Title = b.Title, Price = b.Price };


            //メソッド構文
            //var bs = AppTables.Books
            //    .Where(b => b.Price < 3000)
            //    .Select(b => b.Title);


            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
