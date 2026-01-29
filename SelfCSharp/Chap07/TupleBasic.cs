using System;

namespace SelfCSharp.Chap07
{
    internal class TupleBasic
    {
        public (int max, int min) GetMaxMin(int x, int y)
        {
            return x >= y ? (x, y) : (y, x);
        }

        static void Hoge1((int x, int y) tuple)
        {
            Console.WriteLine($"{nameof(Hoge1)} {tuple}");

            tuple.x = 1;
            tuple.y = 2;

            Console.WriteLine($"{nameof(Hoge1)} {tuple}");
        }




        static void Main(string[] args)
        {
            //----------------------------------------------
            // p.339 GetMaxMin
            //----------------------------------------------
            Console.WriteLine("== GetMaxMin ========================================");
            var tupleBasic = new TupleBasic();

            // 型推論「タプル変数.メンバー名」
            var t1 = tupleBasic.GetMaxMin(1, 2);
            Console.WriteLine(t1.max);
            Console.WriteLine(t1.min);
            Console.WriteLine();
            // タプル型「タプル変数.メンバー名」
            (int max, int min) t2 = tupleBasic.GetMaxMin(4, 3);
            Console.WriteLine(t2.max);
            Console.WriteLine(t2.min);
            Console.WriteLine();
            // 型推論・分解構文（タプルのメンバーを個々の変数に分解して代入）
            var (max1, min1) = tupleBasic.GetMaxMin(5, 6);
            Console.WriteLine(max1);
            Console.WriteLine(min1);
            Console.WriteLine();
            // 分解構文（タプルのメンバーを個々の変数に分解して代入）
            (int max2, int min2) = tupleBasic.GetMaxMin(8, 7);
            //(var max2, var min2) = tupleBasic.GetMaxMin(8, 7);
            Console.WriteLine(max2);
            Console.WriteLine(min2);
            Console.WriteLine();
            // 変数宣言と分解代入とを分離することも可能
            int max3;
            int min3;
            (max3, min3) = tupleBasic.GetMaxMin(9, 10);
            Console.WriteLine(max3);
            Console.WriteLine(min3);
            Console.WriteLine();
            // スワッピング
            var x = 1;
            var y = 20;
            (y, x) = (x, y);
            Console.WriteLine($"x: {x}");
            Console.WriteLine($"y: {y}");
            Console.WriteLine();



            //----------------------------------------------
            // Hoge1
            //----------------------------------------------
            Console.WriteLine("== Hoge1 ============================================");
            (int max1, int min1) t3;
            t3.max1 = 11;
            t3.min1 = 12;

            Hoge1(t3);


            //(int max2, int min2, (int x2, int y2)) t4;
            

        }
    }
}
