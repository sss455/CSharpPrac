namespace SelfCSharp.Chap02
{
    internal class ArrayJag
    {
        static void Main(string[] args)
        {
            //int[][] data = new int[3][];
            var data = new int[3][];
            data[0] = new[] { 10, 11, 12, 13, 14 };
            data[1] = new[] { 20, 21, 22 };
            data[2] = new[] { 30, 31, 32, 33 };

            Console.WriteLine(data[1][2]);
        }
    }
}
