using System;
using System.Collections;

namespace SelfCSharp.Chap07
{
    internal class PrimeList : IEnumerable<int> // IEnumerable<T>インターフェイスを実装
    {
        // 最小の素数
        int max = 2;

        // コンストラクタ
        public PrimeList(int max)
        {
            this.max = max;
        }

        // IEnumerable<T>のGetEnumeratorメソッドを実装
        public IEnumerator<int> GetEnumerator()
        {
            #region this.max以下の素数を取得
            // ローカル関数IsPrimeを定義（引数valueが素数かどうかを判定）
            bool IsPrime(int value)
            {
                // 素数かどうかを表すフラグ
                var primeFlg = true;

                // 2～Sqrt(value)で、valueで割り切れる（余りが0の）値があるか
                //      - Math.Floor(): 小数点を切り捨て、切り上げ、四捨五入する
                //      - Math.Sqrt():  指定された数値の平方根を取得する（平方根とはある値を2乗する前の値）
                for (var i = 2; i <= Math.Floor(Math.Sqrt(value)); i++)
                {
                    if ( value % 2 == 0)
                    {　
                        primeFlg = false;   // 割り切れるものがあれば素数でない
                        break;
                    }
                }
                return primeFlg;
            }

            // 最小の素数
            const int Min = 2;

            // 引数maxが最小の素数未満ならばエラー
            if(max < Min)
            {
                Console.WriteLine("引数maxは2以上の値を指定してください。");
                yield break;
            }

            // 2から順に素数判定し、素数の場合にだけ「yield return」
            for(var num = Min; num <= max; num++)
            {
                if( IsPrime(num) ) 
                {
                    yield return num; 
                }
            }
            #endregion
        }

        // IEnumerable（非ジェネリック型）のGetEnumeratorも実装
        //    ※IEnumerator型を返すGetEnumeratorメソッドを定義しているのは、
        //      IEnumerable<T> が IEnumerable（非ジェネリック型）を継承しているため。
        //      よって、IEnumerable<T>を実装するには、IEnumerable.GetEnumeratorも合わせて実装しなければならない。
        IEnumerator IEnumerable.GetEnumerator()
        {
            // 中身は、単にIEnumerable<T>型を返すGetEnumeratorメソッドを呼び出すだけでかまわない。
            return GetEnumerator();
        }
    }

    internal class IteratorPrime2
    {
        static void Main(string[] args)
        {
            // 100以下の素数を順に出力
            var list = new PrimeList(100);
            foreach (var value in list)     // PrimeListオブジェクトをそのまま反復できる
            {
                Console.WriteLine(value);
            }
        }
    }
}
