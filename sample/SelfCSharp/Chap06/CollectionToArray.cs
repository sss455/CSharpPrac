namespace SelfCSharp.Chap06
{
    internal class CollectionToArray
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "バラ",
                "ひまわり",
                "あさがお"
            };
            var array = list.ToArray();

            Console.WriteLine(array[0]);
            Console.WriteLine(array.Length);
        }
    }
}
