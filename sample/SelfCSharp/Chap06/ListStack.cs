namespace SelfCSharp.Chap06
{
    internal class ListStack
    {
        static void Main(string[] args)
        {
            var s = new Stack<int>();
            s.Push(10);
            s.Push(15);
            s.Push(30);
            s.Push(60);

            foreach (var v in s)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine(s.Count());
            Console.WriteLine(s.Contains(30));
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());

            Console.WriteLine(String.Join(",", s.ToArray()));

        }
    }
}
