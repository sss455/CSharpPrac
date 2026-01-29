namespace SelfCSharp.Chap09
{
    internal partial class MyPartial
    {
        public string Greet()
        {
            return $"こんにちは、{this.LastName}{this.FirstName}さん！";
        }
    }
}
