namespace SelfCSharp.Chap08.Inherit
{
    internal sealed class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }

    //internal class BusinessPerson : Person { }

    internal class InheritNg
    {
        static void Main(string[] args)
        {
            //var c = new BusinessPerson();
        }
    }
}
