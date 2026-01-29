namespace SelfCSharp.Chap07
{
    internal class RefCond2
    {
        static void Main(string[] args)
        {
            var i = 10;
            var j = 20;

            (i > j ? ref i : ref j) = 99;
            Console.WriteLine(j);
        }
    }
}
