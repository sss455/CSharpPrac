namespace SelfCSharp.Chap09.RecordInherit
{
    public record Animal(string Name);
    public record Hamster(string Name, string Type) : Animal(Name);

    internal class RecordInheritWith
    {
        static void Main(string[] args)
        {
            Animal a = new Hamster("まめ", "ブルーサファイア");
            //Animal a2 = a with { Type = "スノーホワイト" };
            Animal a2 = (Hamster)a with { Type = "スノーホワイト" };
            Console.WriteLine(a2);
        }
    }
}
