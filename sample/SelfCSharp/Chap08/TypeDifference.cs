namespace SelfCSharp.Chap08.CastType
{
    internal class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public virtual string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";

        }
    }

    internal class BusinessPerson : Person
    {
        public override string Show()
        {
            return $"会社員の{this.LastName}{this.FirstName}です。";
        }

        public string Work()
        {
            return $"{this.LastName}{this.FirstName}は、働きます。";
        }
    }

    internal class TypeDifference
    {
        static void Main(string[] args)
        {
            Person p = new BusinessPerson
            {
                FirstName = "太郎",
                LastName = "山田"
            };
            //Console.WriteLine(p.Work());
            Console.WriteLine(p.Show());
        }
    }
}
