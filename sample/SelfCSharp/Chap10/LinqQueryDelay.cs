namespace SelfCSharp.Chap10
{
    internal class LinqQueryDelay
    {
        static void Main(string[] args)
        {
            var bs = from b in AppTables.Books select b.Title;
            //var bs = (from b in AppTables.Books select b.Title).ToArray();

            AppTables.Books.ElementAt(0).Title = "独学できるPHP";
            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
