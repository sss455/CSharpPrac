namespace SelfCSharp.Chap05
{
    internal class SpanBasic
    {
        static void Main(string[] args)
        {
            var list = new[] { 10, 20, 30, 40, 50, 60 };

            var sp = new Span<int>(list, 2, 3);
            foreach (var v in sp)
            {
                Console.WriteLine(v);
            }

            sp[1] = 999;
            foreach (var v in list)
            {
                Console.WriteLine(v);
            }
        }
    }
}
