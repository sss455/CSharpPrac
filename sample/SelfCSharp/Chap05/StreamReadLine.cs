namespace SelfCSharp.Chap05
{
    internal class StreamReadLine
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"c:\data\sample.txt"))
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }
    }
}
