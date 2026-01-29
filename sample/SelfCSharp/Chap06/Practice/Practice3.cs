namespace SelfCSharp.Chap06.Practice
{
    internal class Practice3
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4 };
            list[2] = 50;
            list.Insert(1, 5);
            list.Remove(60);
            foreach (var v in list)
            {
                Console.WriteLine(v);
            }
        }
    }
}
