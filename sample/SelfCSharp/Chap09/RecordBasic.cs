
namespace SelfCSharp.Chap09.Record
{
    public record Person(string FirstName, string LastName, int Age);
    //public record struct Person(string FirstName, string LastName, int Age);
    internal class RecordBasic
    {
        static void Main(string[] args)
        {
            var p1 = new Person("太郎", "山田", 10);
            var p2 = new Person("太郎", "山田", 10);

            Console.WriteLine(p1);
            Console.WriteLine(p1 == p2);
            (string fname, string lname, int age) = p1;
            Console.WriteLine(fname);
        }
    }
}
