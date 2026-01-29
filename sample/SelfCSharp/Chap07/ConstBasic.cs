namespace SelfCSharp.Chap07.ClassConst
{
    internal class Person
    {
        public string firstName;
        //public string firstName = "Yoshihiro";

        public string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string Show()
        {
            return $"名前は{this.lastName}{this.firstName}です。";
        }
    }

    internal class ConstBasic
    {
        static void Main(string[] args)
        {
            var p = new Person("太郎", "山田");
            Console.WriteLine(p.Show());
        }
    }
}
