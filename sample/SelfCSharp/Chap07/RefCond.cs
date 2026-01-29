namespace SelfCSharp.Chap07
{
    internal class RefCond
    {
        static void Main(string[] args)
        {
            var i = 10;
            var j = 20;

            ref var k = ref i > j ? ref i : ref j;
            //var k = i > j ? ref i : ref j;
            k = 99;
            Console.WriteLine($"i={i}, j={j}, k={k}");
        }
    }
}
