using System;

namespace SelfCSharp.Chap10
{
    internal class LambaList
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------------------------------------------------
            // ForEach「リストの内容を順番に処理する」
            //-----------------------------------------------------------------------------------------------------------
            var list1 = new List<int> { 1, 3, 6, 9 };
            list1.ForEach( v => Console.WriteLine(v * v) );
            Console.WriteLine();

            //-----------------------------------------------------------------------------------------------------------
            // ConvertAll「リストの内容を変換する」
            //-----------------------------------------------------------------------------------------------------------
            var list2 = new List<string> { "からすなぜ鳴くの", "からすは山に", "可愛い七つの", "子があるからよ" };
            // 個々の要素から先頭5文字を抜き出す
            var result2 = list2.ConvertAll( str => str.Substring(0, 5) );
            // 変換結果を順に出力
            result2.ForEach( v => Console.WriteLine(v) );
            Console.WriteLine();

            //-----------------------------------------------------------------------------------------------------------
            // Find／FindAll「指定された条件でリストを検索する」
            //-----------------------------------------------------------------------------------------------------------
            // Find
            var list3 = new List<string> { "からすなぜ鳴くの", "からすは山に", "可愛い七つの", "子があるからよ" };
            var result3 = list3.Find( str => str.StartsWith("からす") );
            Console.WriteLine(result3);                 // 結果：からすなぜ鳴くの　※条件に合致した最初の1つだけ返す
            Console.WriteLine();
            // FindAll
            var list4 = new List<string> { "からすなぜ鳴くの", "からすは山に", "可愛い七つの", "子があるからよ" };
            var result4 = list4.FindAll(str => str.StartsWith("からす"));
            result4.ForEach(v => Console.WriteLine(v)); // 結果：からすなぜ鳴くの、からすは山に
            Console.WriteLine();

            //-----------------------------------------------------------------------------------------------------------
            // FindIndex／FindLastIndex「条件に合致する要素の位置を検索する」
            //-----------------------------------------------------------------------------------------------------------
            // FindIndex         index: 0,   1,  2,  3,   4,  5
            var list5 = new List<int> { 1, -15, 30, 60, -50, 40 };
            Console.WriteLine( list5.FindIndex(v => v < 0) );       // 結果：1   引数：Predicate<T> match
            Console.WriteLine( list5.FindLastIndex(v => v < 0) );   // 結果：4   引数：Predicate<T> match
            Console.WriteLine( list5.FindIndex(2, 3, v => v < 0) ); // 結果：4   引数：startIndex, count, Predicate<T> match
            Console.WriteLine();

            //-----------------------------------------------------------------------------------------------------------
            // Exists／TrueForAll「条件に合致した要素がリストに存在するか判定する」
            //-----------------------------------------------------------------------------------------------------------
            var list6 = new List<string> { "からすなぜ鳴くの", "からすは山に", "可愛い七つの", "子があるからよ" };
            // Exists
            Console.WriteLine( list6.Exists(str => str.Length >= 7) );      // 結果：True   引数：Predicate<T> match
            // TrueForAll
            Console.WriteLine( list6.TrueForAll(str => str.Length < 10) );  // 結果：True   引数：Predicate<T> match
            Console.WriteLine();

            //-----------------------------------------------------------------------------------------------------------
            // RemoveAll「指定された条件に合致する要素を削除する」
            //-----------------------------------------------------------------------------------------------------------
            //                   index: 0,   1,  2,  3,   4,  5
            var list7 = new List<int> { 1, -15, 30, 60, -50, 40 };
            list7.RemoveAll(v => v < 0);                // 結果：1、30、60、40   引数：Predicate<T> match
            list7.ForEach(v => Console.WriteLine(v));
            Console.WriteLine();
        }
    }
}
