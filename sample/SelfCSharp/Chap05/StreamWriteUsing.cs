namespace SelfCSharp.Chap05
{
    internal class StreamWriteUsing
    {
        static void Main(string[] args)
        {
            using var writer = new StreamWriter(@"c:\data\data.log");
            writer.WriteLine(DateTime.Now.ToString());
        }
    }
}
