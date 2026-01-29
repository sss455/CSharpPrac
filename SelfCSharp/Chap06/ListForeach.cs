namespace SelfCSharp.Chap06
{
    internal class ListForeach
    {
        static void Main(string[] args)
        {
            //----------------------------------------------
            // コレクションを順に処理する
            //----------------------------------------------
            // ■foreach構文
            // ※内部的には列挙子を利用したwhile命令のシンタックスシュガー（より簡単化された構文）
            var list = new List<string>
            {
                "バラ",
                "ひまわり",
                "あざみ"
            };

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------------------------");

            // ■列挙子
            // ※列挙子とはコレクションの要素を順番に取り出す（＝列挙する）ための仕組み
            // ※通常は利用すべきではない。
            //var enu = list.GetEnumerator();
            List<string>.Enumerator enu = list.GetEnumerator();

            while ( enu.MoveNext() )    // 列挙子を次の要素に移動（次の要素が無い場合にはfalseを返す。）
            {
                var str = enu.Current;  // 列挙子の現在の要素
                Console.WriteLine(str);
            }


        }
    }
}
