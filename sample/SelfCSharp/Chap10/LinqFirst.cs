namespace SelfCSharp.Chap10
{
    internal class LinqFirst
    {
        static void Main(string[] args)
        {
            var bs = AppTables.Books
                     .OrderBy(b => b.Price)
                     .First();

            //var bs = AppTables.Books
            //    .Where(b => b.Price > 10000)
            //    .OrderBy(b => b.Price)
            //    .FirstOrDefault();
            if (bs == null)
            {
                Console.WriteLine("該当書籍はありません。");
            }

            Console.WriteLine(bs);
        }
    }
}
