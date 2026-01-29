namespace SelfCSharp.Chap06
{
    internal class SetInclude
    {
        static void Main(string[] args)
        {
            var hs1 = new HashSet<int> { 1, 10, 15, 20, 30 };
            var hs2 = new HashSet<int> { 10, 15, 30 };
            var hs3 = new HashSet<int> { 1, 10, 15, 20, 30 };

            Console.WriteLine(hs1.Contains(15));

            Console.WriteLine(hs1.IsSupersetOf(hs2));
            Console.WriteLine(hs1.IsProperSupersetOf(hs2));
            Console.WriteLine(hs1.IsProperSupersetOf(hs3));

            Console.WriteLine(hs2.IsSubsetOf(hs1));
            Console.WriteLine(hs2.IsProperSubsetOf(hs1));
            Console.WriteLine(hs3.IsProperSubsetOf(hs1));

            Console.WriteLine(hs1.Overlaps(hs2));

            //Console.WriteLine(hs1.Contains(hs2));
        }
    }
}
