namespace SelfCSharp.Chap07
{
    internal class RefAsign
    {
        static void Main(string[] args)
        {
            var i = 10;
            var j = 20;

            ref var k = ref i;
            k = 15;
            Console.WriteLine($"i={i}, j={j}, k={k}");

            k = ref j;
            k = 108;
            Console.WriteLine($"i={i}, j={j}, k={k}");
        }
    }
}
