namespace SelfCSharp.Chap08.Abstract
{
    internal abstract class Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double GetArea();
    }

    internal class Triangle : Figure
    {
        public Triangle(double width, double height)
            : base(width, height) { }

        public override double GetArea()
        {
            return this.Width * this.Height / 2;
        }
    }

    internal class Square : Figure
    {
        public Square(double width, double height)
            : base(width, height) { }

        public override double GetArea()
        {
            return this.Width * this.Height;
        }
    }

    internal class AbstractBasic
    {
        static void Main(string[] args)
        {
            Figure t = new Triangle(10, 30);
            Console.WriteLine(t.GetArea());
            Figure s = new Square(10, 30);
            Console.WriteLine(s.GetArea());
        }
    }
}
