namespace SelfCSharp.Chap09.ObjectBasic
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return $"Person: {this.LastName} {this.FirstName}";
        }
    }

    internal class ObjString
    {
        static void Main(string[] args)
        {
            var p = new Person("太郎", "山田");
            Console.WriteLine(p.ToString());
        }
    }
}


