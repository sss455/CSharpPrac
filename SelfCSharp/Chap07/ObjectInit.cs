using System;
using System.Runtime.ExceptionServices;

namespace SelfCSharp.Chap07
{
    internal class ObjectInit
    {
        static void Main(string[] args)
        {
            // オブジェクト初期化子
            var person = new Person()
            {
                lastName = "山田",
                firstName = "太郎",
            };

            Console.WriteLine($"{person.lastName} {person.firstName}");
        }
    }

    internal class Person 
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

}
