using SelfCSharp.Chap08.Prop;

namespace SelfCSharp.Chap08
{
    internal class PatternProp
    {
        static void Main(string[] args)
        {
            var p = new Person
            {
                FirstName = "太郎",
                LastName = "山田"
            };
            Console.WriteLine(p switch
            {
                { FirstName: "太郎", LastName: var ln } => $"{ln}タロくん、こんにちは。",
                { FirstName: "次郎", LastName: "鈴木" } => "鈴木次郎くんですね。",
                _ => "どなたですか？"
            });
        }
    }
}
