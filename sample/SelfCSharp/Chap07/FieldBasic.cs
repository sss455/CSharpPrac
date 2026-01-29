namespace SelfCSharp.Chap07.ClassField
{
    internal class Person
    {
        public string firstName = "";
        public string lastName = "";
    }

    internal class FieldBasic
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.firstName = "太郎";
            p1.lastName = "山田";

            var p2 = new Person();
            p2.firstName = "花子";
            p2.lastName = "鈴木";

            Console.WriteLine($"{p1.lastName}{p1.firstName}");
            Console.WriteLine($"{p2.lastName}{p2.firstName}");
        }
    }
}
