namespace SelfCSharp.Chap07.Practice
{
    internal class PTuple
    {
        public static (double addition, double subtraction) AddSubtract(double x, double y)
        {
            return (x + y, x - y);
        }

        static void Main(string[] args)
        {
            var p = PTuple.AddSubtract(3, 2);
            Console.WriteLine(p.addition);
            Console.WriteLine(p.subtraction);

            var (resultAdd, resultSub) = PTuple.AddSubtract(3, 2);
            Console.WriteLine(resultAdd);
            Console.WriteLine(resultSub);
        }
    }
}
