namespace SelfCSharp.Chap10
{
    internal class LinqBetween
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     where (2000 <= b.Price && b.Price <= 3500)
                     //where(b.Price >= 2000 && b.Price <= 3500)
                     select (b);

            //メソッド構文
            //var bs = AppTables.Books
            //         .Where(b => 2000 <= b.Price && b.Price <= 3500)
            //         .Select(b => b);


            //列記も可能
            //クエリ構文
            //var bs = from b in AppTables.Books
            //       where(b.Price >= 2000)
            //       where(b.Price <= 3500)
            //       select(b);

            //メソッド構文
            //var bs = AppTables.Books
            //         .Where(b => b.Price >= 2000)
            //         .Where(b => b.Price <= 3500)
            //         .Select(b => b);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
