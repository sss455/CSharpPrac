namespace SelfCSharp.Chap03
{
    internal class BitShift
    {
        static void Main(string[] args)
        {
            int i = int.MinValue;
            Console.WriteLine($"{Convert.ToString(i, 2)}");
            Console.WriteLine($"{Convert.ToString(i >> 5, 2)}");

            uint m = (uint)i;
            Console.WriteLine($"{Convert.ToString(m, 2)}");
            Console.WriteLine($"{Convert.ToString(m >> 5, 2),32}");
        }
    }
}
