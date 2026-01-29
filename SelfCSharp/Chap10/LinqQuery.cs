using System;

namespace SelfCSharp.Chap10
{
    internal class LinqQuery
    {
        static void Main(string[] args)
        {
            //#######################################################
            // クエリ構文
            //#######################################################

            // 価格が3000円未満の「書籍名」を取り出す
            var bs1 = from b in AppTables.Books
                      where b.Price < 3000
                      select b.Title;

            foreach (var b in bs1)
            {
                Console.WriteLine(b);
            }

            // 価格が3000円未満の「書籍名、価格」を取り出す
            var bs2 = from b in AppTables.Books
                      where b.Price < 3000
                      //select new { Title = b.Title, Price = b.Price };
                      select new { b.Title, b.Price };

            foreach (var b in bs2)
            {
                Console.WriteLine($"{b.Title} {b.Price}");
            }

            // 価格が3000円未満の「書籍情報」を取り出す
            var bs3 = from b in AppTables.Books
                      where b.Price < 3000
                      select b;

            foreach (var b in bs3)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();


            //#######################################################
            // メソッド構文
            //#######################################################

            // 価格が3000円未満の「書籍名」を取り出す
            var bs4 = AppTables.Books
                      .Where(b => b.Price < 3000)
                      .Select(b => b.Title);

            foreach (var b in bs4)
            {
                Console.WriteLine(b);
            }

            // 価格が3000円未満の「書籍名、価格」を取り出す
            var bs5 = AppTables.Books
                      .Where(b => b.Price < 3000)
                      //.Select(b => new { Title = b.Title, Price = b.Price });
                      .Select(b => new { b.Title, b.Price } );

            foreach (var b in bs5)
            {
                Console.WriteLine($"{b.Title} {b.Price}");
            }

            // 価格が3000円未満の「書籍情報」を取り出す
            var bs6 = AppTables.Books
                      .Where(b => b.Price < 3000)
                      .Select(b => b);

            foreach (var b in bs6)
            {
                Console.WriteLine(b);
            }

        }
    }
}
