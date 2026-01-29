namespace SelfCSharp.Chap06.Practice
{
    internal class PList
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 10, 15, 30, 60 };
            list[3] = 75;
            list.Remove(15);
            list.Insert(2, 108);
            foreach (var v in list)
            {
                Console.WriteLine(v);

            }
        }
    }
}
