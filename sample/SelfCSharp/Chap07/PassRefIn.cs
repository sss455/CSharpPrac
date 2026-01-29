namespace SelfCSharp.Chap07
{
    struct Coordinate
    {
        public double X;
        public double Y;

        public Coordinate(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    internal class PassRefIn
    {
        public static void Show(in Coordinate c)
        {
            Console.WriteLine($"[{c.X}, {c.Y}]");
            //c.X = 10;
        }


        static void Main(string[] args)
        {
            Show(new Coordinate(10, 15));
        }
    }
}
