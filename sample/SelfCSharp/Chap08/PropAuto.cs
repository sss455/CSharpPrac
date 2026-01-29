namespace SelfCSharp.Chap08.Prop
{
    internal class Person
    {
        public string FirstName { get; set; } = "";
        //public string FirstName { get; private set; } = "";
        //public string FirstName { get; set; } = "権兵衛";
        //public string FirstName { get; } = "";

        public string LastName { get; set; } = "";

        public string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }

    internal class PropAuto
    {
        static void Main(string[] args)
        {
            var p = new Person
            {
                FirstName = "太郎",
                LastName = "山田"
            };
            Console.WriteLine(p.Show());
        }
    }
}
