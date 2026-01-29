namespace SelfCSharp.Chap09.Operator5
{
    internal class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static explicit operator Coordinate(int num)
        {
            return new Coordinate()
            {
                X = num,
                Y = num
            };
        }
    }

    internal class OpeCast2
    {
        static void Main(string[] args)
        {
            var c = (Coordinate)10;
            Console.WriteLine($"（{c.X}, {c.Y}）");
        }
    }
}
