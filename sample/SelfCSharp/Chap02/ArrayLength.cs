namespace SelfCSharp.Chap02
{
    internal class ArrayLength
    {
        static void Main(string[] args)
        {
            var multi = new[,] {
                { 10, 11, 12 },
                { 20, 21, 22 },
            };

            var jagged = new int[3][];
            jagged[0] = new[] { 10, 11, 12, 13 };
            jagged[1] = new[] { 20, 21 };
            jagged[2] = new[] { 30, 31, 32 };

            Console.WriteLine(multi.Length);
            Console.WriteLine(jagged.Length);

            Console.WriteLine(multi.Rank);
            Console.WriteLine(jagged.Rank);

        }
    }
}
