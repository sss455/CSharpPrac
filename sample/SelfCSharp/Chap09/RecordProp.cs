namespace SelfCSharp.Chap09.RecordProp
{
    public record Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }

    }

    internal class RecordProp
    {
        static void Main(string[] args)
        {
            var p = new Person()
            {
                FirstName = "太郎",
                LastName = "山田",
                Age = 10
            };
            Console.WriteLine($"{p.LastName} {p.FirstName} {p.Age}歳");
        }
    }
}
