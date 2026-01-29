namespace SelfCSharp.Chap05
{
    internal class FileStaticProcess
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.Exists(@"C:\data\sample.txt"));
            Console.WriteLine(File.GetLastAccessTime(@"C:\data\sample.txt"));
            Console.WriteLine(File.GetLastWriteTime(@"C:\data\sample.txt"));

            File.Copy(@"C:\data\sample.txt", @"C:\data\sample_copy.txt", true);

            File.Move(@"C:\data\sample_copy.txt", @"C:\data\SelfCSharp\sample_copy.txt");

            File.Move(@"C:\data\SelfCSharp\sample_copy.txt", @"C:\data\SelfCSharp\sample_renamed.txt");

            File.Delete(@"C:\data\SelfCSharp\sample_renamed.txt");
        }
    }
}
