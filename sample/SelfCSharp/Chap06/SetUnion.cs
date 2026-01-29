namespace SelfCSharp.Chap06
{
    internal class SetUnion
    {
        static void PrintSet<T>(HashSet<T> set)
        {
            Console.WriteLine(String.Join(",", set.ToArray()));
        }
        static void Main(string[] args)
        {
            var hs = new HashSet<int> { 1, 10, 15, 20, 30 };

            hs.IntersectWith(new HashSet<int>() { 1, 10, 20, 30, 60 });
            PrintSet(hs);

            hs.ExceptWith(new HashSet<int> { 15, 30 });
            PrintSet(hs);

            hs.UnionWith(new HashSet<int> { 10, 15, 30 });
            PrintSet(hs);

            hs.SymmetricExceptWith(new HashSet<int> { 1, 10, 30 });
            PrintSet(hs);
        }
    }
}
