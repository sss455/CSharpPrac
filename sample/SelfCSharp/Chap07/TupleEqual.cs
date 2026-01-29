namespace SelfCSharp.Chap07
{
    internal class TupleEqual
    {
        static void Main(string[] args)
        {
            (double x, double y) t1 = (10, 30);
            (double a, double b) t2 = (10, 30);
            (double x, (double y, double z)) t3 = (10, (20, 30));

            Console.WriteLine(t1 == (10, 30));
            Console.WriteLine(t1 != (10, 30));
            Console.WriteLine(t1 == t2);
            Console.WriteLine(t3 == (10, (20, 30)));
            //Console.WriteLine(t1 == t3);

            Console.WriteLine(t1.x == 10 && t1.y == 30);
            Console.WriteLine(t1.x != 10 || t1.y != 30);
        }
    }
}
