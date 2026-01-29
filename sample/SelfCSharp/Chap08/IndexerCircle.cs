namespace SelfCSharp.Chap08
{
    internal class Circle
    {
        public double this[double radius]
        {
            get
            {
                return radius * radius * Math.PI;
            }
        }
    }

    internal class IndexerCircle
    {
        static void Main(string[] args)
        {
            var c = new Circle();
            Console.WriteLine(c[10]);
        }
    }
}
