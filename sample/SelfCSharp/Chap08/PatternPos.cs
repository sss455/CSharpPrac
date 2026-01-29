namespace SelfCSharp.Chap08
{
    internal class PatternPos
    {
        static void Main(string[] args)
        {
            var t = ("C#", "Java", "Visual Basic");
            //var t = ("Python", "Ruby", "PHP");
            Console.WriteLine(t switch
            {
                ("C#", "Java", "Visual Basic") => "コンパイル言語",
                ("Python", "Ruby", var lang) => $"インタプリター言語{lang}",
                ("Kotlin", "TypeScript", _) => "トランスコンパイル言語",
                _ => "その他"
            });
        }
    }
}
