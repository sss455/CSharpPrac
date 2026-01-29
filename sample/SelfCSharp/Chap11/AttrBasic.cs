namespace SelfCSharp.Chap11
{
    internal class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        [Obsolete("代替としてToStringメソッドを利用してください。")]
        public string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }

    internal class AttrBasic
    {
        static void Main(string[] args)
        {
            Person p = new Person
            {
                FirstName = "太郎",
                LastName = "山田"
            };
            Console.WriteLine(p.Show());
        }
    }
}
