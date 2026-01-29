namespace SelfCSharp.Chap05
{
    internal class StreamWriteAll
    {
        static void Main(string[] args)
        {
            var lines = new[] { "2021/12/31 23:59:59", "2022/01/01 06:15:30" };
            File.WriteAllLines(@"c:\data\data.log", lines);
        }
    }
}
