using System;

namespace SelfCSharp.Chap11
{
    internal class AttrBasic
    {
        internal class Person
        {
            public string LastName { get; set; } = string.Empty;
            public string FirstName { get; set; } = string.Empty;

            [Obsolete("代替としてToStringメソッドを利用してください。")]
            public string Show()
            {
                return $"名前は{this.LastName}{this.FirstName}";
            }
        }

        static void Main(string[] args)
        {
            var p = new Person();
            Console.WriteLine(p.Show());
        }
     }
}
