namespace SelfCSharp.Chap05
{
    internal class DirectoryStaticProcess
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Directory.Exists(@"C:\data\SelfCSharp"));
            Console.WriteLine(Directory.GetParent(@"C:\data\SelfCSharp"));
            Console.WriteLine(Directory.GetDirectoryRoot(@"C:\data\SelfCSharp"));
            Console.WriteLine(Directory.GetCreationTime(@"C:\data\SelfCSharp"));
            Console.WriteLine(Directory.GetLastAccessTime(@"C:\data\SelfCSharp"));
            Console.WriteLine(Directory.GetLastWriteTime(@"C:\data\SelfCSharp"));

            var dirs = Directory.GetDirectories(@"C:\data\SelfCSharp");
            foreach (var d in dirs)
            {
                Console.WriteLine(d);
            }

            Directory.CreateDirectory(@"C:\data\smp");

            Directory.Move(@"C:\data\smp", @"C:\data\test");

            Directory.Move(@"C:\data\test", @"C:\data\SelfCSharp\test");

            Directory.Delete(@"C:\data\SelfCSharp\test");
        }
    }
}
