namespace SelfCSharp.Chap09.Operator2
{
    internal class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Coordinate operator ++(Coordinate c)
        {
            return new Coordinate()
            {
                X = c.X + 1,
                Y = c.Y + 1
            };

            //c.X++;
            //c.Y++;
            //return c;
        }
    }

    internal class OpeIncrement
    {
        static void Main(string[] args)
        {
            var a = new Coordinate() { X = 10, Y = 20 };
            var b = ++a;
            Console.WriteLine($"({a.X},{a.Y})");
            Console.WriteLine($"({b.X},{b.Y})");

            var m = new Coordinate() { X = 10, Y = 20 };
            var n = m++;
            Console.WriteLine($"({m.X},{m.Y})");
            Console.WriteLine($"({n.X},{n.Y})");
        }
    }
}