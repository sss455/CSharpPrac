using System;

namespace SelfCSharp.Chap08
{
    /// <summary>
    ///  (1) 月の和名を与えることで、対応する月番号（1～12)を取得。
    ///  (2) 月番号（1～12)を与えることで、対応する月の和名を取得。
    /// </summary>
    internal class JapaneseMonth
    {
        // 月の和名を準備
        private string[] _month = { "睦月", "如月", "弥生", "卯月", "皐月", "水無月", "文月", "葉月", "長月", "神無月", "霜月", "師走" };

        // 和名をキーに、月番号を取得するインデクサー
        public int this[string name]
        {
            get
            {
                return Array.IndexOf(this._month, name) + 1;
            }
        }

        // 月番号（1～12)を受け取り、和名を返すインデクサー（オーバーロード）
        public string this[int monthNum]
        {
            get
            {
                return this._month[monthNum - 1];
            }
        }

    }

    internal class IndexerString
    {
        static void Main(string[] args)
        {
            var mon = new JapaneseMonth();
            Console.WriteLine(mon["師走"]);
            Console.WriteLine(mon[4]);
        }
    }
}
