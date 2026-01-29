namespace SelfCSharp.Chap09.Operator
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

        public bool Equals(Person? other)
        {
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (other == null || this.GetType() != other.GetType())
            {
                return false;
            }

            return this.FirstName == other.FirstName && this.LastName == other.LastName;
        }

        public override bool Equals(object? obj)
        {
            return this.Equals(obj as Person);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public static bool operator ==(Person? p1, Person? p2)
        {
            if (Object.ReferenceEquals(p1, p2))
            {
                return true;
            }

            if (p1 is null || p2 is null ||
                p1.GetType() != p2.GetType())
            {
                return false;
            }

            return p1.FirstName == p2.FirstName && p1.LastName == p2.LastName;
        }

        public static bool operator !=(Person? p1, Person? p2)
        {
            return !(p1 == p2);
        }
    }

    internal class OpeOverload
    {
        static void Main(string[] args)
        {
            var p1 = new Person("山田", "太郎");
            var p2 = new Person("山田", "太郎");
            var p3 = new Person("掛谷", "康太");
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 != p3);
        }
    }
}
