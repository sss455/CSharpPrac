namespace SelfCSharp.Chap05.Practice
{
    internal class PSplit
    {
        static void Main(string[] args)
        {
            var str = "鈴木\t太郎\t男\t50歳\t広島県";
            var data = str.Split('\t');
            foreach (var tmp in data)
            {
                Console.WriteLine(tmp);
            }
        }
    }
}
