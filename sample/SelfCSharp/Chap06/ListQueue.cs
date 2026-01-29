namespace SelfCSharp.Chap06
{
    internal class ListQueue
    {
        static void Main(string[] args)
        {
            var list = new Queue<int>();
            list.Enqueue(10);
            list.Enqueue(15);
            list.Enqueue(30);
            list.Enqueue(60);

            foreach (var v in list)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine(list.Count());
            Console.WriteLine(list.Contains(30));
            Console.WriteLine(list.Dequeue());
            Console.WriteLine(list.Peek());
            Console.WriteLine(list.Dequeue());

            Console.WriteLine(String.Join(",", list.ToArray()));

        }
    }
}
