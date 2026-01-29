namespace SelfCSharp.Chap09.RecordInherit
{
    public record Person(string FirstName, string LastName);
    public record BusinessPerson(string FirstName, string LastName)
        : Person(FirstName, LastName);
    public record Student(string FirstName, string LastName)
        : Person(FirstName, LastName);
        
    internal class RecordInherit
    {
        static void Main(string[] args)
        {
            Person p = new Person("太郎", "山田");
            Person bp = new BusinessPerson("太郎", "山田");
            BusinessPerson bp2 = new BusinessPerson("太郎", "山田");
            Person st = new Student("太郎", "山田");

            Console.WriteLine(bp);

            Console.WriteLine(bp == st);
            Console.WriteLine(p == bp);
            Console.WriteLine(bp == bp2);
        }
    }
}
