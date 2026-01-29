namespace SelfCSharp.Chap10
{
    internal class LinqLike
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     where b.Title.Contains("Android")
                     //where !b.Title.Contains("Android")
                     select b;


            //メソッド構文
            //var bs = AppTables.Books
            //       .Where(b => b.Title.Contains("Android"))
            //       //.Where(b => !b.Title.Contains("Android"))
            //       .Select(b => b);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
