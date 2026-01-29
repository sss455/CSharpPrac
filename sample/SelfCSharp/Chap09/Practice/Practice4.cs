namespace SelfCSharp.Chap09.Practice
{
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point() : this(1, 1) { }

        public void Show()
        {
            Console.WriteLine($"({this.X},{this.Y})");
        }


        public static Point operator +(Point p1, Point p2)
        {
            return new Point(
              p1.X + p2.X,
              p1.Y + p2.Y
            );
        }

        public static explicit operator double(Point p)
        {
            return Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }
    }

    internal class Practice4
    {
        static void Main(string[] args)
        {
            var p1 = new Point(10, 5);
            var p2 = new Point();
            var p3 = p1 + p2;
            p3.Show();
            Console.WriteLine((double)p2);
        }
    }
}
