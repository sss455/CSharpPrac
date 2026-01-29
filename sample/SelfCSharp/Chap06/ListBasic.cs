namespace SelfCSharp.Chap06
{
    internal class ListBasic
    {
        static void PrintList<T>(List<T> list)
        {
            Console.WriteLine(String.Join(",", list.ToArray()));
        }

        static void Main(string[] args)
        {
            var list = new List<int> { 10, 15, 30, 60 };
            var list2 = new List<int> { 1, 5, 3, 6 };

            list.Insert(2, 7);
            list.Add(120);

            foreach (var v in list)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine(list.Count);
            Console.WriteLine(list[0]);
            Console.WriteLine(list.Contains(30));
            Console.WriteLine(list.IndexOf(30));
            Console.WriteLine(list.LastIndexOf(30));
            Console.WriteLine(list.Remove(60));
            PrintList(list);

            list.AddRange(list2);
            PrintList(list);

            PrintList(list.GetRange(2, 4));

            list.Reverse();
            PrintList(list);

            var ary = new int[3];
            list.CopyTo(2, ary, 0, 3);
            Console.WriteLine(String.Join(",", ary));

        }
    }
}
