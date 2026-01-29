namespace SelfCSharp.Chap06
{
    internal class ListSort
    {
        static void Main(string[] args)
        {
            var list = new List<string>()
            {
                "バラ",
                "ひまわり",
                "あざみ"
            };

            list.Sort(new StringLengthComparer());

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
