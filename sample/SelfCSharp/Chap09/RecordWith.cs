namespace SelfCSharp.Chap09.RecordWith
{
    public record Person(string FirstName, string LastName, int Age);

    internal class RecordWith
    {
        static void Main(string[] args)
        {
            var p = new Person("太郎", "山田", 10);
            var pc1 = p with { Age = 20 };
            var pc2 = p with { };

            Console.WriteLine(pc1);
            Console.WriteLine(pc2);
            Console.WriteLine(p == pc2);
            Console.WriteLine(Object.ReferenceEquals(p, pc2));
        }
    }
}
