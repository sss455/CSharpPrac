namespace SelfCSharp.Chap02
{
    internal class ArrayMulti
    {
        static void Main(string[] args)
        {
            //int[,] data = {
            var data = new[,]
            {
              { 10, 11, 12 },
              { 20, 21, 22 },
            };

            Console.WriteLine(data[0, 1]);
        }
    }
}
