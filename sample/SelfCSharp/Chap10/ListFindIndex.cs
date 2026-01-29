namespace SelfCSharp.Chap10
{
    internal class ListFindIndex
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, -15, 30, 60, -50, 40 };
            Console.WriteLine(list.FindIndex(v => v < 0));
            Console.WriteLine(list.FindLastIndex(v => v < 0));
            Console.WriteLine(list.FindIndex(2, 3, v => v < 0));
        }
    }
}
