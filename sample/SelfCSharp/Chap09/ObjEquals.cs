namespace SelfCSharp.Chap09.ObjectEquals
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

        public override bool Equals(object? obj)
        {
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            return obj is Person p &&
                this.FirstName == p.FirstName &&
                this.LastName == p.LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

    }

    internal class ObjEquals
    {
        static void Main(string[] args)
        {
            var p = new Person("掛谷", "哲夫");
            var p2 = new Person("掛谷", "哲夫");
            Console.WriteLine(p.Equals(p2));
        }
    }
}
