namespace SelfCSharp.Chap09.Operator4
{
    internal class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static explicit operator int(Coordinate c)
        {
            return c.X * c.X + c.Y * c.Y;
        }
    }

    internal class OpeCast
    {
        static void Main(string[] args)
        {
            var c = new Coordinate() { X = 10, Y = 20 };
            Console.WriteLine((int)c);
        }
    }
}
