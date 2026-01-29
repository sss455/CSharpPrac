namespace SelfCSharp.Chap09.Operator3
{
    internal class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static bool operator true(Coordinate c)
        {
            return c.X >= 0 && c.Y >= 0;
        }

        public static bool operator false(Coordinate c)
        {
            return c.X < 0 || c.Y < 0;
        }
    }
    internal class OpeBool
    {
        static void Main(string[] args)
        {
            var c = new Coordinate() { X = 10, Y = 20 };

            if (c)
            {
                Console.WriteLine("変数cは真です。");
            }
        }
    }
}
