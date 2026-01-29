using System;
using System.Linq.Expressions;

namespace SelfCSharp.Chap10
{
    internal class LinkDetail
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------------------------------------
            // Where句／Whereメソッド「データの検索条件を指定する」
            //-----------------------------------------------------------------------------------------------
            //------------------------------------------------
            // 部分一致検索（Containsメソッド）※LIKE演算子
            //------------------------------------------------
            // クエリ構文
            var bs1 = from b in AppTables.Books
                      where b.Title.Contains("Android")
                      //where !b.Title.Contains("Android")  // 含んでいない場合、否定(!)演算子
                      select b;
            bs1.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();

            // メソッド構文
            var bs2 = AppTables.Books
                      .Where(b => b.Title.Contains("Android"))
                      //.Where(b => !b.Title.Contains("Android"))   // 含んでいない場合、否定(!)演算子
                      .Select(b => b);

            bs2.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();


            //------------------------------------------------
            // 前方一致／後方一致（StartsWith／EndsWithメソッド）
            //------------------------------------------------
            // クエリ構文
            var bs3 = from b in AppTables.Books
                      where b.Title.StartsWith("Android")
                      select b;

            bs3.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();

            // メソッド構文
            var bs4 = AppTables.Books
                      .Where(b => b.Title.StartsWith("Android"))
                      .Select(b => b);

            bs4.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();


            //------------------------------------------------
            // 候補値検索（ArrayクラスのContainsメソッド）※IN演算子
            //------------------------------------------------
            // クエリ構文
            var bs5 = from b in AppTables.Books
                      where (new int[] { 3, 6 }.Contains(b.Published.Month))
                      select b;

            bs5.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();

            // メソッド構文
            var b6 = AppTables.Books
                     .Where(b => new int[] { 3, 6 }.Contains(b.Published.Month))
                     .Select(b => b);

            b6.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();


            //------------------------------------------------
            // 範囲検索（「<=」「&&」演算子で表現）※BETWEEN演算子
            //------------------------------------------------
            // クエリ構文
            var bs7 = from b in AppTables.Books
                      where (2000 <= b.Price && b.Price <= 3500)
                      select b;

            bs7.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();

            // メソッド構文
            var bs8 = AppTables.Books
                      .Where(b => 2000 <= b.Price && b.Price <= 3500)
                      .Select(b => b);

            bs8.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();


            //------------------------------------------------
            // 単一の要素を取得（Singleメソッド）
            //------------------------------------------------
            // メソッド構文★
            var bs9 = AppTables.Books
                      .Single(b => b.Isbn == "978-4-7981-6849-4");
            Console.WriteLine(bs9);

            var bs10 = AppTables.Books
                      .SingleOrDefault(b => b.Isbn == "978-4-7981-6849-?");
            Console.WriteLine(bs10);
            Console.WriteLine();


            //-----------------------------------------------------------------------------------------------
            // orderby句／OrderByメソッド「データを並べ替える」
            //-----------------------------------------------------------------------------------------------
            // クエリ構文
            var bs11 = from b in AppTables.Books
                       orderby b.Price descending, b.Published
                       select b;

            bs11.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();

            // メソッド構文
            var bs12 = AppTables.Books
                       .OrderByDescending(b => b.Price)
                       .ThenBy(b => b.Published);


            //-----------------------------------------------------------------------------------------------
            // select句／Selectメソッド「特定のプロパティだけを取り出す
            //-----------------------------------------------------------------------------------------------
            // クエリ構文
            var bs13 = from b in AppTables.Books
                       select new {
                           ShortTitle = b.Title.Substring(0, 5),
                           DiscountPrice = b.Price * 0.9,
                           Released = (b.Published <= DateTime.Now ? "発売中" : "発売予定")
                       };

            bs13.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();

            // メソッド構文
            var bs14 = AppTables.Books
                    .Select(b => new
                    {
                        ShortTitle = b.Title.Substring(0, 5),
                        DiscountPrice = b.Price * 0.9,
                        Released = (b.Published <= DateTime.Now ? "発売中" : "発売予定")
                    });

            bs14.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();


            //-----------------------------------------------------------------------------------------------
            // Distinctメソッド「データの重複を除去する」
            //-----------------------------------------------------------------------------------------------
            // メソッド構文★
            var bs15 = AppTables.Books
                       .Select(b => b.Publisher)
                       .Distinct();

            bs15.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();

            // クエリ構文 ＋ メソッド構文
            var bs16 = (from b in AppTables.Books
                        select b.Publisher
                        ).Distinct();

            bs16.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();

            //-----------------------------------------------------------------------------------------------
            // Skip／Takeメソッド「m～n件目のデータを取得する」※Limit,Offset
            //-----------------------------------------------------------------------------------------------
            // メソッド構文★
            var bs17 = AppTables.Books
                       .OrderBy(b => b.Published)
                       .Skip(2)  // 2件スキップ
                       .Take(3)  // 3件取得
                       .Select(b => b);

            bs17.ToList().ForEach(b => Console.WriteLine(b));
            Console.WriteLine();


