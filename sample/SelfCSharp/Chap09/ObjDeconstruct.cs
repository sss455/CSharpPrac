namespace SelfCSharp.Chap09
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = this.FirstName;
            lastName = this.LastName;
        }

        public void Deconstruct(
            out string firstName, out string lastName, out int age)
        {
            firstName = this.FirstName;
            lastName = this.LastName;
            age = this.Age;
        }
    }

    internal class ObjDeconstruct
    {
        static void Main(string[] args)
        {
            var p = new Person("太郎", "山田", 20);
            //var (fn, ln) = p;
            var (fn, ln, age) = p;
            Console.WriteLine(fn);
            Console.WriteLine(ln);
            Console.WriteLine(age);
        }
    }
}
