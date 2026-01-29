using System;

namespace SelfCSharp.Chap09.Operator
{
    internal class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        //-----------------------------------------------------------------
        // Coordinateオブジェクト同士の加算
        //-----------------------------------------------------------------
        public static Coordinate operator +(in Coordinate left, in Coordinate right)
        {
            return new Coordinate()
            {
                X = left.X + right.X,
                Y = left.Y + right.Y
            };
        }

        //-----------------------------------------------------------------
        // Coorinate型とint型を加算する「+｝演算子
        //-----------------------------------------------------------------
        public static Coordinate operator +(in Coordinate c, in int x)
        {
            return new Coordinate()
            {
                X = c.X + x,
                Y = c.Y
            };
        }

        //-----------------------------------------------------------------
        // 「++」演算子のオーバーロード
        //-----------------------------------------------------------------
        public static Coordinate operator ++(in Coordinate c)
        {
            return new Coordinate()
            {

                X = c.X + 1,
                Y = c.Y + 1,
            };

            //これはダメ
            //c.X++;
            //c.Y++;
            //return c;
        }

        //-----------------------------------------------------------------
        // true 演算子のオーバーロード
        //-----------------------------------------------------------------
        public static bool operator true(Coordinate c)
        {
            return c.X >= 0 && c.Y >= 0;
        }

        //-----------------------------------------------------------------
        // false 演算子のオーバーロード
        //-----------------------------------------------------------------
        public static bool operator false(Coordinate c)
        {
            return c.X < 0 || c.Y < 0;
            //return !true;
        }

        //-----------------------------------------------------------------
        // キャスト演算子（Coordinate → int型にキャスト）
        //-----------------------------------------------------------------
        public static explicit operator int(Coordinate c)
        {
            return c.X * c.X + c.Y * c.Y;
        }

        //-----------------------------------------------------------------
        // キャスト演算子（int → Coordinate型にキャスト）
        //-----------------------------------------------------------------
        public static explicit operator Coordinate(int num)
        {
            return new Coordinate()
            {
                X = num,
                Y = num,
            };
        }

        public override string ToString() 
        {
            return $"{nameof(Coordinate)}( X: {X}, Y: {Y} )";
        }
    }

    internal class OpePlus
    {
        static void Main(string[] args)
        {
            var c1 = new Coordinate() { X = 10, Y = 20 };
            var c2 = new Coordinate() { X = 15, Y = 25 };

            //-----------------------------------------------------------------
            // Coordinateオブジェクト同士の加算
            //-----------------------------------------------------------------
            var c3 = c1 + c2;
            Console.WriteLine(c3);  // 結果：Coordinate( X: 25, Y: 45 )
            Console.WriteLine();

            //-----------------------------------------------------------------
            // Coorinate型とint型を加算する「+｝演算子
            //-----------------------------------------------------------------
            var c4 = c1 + 5;
            Console.WriteLine(c4);  // 結果：Coordinate( X: 15, Y: 20 )

            c1 += 7;
            Console.WriteLine(c1);  // 結果：Coordinate( X: 17, Y: 20 )
            Console.WriteLine();

            //-----------------------------------------------------------------
            //「++」演算子
            //-----------------------------------------------------------------
            var a = new Coordinate() { X = 10, Y = 20 };
            var b = ++a; // 前置演算
            Console.WriteLine(a);  // 結果：Coordinate( X: 11, Y: 21 )
            Console.WriteLine(b);  // 結果：Coordinate( X: 11, Y: 21 )
            Console.WriteLine();

            var m = new Coordinate() { X = 10, Y = 20 };
            var n = m++; // 後置演算
            Console.WriteLine(m);  // 結果：Coordinate( X: 11, Y: 21 )
            Console.WriteLine(n);  // 結果：Coordinate( X: 10, Y: 20 )
            Console.WriteLine();

            //-----------------------------------------------------------------
            // true／false 演算子
            //-----------------------------------------------------------------
            var c5 = new Coordinate() { X =  0, Y =  1 };
            var c6 = new Coordinate() { X =  0, Y = -1 };
            var c7 = new Coordinate() { X = -1, Y =  0 };
            Console.WriteLine(c5 ? "True" : "False");  // 結果：True
            Console.WriteLine(c6 ? "True" : "False");  // 結果：False
            Console.WriteLine(c7 ? "True" : "False");  // 結果：False
            Console.WriteLine();

            //-----------------------------------------------------------------
            // キャスト演算子（Coordinate → int型にキャスト）
            //-----------------------------------------------------------------
            var c8 = new Coordinate() { X = 10, Y = 20 };
            var c9 = (int)c8;
            Console.WriteLine(c9);  // 結果：500
            Console.WriteLine();

            //-----------------------------------------------------------------
            // キャスト演算子（int → Coordinate型にキャスト）
            //-----------------------------------------------------------------
            var c10 = (Coordinate)10;
            Console.WriteLine(c10);  // 結果：Coordinate( X: 10, Y: 10 )
        }
    }
}
