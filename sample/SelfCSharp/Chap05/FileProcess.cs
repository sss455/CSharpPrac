namespace SelfCSharp.Chap05
{
    internal class FileProcess
    {
        static void Main(string[] args)
        {
            var file = new FileInfo(@"C:\data\sample.txt");

            Console.WriteLine(file.Exists);
            Console.WriteLine(file.Name);
            Console.WriteLine(file.DirectoryName);
            Console.WriteLine(file.IsReadOnly);
            Console.WriteLine(file.LastAccessTime);
            Console.WriteLine(file.LastWriteTime);
            Console.WriteLine(file.Length);

            var file2 = file.CopyTo(@"C:\data\sample_copy.txt", true);

            file2.MoveTo(@"C:\data\SelfCSharp\sample_copy.txt");

            file2.MoveTo(@"C:\data\SelfCSharp\sample_renamed.txt");

            file2.Delete();
        }
    }
}
