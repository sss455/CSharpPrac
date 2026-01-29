using System;

namespace SelfCSharp.Chap09
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName  { get; private set; }
        public int    Age       { get; private set; }

        public Person(string firstName, string lastName, int age) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        // 分解のためのルール
        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = this.FirstName;
            lastName = this.LastName;
        }
            
    }

    internal class ObjDeconstruct
    {
        static void Main(string[] args)
        {
            var person = new Person("太郎", "山田", 20);

            var (fn1, ln1) = person;
            (string fn2, string ln2) = person;

            Console.WriteLine(ln1 + fn1);
            Console.WriteLine(ln2 + fn2);
        }
    }
}
