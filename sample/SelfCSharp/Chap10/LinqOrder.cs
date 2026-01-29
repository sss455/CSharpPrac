namespace SelfCSharp.Chap10
{
    internal class LinqOrder
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     orderby b.Price descending, b.Published
                     select b;

            //メソッド構文
            //var bs = AppTables.Books
            //         .OrderByDescending(b => b.Price)
            //         .ThenBy(b => b.Published)
            //         .Select(b => b);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