            //-----------------------------------------------------------------------------------------------
            // Firstメソッド「先頭のデータを取得する」
            //-----------------------------------------------------------------------------------------------
            // メソッド構文★
            var bs18 = AppTables.Books
                       .OrderBy(b => b.Price)
                       //.Select(b => b)
                       .First();

            Console.WriteLine(bs18);
            Console.WriteLine();

            var bs19 = AppTables.Books
                       .Where(b => b.Price > 0000)
                       .OrderBy(b => b.Price)
                       .FirstOrDefault();

            Console.WriteLine(bs19);
            Console.WriteLine();


            //-----------------------------------------------------------------------------------------------
            // group句／GroupByメソッド「データをグループ化する」
            //-----------------------------------------------------------------------------------------------
            // クエリ構文
            var bs20 = from b in AppTables.Books
                       group b
                       //group new {Title = b.Title, Price = b.Price }
                       by b.Publisher;

            foreach (var b in bs20)
            {
                Console.WriteLine($"[{b.Key}]");
                foreach (var t in b)
                {
                    Console.WriteLine($"{t.Title} ({t.Price}円)");
                }
            }
            Console.WriteLine();

            // メソッド構文
            var bs21 = AppTables.Books
                       .GroupBy(b => b.Publisher);
            //.GroupBy(b => b.Publisher, b => new { Title = b.Title, Price = b.Price } );

            foreach (var b in bs21)
            {
                Console.WriteLine($"[{b.Key}]");
                foreach (var t in b)
                {
                    Console.WriteLine($"{t.Title} ({t.Price}円)");
                }
            }
            Console.WriteLine();


            //-----------------------------------------------------------------------------------------------
            //  group句／GroupByメソッド「複数のキーでグループ化する
            //-----------------------------------------------------------------------------------------------
            // クエリ構文
            var bs22 = from b in AppTables.Books
                       group b by new
                       {
                           Publisher = b.Publisher,
                           PublisheYear = b.Published.Year
                       };

            foreach (var b in bs22)
            {
                Console.WriteLine($"[{b.Key.Publisher}－{b.Key.PublisheYear}年]");
                foreach (var t in b)
                {
                    Console.WriteLine(t.Title);
                }
            }
            Console.WriteLine();

            // メソッド構文
            var bs23 = AppTables.Books
                       .GroupBy(b => new
                       {
                           Publisher = b.Publisher,
                           PublisheYear = b.Published.Year
                       });

            foreach (var b in bs23)
            {
                Console.WriteLine($"[{b.Key.Publisher}－{b.Key.PublisheYear}年]");
                foreach (var t in b)
                {
                    Console.WriteLine(t.Title);
                }
            }
            Console.WriteLine();


            //-----------------------------------------------------------------------------------------------
            // into句「グループ化した結果を絞り込む」※HAVING句
            //-----------------------------------------------------------------------------------------------
            // クエリ構文
            var bs24 = from b in AppTables.Books
                       group b by b.Publisher into pubs
                       where pubs.Average(b => b.Price) >= 3500
                       select new
                       {
                           Publisher = pubs.Key,
                           AveragePrice = pubs.Average(b => b.Price)
                       };
            foreach(var b in bs24)
            {
                Console.WriteLine($"{b.Publisher} {b.AveragePrice}円");
            }
            Console.WriteLine();

            // メソッド構文
            var bs25 = AppTables.Books
                       .GroupBy(b => b.Publisher)
                       .Where(pubs => pubs.Average(b => b.Price) >= 3500)
                       .Select(pubs => new
                       {
                           Publisher = pubs.Key,
                           AveragePrice = pubs.Average(b => b.Price)
                       });
            foreach (var b in bs25)
            {
                Console.WriteLine($"{b.Publisher} {b.AveragePrice}円");
            }
            Console.WriteLine();


            //------------------------------------------------
            // グループ化キーで結果をソート
            //------------------------------------------------
            // クエリ構文
            //var bs26 =

            // メソッド構文
            //var bs27 =


            //-----------------------------------------------------------------------------------------------
            // join句／Joinメソッド「複数のデータソースを結合する
            //-----------------------------------------------------------------------------------------------
            // クエリ構文
            var bs28 = from b in AppTables.Books
                       join r in AppTables.Reviews
                       on b.Isbn equals r.Isbn
                       select new
                       {
                           Title = b.Title,
                           Reviewer = r.Name,
                           Body = r.Body,
                       };
            foreach( var b in bs28)
            {
                Console.WriteLine($"「{b.Title}」（{b.Reviewer}）");
                Console.WriteLine(b.Body);
                Console.WriteLine("------");
            }
            Console.WriteLine();

            // メソッド構文
            var bs29 = AppTables.Books
                       .Join(AppTables.Reviews,
                            b => b.Isbn,
                            r => r.Isbn,
                            (b, r) => new
                            {
                                Title = b.Title,
                                Reviewer = r.Name,
                                Body = r.Body,
                            }
                       );
            foreach (var b in bs29)
            {
                Console.WriteLine($"「{b.Title}」（{b.Reviewer}）");
                Console.WriteLine(b.Body);
                Console.WriteLine("------");
            }
            Console.WriteLine();
        }
    }
}
