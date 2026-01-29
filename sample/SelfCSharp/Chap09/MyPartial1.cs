namespace SelfCSharp.Chap09
{
    internal partial class MyPartial
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }
}
