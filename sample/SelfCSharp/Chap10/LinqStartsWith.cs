namespace SelfCSharp.Chap10
{
    internal class LinqStartsWith
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     where b.Title.StartsWith("Android")
                     select b;

            //メソッド構文
            //var bs = AppTables.Books
            //        .Where(b => b.Title.StartsWith("Android"))
            //        .Select(b => b);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
