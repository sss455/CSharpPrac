namespace SelfCSharp.Chap10
{
    internal class LinqSingle
    {
        static void Main(string[] args)
        {
            var bs = AppTables.Books
                     .Single(b => b.Isbn == "978-4-7981-6849-4");

            //var bs = AppTables.Books
            //         .SingleOrDefault(b => b.Isbn == "978-4-7981-6849-4");

            Console.WriteLine(bs);
        }
    }
}
