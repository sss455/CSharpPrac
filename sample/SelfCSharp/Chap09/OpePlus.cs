namespace SelfCSharp.Chap09.Operator
{
    internal class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Coordinate operator +(Coordinate c1, Coordinate c2)
        //public static Coordinate operator +(in Coordinate c1, in Coordinate c2)
        {
            return new Coordinate()
            {
                X = c1.X + c2.X,
                Y = c1.Y + c2.Y
            };
        }

        //Coordinate型＋int型の場合
        //public static Coordinate operator +(Coordinate c, int x)
        //{
        //    return new Coordinate()
        //    {
        //        X = c.X + x,
        //        Y = c.Y
        //    };
        //}
    }

    internal class OpePlus
    {
        static void Main(string[] args)
        {
            var c1 = new Coordinate { X = 10, Y = 20 };
            var c2 = new Coordinate { X = 15, Y = 25 };
            var c3 = c1 + c2;
            Console.WriteLine(c3.X);
            Console.WriteLine(c3.Y);

            //Coordinate型＋int型の場合
            //var c1 = new Coordinate { X = 10, Y = 20 };
            //var c2 = c1 + 5;
            //Console.WriteLine(c2.X);
            //Console.WriteLine(c2.Y);

            //var c1 = new Coordinate { X = 10, Y = 20 };
            //c1 += 7;
            //Console.WriteLine(c1.X);
            //Console.WriteLine(c1.Y);
        }
    }
}

