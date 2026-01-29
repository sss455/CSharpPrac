using System;

namespace SelfCSharp.Chap07
{
    internal class PrimeNumber
    {
        /// <summary>
        ///  max以下の素数を取得するGetPrimesメソッド
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public IEnumerable<int> GetPrimes(int max)
        {
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
                // 途中でメソッドを終了させたい場合
                yield break;
            }

            // 2から順に素数判定し、素数の場合にだけ「yield return」
            for(var num = Min; num <= max; num++)
            {
                // 素数判定
                if( IsPrime(num) ) 
                {
                    // 素数の場合にだけ「yield return」
                    yield return num; 
                }
            }
        }
    }

    internal class IteratorPrime
    {
        static void Main(string[] args)
        {
            // 100以下の素数を順に出力
            var p = new PrimeNumber();
            foreach(var value in p.GetPrimes(100))
            {
                Console.WriteLine(value);
            }
        }
    }
}
