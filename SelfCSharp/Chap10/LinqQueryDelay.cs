using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap10
{
    internal class LinqQueryDelay
    {
        static void Main(string[] args)
        {
            //#######################################################
            // 遅延実行
            //#######################################################
            var bs1 = from b in AppTables.Books select b.Title;

            // 0番目の書籍タイトルを変更
            AppTables.Books.ElementAt(0).Title = "独学できるPHP";

            foreach (var b in bs1)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();


            //#######################################################
            // 即時実行（ToArrayメソッド）
            //#######################################################
            var bs2 = (from b in AppTables.Books select b.Title).ToArray();

            // 0番目の書籍タイトルを変更
            AppTables.Books.ElementAt(0).Title = "独学できないPHP";

            foreach (var b in bs2)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();


            //#######################################################
            // 即時実行（ToListメソッド）
            //#######################################################
            var bs3 = (from b in AppTables.Books select b.Title).ToList();
            bs3.ForEach(b => Console.WriteLine(b));
        }
    }
}
