namespace SelfCSharp.Chap05
{
    internal class DirectoryProcess
    {
        static void Main(string[] args)
        {
            var dir = new DirectoryInfo(@"C:\data\SelfCSharp");
            Console.WriteLine(dir.Exists);
            Console.WriteLine(dir.Parent);
            Console.WriteLine(dir.Root);
            Console.WriteLine(dir.CreationTime);
            Console.WriteLine(dir.LastAccessTime);
            Console.WriteLine(dir.LastWriteTime);

            var dirs = dir.GetDirectories();
            //var dirs = dir.GetDirectories("Chap*");
            //var dirs = dir.GetDirectories("*", SearchOption.AllDirectories);
            //var dirs = dir.GetFiles();

            foreach (var d in dirs)
            {
                Console.WriteLine(d.FullName);
            }

            var dir2 = new DirectoryInfo(@"C:\data\smp");
            dir2.Create();

            dir2.MoveTo(@"C:\data\test");

            dir2.MoveTo(@"C:\data\SelfCSharp\test");

            dir2.CreateSubdirectory("sub");

            dir2.Delete(true);
        }
    }
}
