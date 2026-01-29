namespace SelfCSharp.Chap05
{
    internal class StreamRead
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"c:\data\sample.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
