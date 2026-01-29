using System;

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

        //「==」演算子のオーバーロード
        public static bool operator ==(Person? p1, Person? p2)
        {
            if (Object.ReferenceEquals(p1, p2))
            {
                return true;
            }

            if (p1 is null || p2 is null || p1.GetType() != p2.GetType())
            {
                return false;
            }

            return p1.FirstName == p2.FirstName && p1.LastName == p2.LastName;
        }

        //「!=」演算子のオーバーロード
        public static bool operator !=(Person? p1, Person? p2)
        {
            return !(p1 == p2);
        }
    }

    internal class OpeOverload
    {
        static void Main(string[] args)
        {
            var p1 = new Person("太郎", "山田");
            var p2 = new Person("太郎", "山田");
            var p3 = new Person("花子", "鈴木");

            Console.WriteLine(p1 == p2);    // 結果：True
            Console.WriteLine(p1 != p3);    // 結果：True
        }
    }
}
