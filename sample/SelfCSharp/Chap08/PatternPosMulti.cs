namespace SelfCSharp.Chap08
{
    internal class PatternPosMulti
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 20;

            Console.WriteLine((x, y) switch
            {
                (10, 20) => "(10, 20)",
                (20, 10) => "(20, 10)",
                (10, _) => "x=10",
                _ => "???"
            });
        }
    }
}
