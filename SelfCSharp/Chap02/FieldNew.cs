using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap02
{
    internal class FieldNew
    {
        // 従来のフィールド定義
        public SortedDictionary<string, FileInfo> Map1 = new SortedDictionary<string, FileInfo>();

        // new式での型省略（上と同義）※C# 9.0以降
        public SortedDictionary<string, FileInfo> Map2 = new();

        static void Main(string[] args)
        {
            var dt = new DateTime(2022, 02, 15, 13, 17, 23);
            Console.WriteLine( dt.Add( new(3, 15, 30, 0) ) );            // メソッド呼び出しでnew式をそのまま渡す
            Console.WriteLine( dt.Add( new TimeSpan(3, 15, 30, 0) ) );   // 従来の省略しない渡し方
        }
    }
}
