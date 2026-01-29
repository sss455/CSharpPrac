namespace SelfCSharp.Chap07.Construct
{
    internal class Person
    {
        public string firstName;
        public string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person() : this("権兵衛", "名無") { }

        public void Show()
        {
            Console.WriteLine($"名前は{this.lastName}{this.firstName}です。");
        }
    }

    internal class ConstructorBasic
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Show();
        }
    }
}
